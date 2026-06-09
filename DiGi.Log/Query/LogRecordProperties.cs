using DiGi.Log.Classes;
using System;

namespace DiGi.Log
{
    public static partial class Query
    {
        /// <summary>
        /// Retrieves the <see cref="LogRecordProperties"/> attribute associated with the specified enumeration value.
        /// </summary>
        /// <param name="enum">The enumeration value to query for properties.</param>
        /// <returns>The <see cref="LogRecordProperties"/> attribute if found; otherwise, <c>null</c>.</returns>
        public static LogRecordProperties? LogRecordProperties(this Enum? @enum)
        {
            if (@enum == null)
            {
                return null;
            }

            return Core.Query.CustomAttribute<LogRecordProperties>(@enum);
        }
    }
}