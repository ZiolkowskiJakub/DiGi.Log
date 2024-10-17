using DiGi.Core.Interfaces;
using DiGi.Log.Enums;
using DiGi.Log.Interfaces;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Log.Classes
{
    public class LogRecord : Core.Classes.SerializableObject, ILogRecord
    {
        [JsonInclude, JsonPropertyName("DateTime")]
        private DateTime dateTime;
        
        [JsonInclude, JsonPropertyName("Text")]
        private string text;

        [JsonInclude, JsonPropertyName("LogRecordType")]
        private LogRecordType logRecordType;

        [JsonInclude, JsonPropertyName("Id")]
        private string id = null;

        public LogRecord(LogRecord logRecord)
        {
            if(logRecord != null)
            {
                dateTime = logRecord.dateTime;
                text = logRecord.text;
                logRecordType = logRecord.LogRecordType;
                id = logRecord.id;
            }
        }

        public LogRecord(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        public LogRecord(DateTime dateTime, string id, LogRecordType logRecordType, string text)
        {
            this.dateTime = dateTime;
            this.id = id;
            this.text = text;
            this.logRecordType = logRecordType;
        }

        public LogRecord(DateTime dateTime, LogRecordType logRecordType, string text)
            :this(dateTime, null, logRecordType, text)
        {
        }

        public LogRecord(string id, LogRecordType logRecordType, string text)
            : this(DateTime.UtcNow, id, logRecordType, text)
        {

        }

        public LogRecord(LogRecordType logRecordType, string text)
            : this(DateTime.UtcNow, null, logRecordType, text)
        {

        }

        public override ISerializableObject Clone()
        {
            return new LogRecord(this);
        }

        [JsonIgnore]
        public DateTime DateTime
        {
            get
            {
                return dateTime;
            }
        }

        [JsonIgnore]
        public string Text
        {
            get
            {
                return text;
            }
        }

        [JsonIgnore]
        public string Id
        {
            get
            {
                return id;
            }
        }

        [JsonIgnore]
        public LogRecordType LogRecordType
        {
            get
            {
                return logRecordType;
            }
        }

        public override string ToString()
        {
            if(id == null)
            {
                return string.Format("{0}\t{1}\t{2}", dateTime.ToString("yyyy/MM/dd HH:mm:ss.ff"), Core.Query.Description(logRecordType), text == null ? string.Empty : text);
            }
            else
            {
                return string.Format("{0}\t{1}\t{2}\t{3}", dateTime.ToString("yyyy/MM/dd HH:mm:ss.ff"), id, Core.Query.Description(logRecordType), text == null ? string.Empty : text);
            }
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
