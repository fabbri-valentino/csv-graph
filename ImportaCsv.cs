using CSVGraph.Engine;
using Syncfusion.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CSVGraph
{
    public partial class ImportaCsv : Form
    {
        List<CsvReader> rrList = new List<CsvReader>();
        public ImportaCsv()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CsvReader rr;
            OpenFileDialog ff = new OpenFileDialog
            {
                InitialDirectory = @"C:\Users\AGF9\source\repos\CSVGraph\Current",
                Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*",
                Multiselect = true,
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (ff.ShowDialog() == DialogResult.OK)
            {
                rrList.Clear();
                foreach (string file in ff.FileNames)
                {
                    switch (checkBox1.CheckState)
                    {
                        case CheckState.Checked:
                            rr = new CsvReader(file, Delimiters.semicolon);
                            rrList.Add(rr);
                            break;
                        case CheckState.Unchecked:
                            rr = new CsvReader(file, Delimiters.comma);
                            rrList.Add(rr);
                            break;
                        case CheckState.Indeterminate:
                            MessageBox.Show("Qualcosa non va con la checkbox");
                            break;
                    }
                }
                /*
                if (rrList.Count > 0)
                {
                    string[] header = rrList[0].header;
                    comboBox1.DataSource = header;
                    comboBox2.DataSource = header.Clone();
                }
                if (comboBox2.Items.Count > 1) comboBox2.SelectedIndex = 1;
            }*/
            }
        }
    }
}
