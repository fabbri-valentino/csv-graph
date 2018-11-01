using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CSVGraph.Engine
{
    public class Plot
    {
        public static void Draw(List<CsvReader> rrList, ComboBox xBox, ComboBox yBox, Chart chart) 
        {
            int indX = xBox.SelectedIndex;
            int indY = yBox.SelectedIndex;

            chart.Series.Clear(); 
            chart.Legends.Clear();
            Legend myLegend = chart.Legends.Add("Leggenda");
            myLegend.Title = "Reports";
            
            Color[] colors = new Color[] { Color.Blue, Color.Red, Color.Green, Color.Magenta, Color.DarkCyan, Color.Chocolate, Color.DarkMagenta };

            var sectionColors = new Dictionary<string, int>();
            int i = 0;
            int iColor = -1, maxColor = -1;
            foreach (CsvReader rr in rrList)
            {
                float[,] data = rr.data;
                int nLines = rr.nLines;
                int nColumns = rr.nColumns;
                string[] header = rr.header;
                string[] pieces = rr.pieces;
                chart.Series.Add("Serie" + i);
                chart.Series[i].ChartType = SeriesChartType.Line;
               
                //chart.Series[i].LegendText = rr.fileName;
                chart.Series[i].IsVisibleInLegend = false;
                chart.Series[i].SmartLabelStyle.Enabled = true;
                chart.ChartAreas[0].AxisX.LabelStyle.Format = "{F2}";
                chart.ChartAreas[0].AxisX.Title = header[indX];
                chart.ChartAreas[0].AxisY.Title = header[indY];

                for (int j = 0; j < nLines; j++)
                {
                    int k = chart.Series[i].Points.AddXY(data[j, indX], data[j, indY]);
                    string curSection = rr.section[j];
                    if (sectionColors.ContainsKey(curSection))
                    {
                        iColor = sectionColors[curSection];
                    }
                    else
                    {
                        maxColor++;
                        iColor = maxColor; sectionColors[curSection] = iColor;
                    }
                    chart.Series[i].Points[k].Color = colors[iColor];
                }
                i++; 
            }
            
            foreach (var x in sectionColors)
            {
                string section = x.Key;
                iColor = x.Value;
                myLegend.CustomItems.Add(colors[iColor], section); 
            }
        }
    }
}