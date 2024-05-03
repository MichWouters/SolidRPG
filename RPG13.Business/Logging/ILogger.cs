namespace RPG13.Business.Logging
{
    public interface ILogger
    {
        void Log(string message);

        void LogEmptyLine();

        void LogError(string message);
    }
}