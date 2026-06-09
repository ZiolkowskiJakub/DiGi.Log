using System.ComponentModel;

namespace DiGi.Log.Enums
{
    /// <summary>
    /// Specifies the type of a log record.
    /// </summary>
    [Description("Log Record Type")]
    public enum LogRecordType
    {
        /// <summary>
        /// The log record type is undefined.
        /// </summary>
        [Description("Undefined")] Undefined,

        /// <summary>
        /// A general informational message.
        /// </summary>
        [Description("Message")] Message,

        /// <summary>
        /// A warning indicating a potential issue that does not stop the application.
        /// </summary>
        [Description("Warning")] Warning,

        /// <summary>
        /// An error indicating a failure in the application.
        /// </summary>
        [Description("Error")] Error
    }
}