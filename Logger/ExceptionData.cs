namespace CSVGraph.Logger
{
    public class ExceptionData
    {
        public string Message { get; set; } = string.Empty;
        public string InnerException { get; set; } = string.Empty;
        public string Source { get; set; } = string.Empty;
        public string HResult { get; set; } = string.Empty;
    }
}