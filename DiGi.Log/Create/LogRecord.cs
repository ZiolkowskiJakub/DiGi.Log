using DiGi.Log.Classes;
using DiGi.Log.Enums;
using System;

namespace DiGi.Log
{
    public static partial class Create
    {
        public static LogRecord LogRecord(string path, string id, LogRecordType logRecordType, string format, params object[] values)
        {
            if (string.IsNullOrWhiteSpace(path) || !System.IO.Directory.Exists(System.IO.Path.GetDirectoryName(path)))
            {
                return null;
            }

            LogRecord logRecord = LogRecord(id, logRecordType, format, values);
            if (logRecord == null)
            {
                return null;
            }

            string line = logRecord.ToString();
            if(line == null)
            {
                return null;
            }

            System.IO.File.AppendAllLines(path, new string[] { logRecord.ToString() });
            return logRecord;
        }
        
        public static LogRecord LogRecord(string path, Enum @enum, params object[] values)
        {
            LogRecordProperties logRecordProperties = Query.LogRecordProperties(@enum);
            if (logRecordProperties == null)
            {
                return null;
            }

            return LogRecord(path, logRecordProperties.Id, logRecordProperties.LogRecordType, logRecordProperties.Text, values);
        }

        public static LogRecord LogRecord(string id, LogRecordType logRecordType, string format, params object[] values)
        {
            if(format == null)
            {
                return null;
            }

            string text = null;
            try
            {
                text = string.Format(format, values);
            }
            catch(Exception exception)
            {
                return null;
            }
            
            return new LogRecord(id, logRecordType, text);
        }

        public static LogRecord LogRecord(Enum @enum, params object[] values)
        {
            LogRecordProperties logRecordProperties = Query.LogRecordProperties(@enum);
            if (logRecordProperties == null)
            {
                return null;
            }

            return LogRecord(logRecordProperties.Id, logRecordProperties.LogRecordType, logRecordProperties.Text, values);
        }
    }
}