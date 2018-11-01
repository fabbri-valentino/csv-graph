using System.IO;

namespace CSVGraph.Directories
{
    public enum ErrorTypes
    {
        Exceptions,
        Warnings,
        Errors
    }

    public enum ProgramDirectories
    {
        Base,
        Data,
        Logs
    }

    public static class DocumentNames
    {
        internal static string Exceptions { get; set; } = "Eccezioni.txt";
        internal static string Warnings { get; set; } = "Avvisi.txt";
        internal static string Errors { get; set; } = "Errori.txt";
    }

    public static class DocumentDir
    {
        public static string ReturnProgramPath(ProgramDirectories myEnum)
        {
            string BaseDirectory = @"C:\Users\AGF9\AppData\Local\Artec\Products\CSVGraph";
            string DataDirectory = BaseDirectory + @"\Data";
            string LogsDirectory = BaseDirectory + @"\Logs";
            
            switch (myEnum)
            {
                case ProgramDirectories.Base:
                    return BaseDirectory;
                case ProgramDirectories.Data:
                    return DataDirectory;
                case ProgramDirectories.Logs:
                    return LogsDirectory;
                default:
                    return "Operazione non permessa";
            }
        }

    }

    public class CreateLocalDir
    {
        public void Initialize()
        {
            var baseDir = Directory.Exists(DocumentDir.ReturnProgramPath(ProgramDirectories.Base));
            if (baseDir != true)
            {
                Directory.CreateDirectory(DocumentDir.ReturnProgramPath(ProgramDirectories.Base));
                Directory.CreateDirectory(DocumentDir.ReturnProgramPath(ProgramDirectories.Data));
                Directory.CreateDirectory(DocumentDir.ReturnProgramPath(ProgramDirectories.Logs));
            }
        }
    }
}