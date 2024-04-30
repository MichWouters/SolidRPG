namespace RPG13.Logging
{
    public interface ILogger
    {
        void Log(string message);
        void LogEmptyLine();
        void LogError(string message);
    }
}