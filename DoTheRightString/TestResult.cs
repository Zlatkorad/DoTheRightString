using System;
using System.Collections.Generic;
using System.Text;

namespace DoTheRightString
{
    /// <summary>
    /// Provides test result values of String manipulation tests.
    /// </summary>
    internal class TestResult
    {
        private ulong _testStart;
        private ulong _testFinish;

        internal ulong TestTimeInMiliseconds
        {
            get
            {
                return _testFinish - _testStart;
            }
        }

        internal TestResult(ulong start, ulong finish)
        {
            _testStart = start;
            _testFinish = finish;
        }
    }
}
