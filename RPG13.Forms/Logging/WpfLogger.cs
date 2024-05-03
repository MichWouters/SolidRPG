using RPG13.Business.Logging;

namespace RPG13.WPF.Logging
{
    class WpfLogger : ILogger
    {
        public string Log(string message)
        {
            return message;
        }

        public void LogEmptyLine()
        {
            
        }

        public void LogError(string message)
        {
            
        }
    }
}
