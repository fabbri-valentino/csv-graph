using CSVGraph.Engine;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CSVGraph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<CsvReader> rrList = new List<CsvReader>();
      
        private void button1_Click(object sender, EventArgs e)
        {
            Plot.Draw(rrList, comboBox1, comboBox2, chart1);
        }

        private void apriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ff = new OpenFileDialog();
            CsvReader rr;

            ff.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ff.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            ff.Multiselect = true;
            ff.FilterIndex = 1;
            ff.RestoreDirectory = true;

            if (ff.ShowDialog() == DialogResult.OK)
            {
                try
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
                    
                    if (rrList.Count > 0)
                    {
                        string[] header = rrList[0].header; 
                        comboBox1.DataSource = header;
                        comboBox2.DataSource = header.Clone();
                    }
                    if (comboBox2.Items.Count > 1) comboBox2.SelectedIndex = 1; 
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }
    }
}
