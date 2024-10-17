using DiGi.Log.Classes;
using System.ComponentModel;

namespace DiGi.Log.Enums
{
    [Description("Default Log Record")]
    public enum DefaultLogRecord
    {
        [LogRecordProperties("c030827f-6684-4f06-a9ce-4b9da88063c4", LogRecordType.Message, "Start")] Start,
        [LogRecordProperties("6ddbb222-977a-4bca-8eb0-b14b333a7322", LogRecordType.Message, "Stop")] Stop,
        [LogRecordProperties("65beb442-84b7-45ba-a3f2-3185faa9d78b", LogRecordType.Warning, "Warning")] Warning,
        [LogRecordProperties("af282708-65ac-46b2-bbe5-80a6eb0ac541", LogRecordType.Error, "Error")] Error,
    }
}
