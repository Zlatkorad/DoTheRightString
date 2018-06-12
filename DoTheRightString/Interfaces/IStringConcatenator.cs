using DoTheRightString.Util;
using System.Collections.Generic;

namespace DoTheRightString
{
    /// <summary>
    /// Defines what methods does String Concatenator has to have.
    /// </summary>
    interface IStringConcatenator
    {
        /// <summary>
        /// Test string concatenation using provided list, over number of iterations.
        /// </summary>
        /// <returns>Test Result</returns>
        TestResult TestConcatenation(List<string> stringList, int iterations);

        /// <summary>
        /// Returns test name that can be used for output.
        /// </summary>
        /// <returns></returns>
        string GetTestName();
    }
}
