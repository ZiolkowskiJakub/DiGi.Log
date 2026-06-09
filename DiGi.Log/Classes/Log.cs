using DiGi.Core;
using DiGi.Core.Interfaces;
using DiGi.Log.Enums;
using DiGi.Log.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Log.Classes
{
    /// <summary>
    /// Represents a base collection of log records.
    /// </summary>
    /// <typeparam name="T">The type of log record, which must implement <see cref="ILogRecord"/>.</typeparam>
    public abstract class Log<T> : Core.Classes.SerializableObject, IEnumerable<T> where T : ILogRecord
    {
        /// <summary>
        /// The internal list of log records.
        /// </summary>
        [JsonInclude, JsonPropertyName("LogRecords")]
        protected List<T> logRecords = [];

        /// <summary>
        /// Initializes a new instance of the <see cref="Log{T}"/> class.
        /// </summary>
        public Log()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Log{T}"/> class with a specified collection of log records.
        /// </summary>
        /// <param name="logRecords">The initial collection of log records to populate the log.</param>
        public Log(IEnumerable<T>? logRecords)
        {
            this.logRecords = Core.Query.Clone(logRecords)?.FilterNulls() ?? [];
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Log{T}"/> class by cloning an existing log object.
        /// </summary>
        /// <param name="log">The source log object to clone.</param>
        public Log(Log<T>? log)
        {
            if (log != null)
            {
                logRecords = Core.Query.Clone(log.logRecords)?.FilterNulls() ?? [];
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Log{T}"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing log data.</param>
        public Log(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Returns a string representation of all log records, separated by environment new lines.
        /// </summary>
        /// <returns>A concatenated string of all log records, or null if the record list is null.</returns>
        public override string? ToString()
        {
            if (logRecords == null)
            {
                return null;
            }

            return string.Join(Environment.NewLine, logRecords.ConvertAll(x => x.ToString()));
        }

        /// <summary>
        /// Returns an enumerator that iterates through the collection of log records.
        /// </summary>
        /// <returns>An enumerator for the collection.</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Returns an enumerator that iterates through the collection of log records.
        /// </summary>
        /// <returns>A typed enumerator for <typeparamref name="T"/>.</returns>
        public IEnumerator<T> GetEnumerator()
        {
            return logRecords.GetEnumerator();
        }

        /// <summary>
        /// Writes the contents of the log to a specified file path.
        /// </summary>
        /// <param name="path">The destination file path.</param>
        /// <returns>True if the write operation was successful; otherwise, false.</returns>
        public bool Write(string? path)
        {
            if (string.IsNullOrEmpty(path) || !System.IO.Directory.Exists(System.IO.Path.GetDirectoryName(path)))
            {
                return false;
            }

            if (logRecords == null || logRecords.Count == 0)
            {
                return true;
            }

            try
            {
                System.IO.File.AppendAllText(path, ToString() + Environment.NewLine);
            }
            catch
            {
                return false;
            }

            return true;
        }
    }

    /// <summary>
    /// Represents a standard log collection using <see cref="LogRecord"/> entries.
    /// </summary>
    public class Log : Log<LogRecord>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Log"/> class.
        /// </summary>
        public Log()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Log"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing log data.</param>
        public Log(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Log"/> class with a specified collection of log records.
        /// </summary>
        /// <param name="logRecords">The initial collection of log records to populate the log.</param>
        public Log(IEnumerable<LogRecord>? logRecords)
            : base(logRecords)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Log"/> class by cloning an existing log object.
        /// </summary>
        /// <param name="log">The source log object to clone.</param>
        public Log(Log? log)
            : base(log)
        {
        }

        /// <summary>
        /// Creates a shallow copy of the current log instance.
        /// </summary>
        /// <returns>A cloned <see cref="ISerializableObject"/> representing the log.</returns>
        public override ISerializableObject Clone()
        {
            return new Log(this);
        }

        /// <summary>
        /// Adds a new log record to the collection after cloning it.
        /// </summary>
        /// <param name="logRecord">The log record to add.</param>
        /// <returns>The added log record, or null if the input was null.</returns>
        public LogRecord? Add(LogRecord? logRecord)
        {
            if (logRecord == null)
            {
                return null;
            }

            LogRecord? result = Core.Query.Clone(logRecord);
            if (result != null)
            {
                logRecords.Add(result);
            }

            return logRecord;
        }

        /// <summary>
        /// Adds a range of log records to the collection.
        /// </summary>
        /// <param name="logRecords">The collection of log records to add.</param>
        /// <returns>A list of successfully added log records, or null if the input was null.</returns>
        public List<LogRecord>? AddRange(IEnumerable<LogRecord>? logRecords)
        {
            if (logRecords == null)
            {
                return null;
            }

            List<LogRecord> result = [];
            foreach (LogRecord logRecord in logRecords)
            {
                LogRecord? logRecord_New = Add(logRecord);
                if (logRecord_New == null)
                {
                    continue;
                }

                result.Add(logRecord_New);
            }

            return result;
        }

        /// <summary>
        /// Creates and adds a new log record based on the specified type and format.
        /// </summary>
        /// <param name="logRecordType">The type of the log record.</param>
        /// <param name="format">The format string for the log message.</param>
        /// <param name="values">The values to be formatted into the message.</param>
        /// <returns>The created and added log record.</returns>
        public LogRecord? Add(LogRecordType logRecordType, string format, params object[] values)
        {
            return Add(Create.LogRecord(logRecordType, format, values));
        }
    }
}