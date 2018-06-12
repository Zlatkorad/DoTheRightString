using System;

namespace DoTheRightString.Util
{
    /// <summary>
    /// This class provides time in miliseconds since epoch start.
    /// Time from this class is used in determining how long does method runs.
    /// </summary>
    internal class TimeMachine
    {
        private static readonly DateTime EpochStart;

        /// <summary>
        /// Returns time in miliseconds since start of Epoch. UTC only.
        /// </summary>
        /// <returns></returns>
        public static ulong GetCurrentTime()
        {
            return Convert.ToUInt64(DateTime.UtcNow.ToUniversalTime().Subtract(EpochStart).TotalMilliseconds);
        }

        /// <summary>
        /// Static constructor, used to initalize EpochStart parameter.
        /// </summary>
        static TimeMachine()
        {
            EpochStart = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        }
    }
}
