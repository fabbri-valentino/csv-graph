using CSVGraph.Data;
using Syncfusion.Windows.Forms.Chart;
using System;
using System.Windows.Forms;

namespace CSVGraph
{
    public partial class SyncChart : Form
    {
        internal string passSetName { get; set; }

        public SyncChart()
        {
            InitializeComponent();
            refreshdata();
        }

        #region ChartDataBinding
        private void BindChart(object populations)
        {
            #region Series
            this.chartControl1.Series.Clear();
            ChartSeries series = new ChartSeries("Trend");
            ChartDataBindModel dataSeriesModel = new ChartDataBindModel(populations)
            {
                YNames = new string[] { "VarValue" },
                XName = "VarPosition"
            };
            
            this.chartControl1.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.Rotate;
            this.chartControl1.PrimaryXAxis.ValueType = ChartValueType.Double;

            series.SeriesModel = dataSeriesModel;
            series.Type = ChartSeriesType.StepLine;
            series.FancyToolTip.ResizeInsideSymbol = true;
            series.Name = "Trend";
            series.StackingGroup = "Default Group";
            series.Style.Border.Width = 2F;
            series.Style.Border.Color = System.Drawing.Color.Black;
            series.Style.Border.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            series.Style.DisplayShadow = false;
            series.Style.DisplayText = false;
            series.Style.DrawTextShape = false;
            
            ChartDataBindAxisLabelModel dataLabelsModel = new ChartDataBindAxisLabelModel(populations);
            dataLabelsModel.LabelName = "Misurazione";
            chartControl1.Series.Add(series);
            chartControl1.PrimaryXAxis.LabelsImpl = dataLabelsModel;
            #endregion
        }
        #endregion

        private void chartControl1_Click(object sender, EventArgs e)
        {
            passSetName = comboBox1.SelectedText;
            this.Refresh();
            BindChart(Operation.GetAllLogs(passSetName));
        }

        public void refreshdata()
        {
            comboBox1.ValueMember = "id";
            comboBox1.DisplayMember = "VarName";
            comboBox1.DataSource = Operation.GetVarName();
        }
    }
}
