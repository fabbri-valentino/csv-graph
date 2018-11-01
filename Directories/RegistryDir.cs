using CSVGraph.RegistryManager;
namespace CSVGraph.Directories
{
    public static class RegistryDir
    {
        public static string DefaultProgramDir { get; set; } = @"SOFTWARE\CSVGraph\"; // Rendere disponibile la modifica ad alto livello
        public static string ServerSubDir { get; set; } = DefaultProgramDir + @"Server\";
        public static string ClientSubDir { get; set; } = DefaultProgramDir + @"Client\";
        public static string ConnectionSubDir { get; set; } = ServerSubDir + @"ConnectionString\";
        public static string EventSubDir { get; set; } = ClientSubDir + @"Event\";
    }
    public class CreateRegistryDir
    {
        public void Initialize()
        {
            if (ManageData.KeyExist(RegistryDir.DefaultProgramDir) == false)
            {
                ManageData.SetKey(RegistryDir.DefaultProgramDir, false);
                ManageData.SetKey(RegistryDir.ServerSubDir, false);
                ManageData.SetKey(RegistryDir.ClientSubDir, false);
                ManageData.SetKey(RegistryDir.ConnectionSubDir, false);
                ManageData.SetKey(RegistryDir.EventSubDir, false);
            }
        }
    }
}
