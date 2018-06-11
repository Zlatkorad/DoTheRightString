using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoTheRightString.StringManipulators
{
    public class UsingPlusSign : IStringManipulator
    {
        private string[] _short;
        private string[] _medium;
        private string[] _long;
        private int _iterations;


        public TestResult ShortTest()
        {
            var start = TimeMachine.GetCurrentTime();
            Enumerable.Range(1, _iterations).ToList().ForEach((e) =>
            {
                var endResult = string.Empty;
                endResult += _short[0];
                endResult += _short[1];
                endResult += _short[2];
                endResult += _short[3];
            });

            var end = TimeMachine.GetCurrentTime();

            return new TestResult(start, end);
        }

        public TestResult MediumTest()
        {
            var stringList = _medium.ToList();
            var start = TimeMachine.GetCurrentTime();
            Enumerable.Range(1, _iterations).ToList().ForEach((e) =>
            {
                var endResult = string.Empty;
                stringList.ForEach(str => endResult += str);
            });

            var end = TimeMachine.GetCurrentTime();
            return new TestResult(start, end);
        }

        public TestResult LongTest()
        {
            var stringList = _long.ToList();
            var start = TimeMachine.GetCurrentTime();
            Enumerable.Range(1, _iterations).ToList().ForEach((e) =>
            {
                var endResult = string.Empty;
                stringList.ForEach(str => endResult += str);
            });

            var end = TimeMachine.GetCurrentTime();
            return new TestResult(start, end);
        }

        public void SetTestIterations(int amount)
        {
            _iterations = amount;
        }

        

        public UsingPlusSign(int iterations, string[] shortArray, string[] mediumArray, string[] longArray)
        {
            _iterations = iterations;
            _short = shortArray;
            _medium = mediumArray;
            _long = longArray;
        }
    }
}
