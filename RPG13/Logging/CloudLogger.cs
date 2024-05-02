namespace RPG13.Logging
{
    internal class CloudLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Logging to cloud:  {message}.");
        }

        public void LogEmptyLine()
        {
            Console.WriteLine();
        }

        public void LogError(string message)
        {
            Console.WriteLine($"Logging to cloud: ERROR  {message}.");
        }
    }
}