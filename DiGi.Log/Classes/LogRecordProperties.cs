using DiGi.Log.Enums;
using System;

namespace DiGi.Log.Classes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class LogRecordProperties : Attribute
    {
        private string id;
        private string text;
        private LogRecordType logRecordType;

        public LogRecordProperties(LogRecordType logRecordType, string text)
            :this(null, logRecordType, text)
        {
;
        }

        public LogRecordProperties(string id, LogRecordType logRecordType, string text)
        {
            this.id = id;
            this.logRecordType = logRecordType;
            this.text = text;
        }

        public string Id
        {
            get
            {
                return id;
            }
        }

        public string Text
        {
            get
            {
                return text;
            }
        }

        public LogRecordType LogRecordType
        {
            get
            {
                return logRecordType;
            }
        }

    }
}
