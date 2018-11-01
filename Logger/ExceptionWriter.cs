using CSVGraph.Directories;
using System;
using System.Collections.Generic;
using System.IO;

namespace CSVGraph.Logger
{
    public class ExceptionWriter : IExceptionWriter
    {
        private string path { get; set; }
        private string docname { get; set; }
        public void Write(ErrorTypes errorTypes, IEnumerable<string> content)
        {
            switch (errorTypes)
            {
                case ErrorTypes.Exceptions:
                    path = DocumentDir.ReturnProgramPath(ProgramDirectories.Logs);
                    docname = DocumentNames.Exceptions;
                    try
                    {
                        if (Directory.Exists(path))
                        {
                            File.AppendAllLines(path + docname, content);
                        }
                        else
                        {
                            Directory.CreateDirectory(path);
                            File.AppendAllLines(path + docname, content);
                        }
                    }
                    catch (Exception e)
                    {
                        string[] exArray = { "BEGIN "+ e.HResult +" MESSAGE",
                        DateTime.Now.ToString("r") + " - Messaggio: " + e.Message,
                        "END "+ e.HResult +" EXCEPTION" };
                        IEnumerable<string> contents = exArray;
                        File.AppendAllLines(@"C:\ServerManager\Account\" + "Eccezioni-FileInUso.txt", contents);
                    }
                    break;

                case ErrorTypes.Warnings:
                    path = DocumentDir.ReturnProgramPath(ProgramDirectories.Logs);
                    docname = DocumentNames.Warnings;
                    if (Directory.Exists(path))
                    {
                        File.AppendAllLines(path + docname, content);
                    }
                    else
                    {
                        Directory.CreateDirectory(path);
                        File.AppendAllLines(path + docname, content);
                    }
                    break;

                case ErrorTypes.Errors:
                    path = DocumentDir.ReturnProgramPath(ProgramDirectories.Logs);
                    docname = DocumentNames.Errors;
                    if (Directory.Exists(path))
                    {
                        File.AppendAllLines(path + docname, content);
                    }
                    else
                    {
                        Directory.CreateDirectory(path);
                        File.AppendAllLines(path + docname, content);
                    }
                    break;
            }
        }
    }
}