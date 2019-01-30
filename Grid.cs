using CSVGraph.MyDataSetTableAdapters;
using Syncfusion.GridHelperClasses;
using Syncfusion.Windows.Forms.Grid;
using System;
using System.Data;
using System.Windows.Forms;

namespace CSVGraph
{
    public partial class Grid : Form
    {
        MyDataSet myDataSet = new MyDataSet();
        DataTableAdapter logsTableAdapter = new DataTableAdapter();
        DataTable tempTable = new DataTable();
        DataTableReader Reader { get; set; }
        public int Result { get; set; }

        public Grid()
        {
            InitializeComponent();
            this._gridGroupingControl2.SizeChanged +=
                new EventHandler(gridGroupingControl1_SizeChanged);
            this._gridGroupingControl2.TableControl.Model.QueryColWidth +=
                new GridRowColSizeEventHandler(grid_QueryColWidth);
            this.SCROLLBARWIDTH = SystemInformation.VerticalScrollBarWidth;
        }
        private void Grid_Load(object sender, System.EventArgs e)
        {
            logsTableAdapter.Fill(myDataSet.Data);
            Reader = myDataSet.Data.CreateDataReader();
            tempTable.Load(Reader);
            if (tempTable.Rows.Count == 0)
            {
                MessageBox.Show("Non sono presenti righe nel database.");
            }
            else
            {
                Pager pager = new Pager
                {
                    PageSize = 100
                };
                try
                {
                    this._gridGroupingControl2.DataSource = tempTable;
                    this._gridGroupingControl2.TopLevelGroupOptions.ShowFilterBar = true;
                    foreach (var col in this._gridGroupingControl2.TableDescriptor.Columns)
                        col.AllowFilter = true;
                    pager.Wire(this._gridGroupingControl2, tempTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        } 

        private int SCROLLBARWIDTH;

        private void grid_QueryColWidth(object sender, GridRowColSizeEventArgs e)
        {
            int last = this._gridGroupingControl2.TableDescriptor.VisibleColumns.Count;
            if (e.Index == last + this._gridGroupingControl2.TableDescriptor.GroupedColumns.Count)
            {
                int vscrollwidth = ((this._gridGroupingControl2.TableControl.Model.RowHeights.GetTotal(0, this._gridGroupingControl2.TableControl.Model.RowCount)
                    + this._gridGroupingControl2.TableOptions.CaptionRowHeight)
                    > this._gridGroupingControl2.ClientSize.Height)
                    ? SCROLLBARWIDTH : 0;
                e.Size = this._gridGroupingControl2.ClientSize.Width -
                    this._gridGroupingControl2.TableControl.Model.ColWidths.GetTotal(0, e.Index - 1)
                    - vscrollwidth;
                e.Handled = true;
            }
        }

        private void gridGroupingControl1_SizeChanged(object sender, EventArgs e)
        {
            this._gridGroupingControl2.Refresh();
        }

        private void sfButton1_Click(object sender, EventArgs e)
        {
            try
            {
                //tempTable.Clear();
                this._gridGroupingControl2.Refresh();
                this._gridGroupingControl2.Update();
                logsTableAdapter.Fill(myDataSet.Data);
                Reader = myDataSet.Data.CreateDataReader();
                tempTable.Load(Reader);
                Pager pager = new Pager
                {
                    PageSize = 100
                };
                this._gridGroupingControl2.DataSource = tempTable;
               /*_gridGroupingControl2.TopLevelGroupOptions.ShowFilterBar = true;
                foreach (var col in _gridGroupingControl2.TableDescriptor.Columns)
                    col.AllowFilter = true;*/
                pager.Wire(this._gridGroupingControl2, tempTable);
            }
            catch(Exception f)
            {
                MessageBox.Show(f.Message);
            }
        }
    }
}
