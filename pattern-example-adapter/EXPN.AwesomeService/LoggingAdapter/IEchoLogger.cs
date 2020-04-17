namespace EXPN.AwesomeService.LoggingAdapter
{
    public interface IEchoLogger
    {
        IEchoLogEvent Debug(string eventType);
        IEchoLogEvent Information(string eventType);
        IEchoLogEvent Warning(string eventType);
        IEchoLogEvent Error(string eventType);
    }
}