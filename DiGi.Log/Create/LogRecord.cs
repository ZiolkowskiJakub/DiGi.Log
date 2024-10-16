using DiGi.Log.Classes;
using DiGi.Log.Enums;
using System;

namespace DiGi.Log
{
    public static partial class Create
    {
        public static LogRecord LogRecord(LogRecordType logRecordType, string format, params object[] values)
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
            
            return new LogRecord(logRecordType, text);
        }
    }
}