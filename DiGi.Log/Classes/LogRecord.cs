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

        public LogRecord(LogRecord logRecord)
        {
            if(logRecord != null)
            {
                dateTime = logRecord.dateTime;
                text = logRecord.text;
                logRecordType = logRecord.LogRecordType;
            }
        }

        public LogRecord(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        public LogRecord(DateTime dateTime, LogRecordType logRecordType, string text)
        {
            this.dateTime = dateTime;
            this.text = text;
            this.logRecordType = logRecordType;
        }

        public LogRecord(LogRecordType logRecordType, string text)
            : this(DateTime.UtcNow, logRecordType, text)
        {
            this.text = text;
            this.logRecordType = logRecordType;
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
        public LogRecordType LogRecordType
        {
            get
            {
                return logRecordType;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2}", dateTime.ToString("yyyy/MM/dd HH:mm:ss.ff"), Core.Query.Description(logRecordType), text == null ? string.Empty : text);
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
