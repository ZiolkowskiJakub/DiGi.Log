using DiGi.Log.Enums;
using System;

namespace DiGi.Log.Classes
{
    /// <summary>
    /// Attribute used to define properties for a log record field.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class LogRecordProperties : Attribute
    {
        private readonly string? id;
        private readonly string? text;
        private readonly LogRecordType logRecordType;

        /// <summary>
        /// Initializes a new instance of the <see cref="LogRecordProperties"/> class.
        /// </summary>
        /// <param name="logRecordType">The type of the log record.</param>
        /// <param name="text">The descriptive text associated with the log record.</param>
        public LogRecordProperties(LogRecordType logRecordType, string? text)
            : this(null, logRecordType, text)
        {
            ;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogRecordProperties"/> class.
        /// </summary>
        /// <param name="id">The unique identifier for the log record property.</param>
        /// <param name="logRecordType">The type of the log record.</param>
        /// <param name="text">The descriptive text associated with the log record.</param>
        public LogRecordProperties(string? id, LogRecordType logRecordType, string? text)
        {
            this.id = id;
            this.logRecordType = logRecordType;
            this.text = text;
        }

        /// <summary>
        /// Gets the unique identifier for the log record property.
        /// </summary>
        public string? Id
        {
            get
            {
                return id;
            }
        }

        /// <summary>
        /// Gets the descriptive text associated with the log record.
        /// </summary>
        public string? Text
        {
            get
            {
                return text;
            }
        }

        /// <summary>
        /// Gets the type of the log record.
        /// </summary>
        public LogRecordType LogRecordType
        {
            get
            {
                return logRecordType;
            }
        }
    }
}