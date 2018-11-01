using CSVGraph.Directories;
using CSVGraph.RegistryManager;
using Syncfusion.WinForms.Controls;
using System;
using System.IO;
using System.Windows.Forms;

namespace CSVGraph
{
    public partial class ConnectionString : Form
    {
        public ConnectionString()
        {
            InitializeComponent();
        }

        private void buttonZ1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
                return;
            else if (textBox2.Text == string.Empty)
                return;

            ManageData.SetKey(RegistryDir.ConnectionSubDir, true, keyName: "DataSource", keyValue: textBox1.Text);
            ManageData.SetKey(RegistryDir.ConnectionSubDir, true, keyName: "DBPath", keyValue: textBox2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ff = new OpenFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                Filter = "mdf files (*.mdf)|*.mdf|All files (*.*)|*.*",
                Multiselect = true,
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (ff.ShowDialog() != DialogResult.OK)
                return;
            textBox2.Text = Path.GetFullPath(ff.FileName);
        }
    }
}
