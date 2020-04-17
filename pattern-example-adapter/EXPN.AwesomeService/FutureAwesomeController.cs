using Microsoft.Extensions.Logging;

namespace EXPN.AwesomeService
{
    public class FutureAwesomeController
    {
        private readonly ILogger _logger;

        public FutureAwesomeController(ILogger logger)
        {
            _logger = logger;
        }
        
        public void GetAwesomeStuff()
        {
            _logger.Log(LogLevel.Information, "GetAwesomeStuffEvent", "About to do something really awesome");
            
            // do some awesome stuff
            
            _logger.Log(LogLevel.Information, "GetAwesomeStuffEvent", "Just did something awesome");
        }
    }
}