using DiGi.Log.Enums;
using System;

namespace DiGi.Log.Interfaces
{
    public interface ILogRecord : Core.Interfaces.ISerializableObject
    {
        string? Id { get; }
        DateTime DateTime { get; }
        string? Text { get; }
        LogRecordType LogRecordType { get; }
    }
}