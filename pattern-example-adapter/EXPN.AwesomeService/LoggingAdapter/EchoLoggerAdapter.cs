using Microsoft.Extensions.Logging;

namespace EXPN.AwesomeService.LoggingAdapter
{
    //    adapter for the old IEchoLogger --> Microsoft.Extensions.Logging.ILogger
    public class EchoLoggerAdapter : IEchoLogger
    {
        private readonly ILogger _logger;

        public EchoLoggerAdapter(ILogger logger)
        {
            _logger = logger;
        }
        
        public IEchoLogEvent Debug(string eventType)
        {
            return new EchoLogEventAdapter(_logger, LogLevel.Debug, eventType);
        }

        public IEchoLogEvent Information(string eventType)
        {
            return new EchoLogEventAdapter(_logger, LogLevel.Information, eventType);
        }

        public IEchoLogEvent Warning(string eventType)
        {
            return new EchoLogEventAdapter(_logger, LogLevel.Warning, eventType);
        }

        public IEchoLogEvent Error(string eventType)
        {
            return new EchoLogEventAdapter(_logger, LogLevel.Error, eventType);
        }
    }
}