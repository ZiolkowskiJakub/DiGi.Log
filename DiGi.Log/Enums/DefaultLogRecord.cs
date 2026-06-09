using DiGi.Log.Classes;
using System.ComponentModel;

namespace DiGi.Log.Enums
{
    /// <summary>
    /// Defines the default set of log records used for system logging.
    /// </summary>
    [Description("Default Log Record")]
    public enum DefaultLogRecord
    {
        /// <summary>
        /// Indicates the start of a process or operation.
        /// </summary>
        [LogRecordProperties("c030827f-6684-4f06-a9ce-4b9da88063c4", LogRecordType.Message, "Start")] Start,

        /// <summary>
        /// Indicates the stop or completion of a process or operation.
        /// </summary>
        [LogRecordProperties("6ddbb222-977a-4bca-8eb0-b14b333a7322", LogRecordType.Message, "Stop")] Stop,

        /// <summary>
        /// Indicates a warning event that does not necessarily interrupt the flow of execution.
        /// </summary>
        [LogRecordProperties("65beb442-84b7-45ba-a3f2-3185faa9d78b", LogRecordType.Warning, "Warning")] Warning,

        /// <summary>
        /// Indicates an error event that may impact the system's functionality.
        /// </summary>
        [LogRecordProperties("af282708-65ac-46b2-bbe5-80a6eb0ac541", LogRecordType.Error, "Error")] Error,
    }
}