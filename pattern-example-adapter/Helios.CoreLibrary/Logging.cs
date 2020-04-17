namespace Helios.CoreLibrary
{
    public interface IEchoLogEvent
    {
        IEchoLogEvent With(string message);
        void Log();
    }

    public interface IEchoLogger
    {
        IEchoLogEvent Debug(string eventType);
        IEchoLogEvent Information(string eventType);
        IEchoLogEvent Warning(string eventType);
        IEchoLogEvent Error(string eventType);
    }
}