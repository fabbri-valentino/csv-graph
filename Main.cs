using System.Threading;
using System.Windows.Forms;
using CSVGraph.Directories;
using Syncfusion.WinForms.Controls;

namespace CSVGraph
{
    public partial class Main : SfForm
    {
        CreateLocalDir createLocalDir = new CreateLocalDir();
        CreateRegistryDir createRegistryDir = new CreateRegistryDir();
        public Main()
        {
            InitializeComponent();
            createLocalDir.Initialize();
            createRegistryDir.Initialize();
        }

        private void Main_Load(object sender, System.EventArgs e)
        {
        }

        private void BindChart(object populations)
        {
            #region Series
            /*
            this.chartControl1.Series.Clear();
            ChartSeries series = new ChartSeries("Profilo");
            ChartDataBindModel dataSeriesModel = new ChartDataBindModel(populations);
            dataSeriesModel.YNames = new string[] { "Misura" };
            dataSeriesModel.XName = "Posizione";
            series.SeriesModel = dataSeriesModel;
            series.Type = ChartSeriesType.StepLine;
            series.FancyToolTip.ResizeInsideSymbol = true;
            series.Name = "Profilo";
            series.Resolution = 0D;
            series.StackingGroup = "Default Group";
            series.Style.Border.Color = System.Drawing.Color.Black;
            series.Style.Border.Width = 1F;
            series.Style.Border.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            series.Style.DisplayShadow = true;
            series.Style.DisplayText = true;
            series.Style.DrawTextShape = false;
            ChartDataBindAxisLabelModel dataLabelsModel = new ChartDataBindAxisLabelModel(populations);
            dataLabelsModel.LabelName = "Misurazione";
            chartControl1.Series.Add(series);
            chartControl1.PrimaryXAxis.LabelsImpl = dataLabelsModel;
            */
            #endregion
        }

        private void sfButton1_Click(object sender, System.EventArgs e)
        {
            ImportaCsv importCsv = new ImportaCsv
            {
                TopLevel = false,
                AutoScroll = true
            };
            panel2.Controls.Clear();
            panel2.Visible = true;
            panel2.Controls.Add(importCsv);
            importCsv.FormBorderStyle = FormBorderStyle.None;
            importCsv.Dock = DockStyle.Fill;
            importCsv.Show();
        }

        private void sfButton2_Click(object sender, System.EventArgs e)
        {
            ConnectionString connectionString = new ConnectionString
            {
                TopLevel = false,
                AutoScroll = true
            };
            panel2.Controls.Clear();
            panel2.Visible = true;
            panel2.Controls.Add(connectionString);
            connectionString.FormBorderStyle = FormBorderStyle.None;
            connectionString.Dock = DockStyle.Fill;
            connectionString.Show();
        }

        private void sfButton3_Click(object sender, System.EventArgs e)
        {
            Grid grid = new Grid
            {
                TopLevel = false,
                AutoScroll = true
            };
            panel2.Controls.Clear();
            panel2.Visible = true;
            panel2.Controls.Add(grid);
            grid.FormBorderStyle = FormBorderStyle.None;
            grid.Dock = DockStyle.Fill;
            grid.Show();
        }

        private void sfButton4_Click(object sender, System.EventArgs e)
        {
            SyncChart chart = new SyncChart
            {
                TopLevel = false,
                AutoScroll = true
            };
            panel2.Controls.Clear();
            panel2.Visible = true;
            panel2.Controls.Add(chart);
            chart.FormBorderStyle = FormBorderStyle.None;
            chart.Dock = DockStyle.Fill;
            chart.Show();
        }
    }
}
