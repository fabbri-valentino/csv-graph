using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using static CSVGraph.Data.ViewModel;

namespace CSVGraph.Data
{
    public static class Operation
    {
        public static string GetConnectionString()
        {
            string format;
            Connection conn = new Connection();
            format = string.Format("Data Source = {0};AttachDbFilename = {1};Integrated Security=True;",conn.DataSource,conn.DBPath);
            return format;
        }

        public static List<Logs> GetAllLogs()
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var result = (from r in dc.Logs
                          select r).ToList();
            return result;
        }

        public static List<Logs> GetLogsIfValidByVar(string Variable)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var result = (from r in dc.Logs
                          where r.Validity == true && r.VarName == Variable
                          select r).Take(43).ToList();
            return result;
        }

        public static List<Logs> GetLogsIfValidByVarDate(string Variable, DateTime _from, DateTime _to)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var result = (from r in dc.Logs
                          where r.Validity == true && r.VarName.Contains(Variable) &&
                          r.TimeString >= _from &&
                          r.TimeString <= _to
                          select r).ToList();
            return result;
        }

        public static List<Logs> GetLogsByDate(DateTime _from, DateTime _to)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var result = (from r in dc.Logs
                          where r.TimeString >= _from && 
                          r.TimeString <= _to
                          select r).ToList();
            return result;
        }

        public static int GetTotalLogs()
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var result = (from r in dc.Logs
                          select r);
            return result.Count();
        }

        public static List<EventLogs> GetAllEvent()
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var result = (from r in dc.EventLogs
                         select r).ToList();
            return result;
        }

        public static List<EventLogs> GetEventsByDate(DateTime _from, DateTime _to)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var result = (from r in dc.EventLogs
                          where r.MessageDate >= _from && r.MessageDate <= _to  
                          select r).ToList();
            return result;
        }

        public static int GetTotalEvent()
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var result = (from r in dc.EventLogs
                          select r);
            return result.Count();
        }
    }
}
