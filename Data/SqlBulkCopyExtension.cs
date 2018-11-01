using System.Data.SqlClient;
using System.Reflection;

namespace CSVGraph.Data
{
    public static class SqlBulkCopyExtension
    {
        public static FieldInfo rowsCopiedField = null;

        /// <summary>
        /// Ritorna il numero di righe elaborate
        /// </summary>
        /// <param name="bulkCopy"></param>
        /// <returns></returns>
        public static int GetRowsCopied(SqlBulkCopy bulkCopy)
        {
            if (rowsCopiedField == null)
            {
                rowsCopiedField = typeof(SqlBulkCopy).GetField("_rowsCopied", BindingFlags.NonPublic | BindingFlags.GetField | BindingFlags.Instance);
            }

            return (int)rowsCopiedField.GetValue(bulkCopy);
        }
    }
}
