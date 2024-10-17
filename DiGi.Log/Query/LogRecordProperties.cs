using DiGi.Log.Classes;
using System;

namespace DiGi.Log
{
    public static partial class Query
    {
        public static LogRecordProperties LogRecordProperties(this Enum @enum)
        {
            if(@enum == null)
            {
                return null;
            }

            return Core.Query.CustomAttribute<LogRecordProperties>(@enum);
        }
    }
}