namespace Tracer_Lib.Serialization
{
    public interface ISerializer
    {
        string Serialize(TraceResult traceResult);
    }
}