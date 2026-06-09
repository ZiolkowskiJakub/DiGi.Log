using DiGi.Core.Interfaces;
using DiGi.Log.Enums;
using DiGi.Log.Interfaces;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Log.Classes
{
    /// <summary>
    /// Represents a log record entry containing timestamp, identification, type, and message text.
    /// </summary>
    public class LogRecord : Core.Classes.SerializableObject, ILogRecord
    {
        [JsonInclude, JsonPropertyName("DateTime")]
        private readonly DateTime dateTime = DateTime.MinValue;

        [JsonInclude, JsonPropertyName("Text")]
        private readonly string? text = null;

        [JsonInclude, JsonPropertyName("LogRecordType")]
        private readonly LogRecordType logRecordType = LogRecordType.Undefined;

        [JsonInclude, JsonPropertyName("Id")]
        private readonly string? id = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="LogRecord"/> class by copying an existing record.
        /// </summary>
        /// <param name="logRecord">The source log record to copy from.</param>
        public LogRecord(LogRecord? logRecord)
        {
            if (logRecord != null)
            {
                dateTime = logRecord.dateTime;
                text = logRecord.text;
                logRecordType = logRecord.LogRecordType;
                id = logRecord.id;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogRecord"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing record data.</param>
        public LogRecord(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogRecord"/> class with all specified values.
        /// </summary>
        /// <param name="dateTime">The timestamp of the log entry.</param>
        /// <param name="id">The unique identifier for the record.</param>
        /// <param name="logRecordType">The type or severity of the log record.</param>
        /// <param name="text">The descriptive text of the log message.</param>
        public LogRecord(DateTime dateTime, string? id, LogRecordType logRecordType, string? text)
        {
            this.dateTime = dateTime;
            this.id = id;
            this.text = text;
            this.logRecordType = logRecordType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogRecord"/> class without an identifier.
        /// </summary>
        /// <param name="dateTime">The timestamp of the log entry.</param>
        /// <param name="logRecordType">The type or severity of the log record.</param>
        /// <param name="text">The descriptive text of the log message.</param>
        public LogRecord(DateTime dateTime, LogRecordType logRecordType, string? text)
            : this(dateTime, null, logRecordType, text)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogRecord"/> class using the current UTC time.
        /// </summary>
        /// <param name="id">The unique identifier for the record.</param>
        /// <param name="logRecordType">The type or severity of the log record.</param>
        /// <param name="text">The descriptive text of the log message.</param>
        public LogRecord(string? id, LogRecordType logRecordType, string? text)
            : this(DateTime.UtcNow, id, logRecordType, text)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogRecord"/> class using current UTC time and no identifier.
        /// </summary>
        /// <param name="logRecordType">The type or severity of the log record.</param>
        /// <param name="text">The descriptive text of the log message.</param>
        public LogRecord(LogRecordType logRecordType, string? text)
            : this(DateTime.UtcNow, null, logRecordType, text)
        {
        }

        /// <summary>
        /// Creates a clone of the current log record.
        /// </summary>
        /// <returns>A new <see cref="ISerializableObject"/> instance that is a copy of this record.</returns>
        public override ISerializableObject? Clone()
        {
            return new LogRecord(this);
        }

        /// <summary>
        /// Gets the timestamp when the log record was created.
        /// </summary>
        [JsonIgnore]
        public DateTime DateTime
        {
            get
            {
                return dateTime;
            }
        }

        /// <summary>
        /// Gets the message text associated with the log record.
        /// </summary>
        [JsonIgnore]
        public string? Text
        {
            get
            {
                return text;
            }
        }

        /// <summary>
        /// Gets the unique identifier of the log record.
        /// </summary>
        [JsonIgnore]
        public string? Id
        {
            get
            {
                return id;
            }
        }

        /// <summary>
        /// Gets the type or severity level of the log record.
        /// </summary>
        [JsonIgnore]
        public LogRecordType LogRecordType
        {
            get
            {
                return logRecordType;
            }
        }

        /// <summary>
        /// Returns a string representation of the log record, formatted with tabs.
        /// </summary>
        /// <returns>A formatted string containing the date, ID (if available), type description, and text.</returns>
        public override string ToString()
        {
            if (id == null)
            {
                return string.Format("{0}\t{1}\t{2}", dateTime.ToString("yyyy/MM/dd HH:mm:ss.ff"), Core.Query.Description(logRecordType), text ?? string.Empty);
            }
            else
            {
                return string.Format("{0}\t{1}\t{2}\t{3}", dateTime.ToString("yyyy/MM/dd HH:mm:ss.ff"), id, Core.Query.Description(logRecordType), text ?? string.Empty);
            }
        }

        /// <summary>
        /// Returns a hash code for the current log record based on its string representation.
        /// </summary>
        /// <returns>An integer hash code.</returns>
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}