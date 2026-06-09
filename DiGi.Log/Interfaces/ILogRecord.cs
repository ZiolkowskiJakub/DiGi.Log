using DiGi.Log.Enums;
using System;

namespace DiGi.Log.Interfaces
{
    /// <summary>
    /// Defines the contract for a log record entry.
    /// </summary>
    public interface ILogRecord : Core.Interfaces.ISerializableObject
    {
        /// <summary>
        /// Gets the unique identifier of the log record.
        /// </summary>
        string? Id { get; }

        /// <summary>
        /// Gets the date and time when the log record was created.
        /// </summary>
        DateTime DateTime { get; }

        /// <summary>
        /// Gets the text content of the log record.
        /// </summary>
        string? Text { get; }

        /// <summary>
        /// Gets the type or severity level of the log record.
        /// </summary>
        LogRecordType LogRecordType { get; }
    }
}