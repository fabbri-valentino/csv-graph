using CSVGraph.Logger;
using CSVGraph.Directories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CSVGraph.Extension
{
    public static class SqlExtensions
    {
        public static bool IsAvailable(this SqlConnection conn)
        {
            try
            {
                conn.Open();
                conn.Close();
            }
            catch (SqlException ex)
            {
                ExceptionWriter ew = new ExceptionWriter();
                string[] exArray = { "BEGIN "+ ex.HResult +" EXCEPTION",
                    DateTime.Now.ToString("r") + " - Messaggio:", ex.Message,
                    "END "+ ex.HResult +" EXCEPTION" };
                IEnumerable<string> content = exArray;
                ew.Write(ErrorTypes.Exceptions, content);
                return false;
            }
            return true;
        }
    }

}