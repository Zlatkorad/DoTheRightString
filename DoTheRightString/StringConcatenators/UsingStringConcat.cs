using DoTheRightString.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoTheRightString.StringConcatenators
{
    public class UsingStringConcat : IStringConcatenator
    {
        /// <summary>
        /// Returns test name that can be used for output.
        /// </summary>
        /// <returns></returns>
        public string GetTestName()
        {
            return "String.Concat Concatenation test";
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
                var endresult = string.Concat(stringList);
            });

            var end = TimeMachine.GetCurrentTime();

            return new TestResult(start, end);
        }
    }
}
