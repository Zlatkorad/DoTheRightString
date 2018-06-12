using DoTheRightString.Util;
using System.Collections.Generic;

namespace DoTheRightString
{
    interface IStringConcatenator
    {
        /// <summary>
        /// Test string concatenation using provided list, over number of iterations.
        /// </summary>
        /// <returns>Test Result</returns>
        TestResult TestConcatenation(List<string> stringList, int iterations);
    }
}
