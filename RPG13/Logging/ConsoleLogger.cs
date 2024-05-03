using RPG13.Business.Logging;

namespace RPG13.Logging
{
    public class ConsoleLogger : ILogger
    {
        public string Log(string message)
        {
            Console.WriteLine(message);
            return message;
        }

        public void LogEmptyLine()
        {
            Console.WriteLine();
        }

        public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}