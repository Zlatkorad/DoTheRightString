using DoTheRightString.Util;
using System.Collections.Generic;
using System.Linq;

namespace DoTheRightString.StringConcatenators
{
    /// <summary>
    /// Concatenator is adding string using a + sign.
    /// </summary>
    public class UsingPlusSign : IStringConcatenator
    {
        /// <summary>
        /// Returns test name that can be used for output.
        /// </summary>
        /// <returns></returns>
        public string GetTestName()
        {
            return "Plus Sign Concatenation test";
        }

        /// <summary>
        /// Test string concatenation using provided list, over number of iterations.
        /// </summary>
        /// <returns>Test Result</returns>
        public TestResult TestConcatenation(List<string> stringList, int iterations)
        {
            var start = TimeMachine.GetCurrentTime();
            Enumerable.Range(1, iterations).ToList().ForEach((e) =>
            {
                var endResult = string.Empty;
                stringList.ForEach(str => endResult += str);
            });

            var end = TimeMachine.GetCurrentTime();

            return new TestResult(start, end);
        }
    }
}
