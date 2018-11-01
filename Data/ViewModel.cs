using CSVGraph.Directories;
using System;

namespace CSVGraph.Data
{
    public class ViewModel
    {
        public class Connection
        {
            public Connection()
            {
                DataSource = RegistryManager.ManageData.GetKeyValue(RegistryDir.ConnectionSubDir, "DataSource");
                DBPath = RegistryManager.ManageData.GetKeyValue(RegistryDir.ConnectionSubDir, "DBPath");
            }
            public string DataSource { get; set; }
            public string DBPath { get; set; }
        }
        public class MessageEvent
        {
            public MessageEvent()
            {
                MessageTimestamp = DateTime.Now.ToString("dd/MM/yy hh:mm:ss");
                //MessageText = RegistryManager.ManageData.GetKeyValue()
            }
            public string MessageText { get; set; }
            public string MessageTimestamp { get; set; }
        }
        public static class GridLogs
        {
            public static string VariableName { get; set; } = string.Empty;
            public static DateTime TimeLogs { get; set; }
        }
    }
}
