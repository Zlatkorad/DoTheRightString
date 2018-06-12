using DoTheRightString.Util;
using System.Collections.Generic;
using System.Linq;

namespace DoTheRightString.StringConcatenators
{
    public class UsingPlusSign : IStringConcatenator
    {
        public string GetTestName()
        {
            return "Plus Sign Concatenation test";
        }

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
