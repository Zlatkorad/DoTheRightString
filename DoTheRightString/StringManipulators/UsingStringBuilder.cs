using DoTheRightString.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoTheRightString.StringManipulators
{
    public class UsingStringBuilder:  IStringConcatenator
    {
        public TestResult TestConcatenation(List<string> stringList, int iterations)
        {
            var start = TimeMachine.GetCurrentTime();
            Enumerable.Range(1, iterations).ToList().ForEach((e) =>
            {
                StringBuilder sb = new StringBuilder();
                
                stringList.ForEach(str => sb.Append(str));

                var endResult = sb.ToString();
            });

            var end = TimeMachine.GetCurrentTime();

            return new TestResult(start, end);
        }
    }
}
