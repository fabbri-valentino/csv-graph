using CSVGraph.Data;
using Syncfusion.Windows.Forms.Chart;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSVGraph
{
    public partial class SyncChart : Form
    {
        public SyncChart()
        {
            InitializeComponent();
            //BindChart(Operation.GetLogsIfValidByVarDate());
        }

        #region ChartDataBinding
        private void BindChart(object populations)
        {
            #region Series
            this.chartControl1.Series.Clear();
            ChartSeries series = new ChartSeries("Trend");
            ChartDataBindModel dataSeriesModel = new ChartDataBindModel(populations);
            dataSeriesModel.YNames = new string[] { "VarValue" };
            dataSeriesModel.XName = "TimeString";
            
            // Specifying IntervalType
            this.chartControl1.PrimaryXAxis.IntervalType = ChartDateTimeIntervalType.Auto;
            this.chartControl1.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.Rotate;
            this.chartControl1.PrimaryXAxis.ValueType = ChartValueType.DateTime;

            // Specifying RangeType
            this.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Auto;
            //this.chartControl1.PrimaryXAxis.DateTimeRange = new ChartDateTimeRange(start, start.AddDays(42), 7, ChartDateTimeIntervalType.Days);
            //this.chartControl1.PrimaryXAxis.DateTimeInterval.Type = ChartDateTimeIntervalType.Days;

            this.chartControl1.PrimaryXAxis.DateTimeFormat = "dd/MM/yy hh:mm:ss";

            series.SeriesModel = dataSeriesModel;
            series.Type = ChartSeriesType.StepLine;
            series.FancyToolTip.ResizeInsideSymbol = true;
            series.Name = "Trend";
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
            #endregion
        }
        #endregion
    }
}
