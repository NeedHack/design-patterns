using Microsoft.Extensions.Logging;

namespace EXPN.AwesomeService.LoggingAdapter
{
    //    adapter for the old IEchoLoggerEvent --> Microsoft.Extensions.Logging.ILogger
    public class EchoLogEventAdapter : IEchoLogEvent
    {
        private readonly LogLevel _logLevel;
        private readonly string _eventType;
        private readonly ILogger _logger;
        private string _message;

        public EchoLogEventAdapter(ILogger logger, LogLevel logLevel, string eventType)
        {
            _logLevel = logLevel;
            _eventType = eventType;
            _logger = logger;
        }
        
        public IEchoLogEvent With(string message)
        {
            _message = message;
            return this;
        }

        public void Log()
        {
            _logger.Log(_logLevel, _eventType, _message);
        }
    }
}