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
    public abstract class Log<T> : Core.Classes.SerializableObject, IEnumerable<T> where T : ILogRecord
    {
        [JsonInclude, JsonPropertyName("LogRecords")]
        protected List<T> logRecords;

        public Log() 
        { 
        }

        public Log(IEnumerable<T> logRecords)
        {
            logRecords = Core.Query.Clone(logRecords);
        }

        public Log(Log<T> log)
        {
            if(log != null)
            {
                logRecords = Core.Query.Clone(log.logRecords);
            }
        }

        public Log(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public override string ToString()
        {
            if(logRecords == null)
            {
                return null;
            }

            return string.Join(Environment.NewLine, logRecords.ConvertAll(x => x.ToString()));
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return logRecords?.GetEnumerator();
        }

        public bool Write(string path)
        {
            if(string.IsNullOrEmpty(path) || !System.IO.Directory.Exists(System.IO.Path.GetDirectoryName(path)))
            {
                return false;
            }

            if(logRecords == null || logRecords.Count == 0)
            {
                return true;
            }

            try
            {
                System.IO.File.AppendAllText(path, ToString() + Environment.NewLine);
            }
            catch (Exception exception)
            {
                return false;
            }

            return true;
        }
    }

    public class Log : Log<LogRecord>
    {
        public Log()
        {

        }

        public Log(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        public Log(IEnumerable<LogRecord> logRecords)
            :base(logRecords)
        {

        }

        public Log(Log log)
            :base(log)
        {

        }

        public override ISerializableObject Clone()
        {
            return new Log(this);
        }

        public LogRecord Add(LogRecord logRecord)
        {
            if (logRecord == null)
            {
                return null;
            }

            LogRecord result = Core.Query.Clone(logRecord);
            if (result != null)
            {
                logRecords.Add(result);
            }

            return logRecord;
        }

        public List<LogRecord> AddRange(IEnumerable<LogRecord> logRecords)
        {
            if (logRecords == null)
            {
                return null;
            }

            List<LogRecord> result = new List<LogRecord>();
            foreach (LogRecord logRecord in logRecords)
            {
                LogRecord logRecord_New = Add(logRecord);
                if(logRecord_New == null)
                {
                    continue;
                }

                result.Add(logRecord_New);
            }

            return result;
        }

        public LogRecord Add(LogRecordType logRecordType, string format, params object[] values)
        {
            return Add(Create.LogRecord(logRecordType, format, values));
        }
    }
}
