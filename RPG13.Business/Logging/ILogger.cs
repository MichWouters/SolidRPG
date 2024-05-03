namespace RPG13.Business.Logging
{
    public interface ILogger
    {
        string Log(string message);

        void LogEmptyLine();

        void LogError(string message);
    }
}