using CSVGraph.Directories;
using System.Collections.Generic;

namespace CSVGraph.Logger
{
    internal interface IExceptionWriter
    {
        void Write(ErrorTypes errorTypes, IEnumerable<string> content);
    }
}