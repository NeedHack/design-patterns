//using Helios.CoreLibrary;

using EXPN.AwesomeService.LoggingAdapter;

namespace EXPN.AwesomeService
{
    public class LegacyAwesomeController
    {
        private readonly IEchoLogger _echoLogger;

        public LegacyAwesomeController(IEchoLogger echoLogger)
        {
            _echoLogger = echoLogger;
        }
        
        public void GetAwesomeStuff()
        {
            _echoLogger.Information("GetAwesomeStuffEvent").With("About to do something really awesome").Log();
            
            // do some awesome stuff
            
            _echoLogger.Information("GetAwesomeStuffEvent").With("Just did something awesome").Log();
        }
    }
}