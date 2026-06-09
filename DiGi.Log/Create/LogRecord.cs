using DiGi.Log.Classes;
using DiGi.Log.Enums;
using System;

namespace DiGi.Log
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a log record and appends it to the specified file path.
        /// </summary>
        /// <param name="path">The full path to the log file.</param>
        /// <param name="id">The identifier for the log record.</param>
        /// <param name="logRecordType">The type of the log record.</param>
        /// <param name="format">The format string used to create the log message.</param>
        /// <param name="values">The values to be formatted into the log message.</param>
        /// <returns>The created <see cref="Classes.LogRecord"/> if successful; otherwise, null.</returns>
        public static LogRecord? LogRecord(string? path, string? id, LogRecordType logRecordType, string? format, params object[]? values)
        {
            if (string.IsNullOrWhiteSpace(path) || !System.IO.Directory.Exists(System.IO.Path.GetDirectoryName(path)))
            {
                return null;
            }

            LogRecord? logRecord = LogRecord(id, logRecordType, format, values);
            if (logRecord == null)
            {
                return null;
            }

            string line = logRecord.ToString();
            if (line == null)
            {
                return null;
            }

            System.IO.File.AppendAllLines(path, [logRecord.ToString()]);
            return logRecord;
        }

        /// <summary>
        /// Creates a log record based on the provided enumeration and appends it to the specified file path.
        /// </summary>
        /// <param name="path">The full path to the log file.</param>
        /// <param name="enum">The enumeration value used to retrieve log properties.</param>
        /// <param name="values">The values to be formatted into the log message.</param>
        /// <returns>The created <see cref="Classes.LogRecord"/> if successful; otherwise, null.</returns>
        public static LogRecord? LogRecord(string path, Enum @enum, params object[] values)
        {
            LogRecordProperties? logRecordProperties = Query.LogRecordProperties(@enum);
            if (logRecordProperties == null)
            {
                return null;
            }

            return LogRecord(path, logRecordProperties.Id, logRecordProperties.LogRecordType, logRecordProperties.Text, values);
        }

        /// <summary>
        /// Creates a new instance of a log record.
        /// </summary>
        /// <param name="id">The identifier for the log record.</param>
        /// <param name="logRecordType">The type of the log record.</param>
        /// <param name="format">The format string used to create the log message.</param>
        /// <param name="values">The values to be formatted into the log message.</param>
        /// <returns>A new <see cref="Classes.LogRecord"/> instance if successful; otherwise, null.</returns>
        public static LogRecord? LogRecord(string? id, LogRecordType logRecordType, string? format, params object[]? values)
        {
            if (format == null)
            {
                return null;
            }

            string? text;
            try
            {
                text = string.Format(format, values);
            }
            catch
            {
                return null;
            }

            return new LogRecord(id, logRecordType, text);
        }

        /// <summary>
        /// Creates a new instance of a log record based on the provided enumeration.
        /// </summary>
        /// <param name="enum">The enumeration value used to retrieve log properties.</param>
        /// <param name="values">The values to be formatted into the log message.</param>
        /// <returns>A new <see cref="Classes.LogRecord"/> instance if successful; otherwise, null.</returns>
        public static LogRecord? LogRecord(Enum? @enum, params object[] values)
        {
            LogRecordProperties? logRecordProperties = Query.LogRecordProperties(@enum);
            if (logRecordProperties == null)
            {
                return null;
            }

            return LogRecord(logRecordProperties.Id, logRecordProperties.LogRecordType, logRecordProperties.Text, values);
        }
    }
}