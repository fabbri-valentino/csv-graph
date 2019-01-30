using CSVGraph.Data;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;

namespace CSVGraph.Engine
{
    public class CsvReader
    {
        #region Unused Variables
        public int nLines { get; private set; }
        public int nColumns { get; private set; }
        public string[] header { get; private set; }
        public float[,] data { get; private set; }
        public string fileName { get; set; }
        public string[] section { get; private set; }
        public string[] pieces { get; private set; }
        #endregion

        public CsvReader(string file, Enum enumDelimiter)
        {
            char[] delimiters = { ',', ';' };
            //try
            //{
                switch (enumDelimiter)
                {
                    case Delimiters.comma:
                        ExecuteCsv(delimiters[0], file);
                        break;
                    case Delimiters.semicolon:
                        ExecuteCsv(delimiters[1], file);
                        break;
                }
            /*}
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }*/
        }

        public static Encoding GetEncoding(string filename)
        {
            var bom = new byte[4];
            using (var file = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                file.Read(bom, 0, 4);
            }
            
            if (bom[0] == 0x2b && bom[1] == 0x2f && bom[2] == 0x76) return Encoding.UTF7;
            if (bom[0] == 0xef && bom[1] == 0xbb && bom[2] == 0xbf) return Encoding.UTF8;
            if (bom[0] == 0xff && bom[1] == 0xfe) return Encoding.Unicode; //UTF-16LE
            if (bom[0] == 0xfe && bom[1] == 0xff) return Encoding.BigEndianUnicode; //UTF-16BE
            if (bom[0] == 0 && bom[1] == 0 && bom[2] == 0xfe && bom[3] == 0xff) return Encoding.UTF32;
            return Encoding.ASCII;
        }

        public void ExecuteCsv(char delimiters, string file)
        {
            var tmpFileName = Path.GetTempFileName();
            //var fileName = Path.GetFileNameWithoutExtension(file);
            //var lines = File.ReadAllLines(file);
            var lines_text = File.ReadAllText(file);
            var regex = Regex.Replace(lines_text, "\"", string.Empty);
            File.AppendAllText(tmpFileName, regex);
            var conv_lines = File.ReadAllLines(tmpFileName);
            if (conv_lines == null || conv_lines.Length < 2) return;
            //header = conv_lines[0].Split(delimiters); se l'header è presente -> header[0] , header[n]
            //var convHeader = DateTime.Parse(header[1]);
            var table = new DataTable
            {
                TableName = "Data",
            };

            var VarName = new DataColumn() { AllowDBNull = true, DataType = typeof(string), ColumnName = "VarName" };
            var TimeString = new DataColumn() { AllowDBNull = true, DataType = typeof(string), /*DateTimeMode = DataSetDateTime.Local,*/ ColumnName = "TimeString" };
            var VarValue = new DataColumn() { AllowDBNull = true, DataType = typeof(float), ColumnName = "VarValue" };
            var VarPosition = new DataColumn() { AllowDBNull = true, DataType = typeof(float), ColumnName = "VarPosition" };
            var Validity = new DataColumn() { AllowDBNull = true, DataType = typeof(byte), ColumnName = "Validity" };
            var TimeMs = new DataColumn() { AllowDBNull = true, DataType = typeof(float), ColumnName = "Time_ms" };
            table.Columns.Add(VarName);
            table.Columns.Add(TimeString);
            table.Columns.Add(VarValue);
            table.Columns.Add(VarPosition);
            table.Columns.Add(Validity);
            table.Columns.Add(TimeMs);

            for (int i = 1; i < conv_lines.Length; i++)
            {
                table.Rows.Add(conv_lines[i].Split(delimiters));
            }
            
            var dbo = "dbo";
            var tableName = "Data";

            SqlBulkCopy sqlBulk = new SqlBulkCopy(Operation.GetConnectionString())
            {
               DestinationTableName = $"{dbo}.[{tableName}]"
            };
            //                         file       db
            sqlBulk.ColumnMappings.Add("VarName", "VarName");
            sqlBulk.ColumnMappings.Add("TimeString", "TimeString");
            sqlBulk.ColumnMappings.Add("VarValue", "VarValue");
            sqlBulk.ColumnMappings.Add("VarPosition", "VarPosition");
            sqlBulk.ColumnMappings.Add("Validity", "Validity");
            sqlBulk.ColumnMappings.Add("Time_ms", "Time_ms");
            sqlBulk.WriteToServer(table);

            int rowsCopied = SqlBulkCopyExtension.GetRowsCopied(sqlBulk);
            ImportaCsv form = new ImportaCsv();
            if (rowsCopied == conv_lines.Length - 1)
            {
                MessageBox.Show("Sono state copiate " + rowsCopied + " righe");
                if (conv_lines != null) { File.Delete(tmpFileName + "temp.csv"); }
            }
            else if (rowsCopied > 0 && conv_lines.Length - 1 < rowsCopied)
            {
                MessageBox.Show("Sono state copiate " + rowsCopied + " righe. " + ((conv_lines.Length - 1) - (rowsCopied)) + " in meno" );
                if (conv_lines != null) { File.Delete(tmpFileName + "temp.csv"); }
            }
            else
            {
                MessageBox.Show("Si è verificato un errore durante l'elaborazione del file.");
                if (conv_lines != null) { File.Delete(tmpFileName + "temp.csv"); }
            }
        }

        #region Unused Method
        public void ReadAllColumns(char delimiters, string file)
        {
            fileName = Path.GetFileName(file);
            string[] lines = File.ReadAllLines(file);
            if (lines == null || lines.Length < 2) return;
            header = lines[0].Split(delimiters);
            nLines = lines.Length - 1;
            nColumns = header.Length;

            data = new float[nLines, nColumns - 1];
            section = new string[nLines];
            for (int i = 0; i < nLines; i++)
            {
                pieces = lines[i + 1].Split(delimiters);
                if (pieces.Length != nColumns) { MessageBox.Show("Dati non validi alla linea " + (i + 2) + " del file " + fileName); return; }
                for (int j = 0; j < nColumns - 1; j++)
                {
                    float.TryParse(pieces[j], out data[i, j]);
                }
                section[i] = pieces[nColumns - 1];
            }
        }
        #endregion
    }
}
