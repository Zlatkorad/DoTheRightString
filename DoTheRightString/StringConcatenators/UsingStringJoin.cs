using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DoTheRightString.Util;

namespace DoTheRightString.StringConcatenators
{
    public class UsingStringJoin : IStringConcatenator
    {
        /// <summary>
        /// Returns test name that can be used for output.
        /// </summary>
        /// <returns></returns>
        public string GetTestName()
        {
            return "String.Join Concatenation test";
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
                var endresult = string.Join(string.Empty, stringList);
            });

            var end = TimeMachine.GetCurrentTime();

            return new TestResult(start, end);
        }
    }
}
