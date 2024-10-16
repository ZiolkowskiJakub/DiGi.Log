using System.ComponentModel;

namespace DiGi.Log.Enums
{
    [Description("Log Record Type")]
    public enum LogRecordType
    {
        [Description("Undefined")] Undefined,
        [Description("Message")] Message,
        [Description("Warning")] Warning,
        [Description("Error")] Error
    }
}
