namespace EXPN.AwesomeService.LoggingAdapter
{
    public interface IEchoLogEvent
    {
        IEchoLogEvent With(string message);
        void Log();
    }
}