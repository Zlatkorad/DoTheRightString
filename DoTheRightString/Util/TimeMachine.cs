using System;
using System.Collections.Generic;
using System.Text;

namespace DoTheRightString
{
    internal class TimeMachine
    {
        private static readonly DateTime EpochStart;

        public static ulong GetCurrentTime()
        {
            return Convert.ToUInt64(DateTime.UtcNow.ToUniversalTime().Subtract(EpochStart).TotalMilliseconds);
        }

        static TimeMachine()
        {
            EpochStart = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        }
    }
}
