using DoTheRightString.Util;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace DoTheRightString
{
    internal class TestEngine
    {
        /// <summary>
        /// Performs test using requested Concatenator.
        /// </summary>
        /// <param name="concatenator"></param>
        /// <param name="listForTest"></param>
        /// <param name="testsToRun"></param>
        /// <param name="amountOfIterations"></param>
        internal static void PerformTest(IStringConcatenator concatenator, List<string> listForTest, ushort testsToRun, int amountOfIterations)
        {
            //List<TestResult> results = new List<TestResult>();

            Console.WriteLine(string.Format("Starting test: {0}, with {1} iterations. Repeating it {2} times.", concatenator.GetTestName(), amountOfIterations, testsToRun));
            Console.Write("Test Results:");
            List<long> results = Enumerable.Range(1, testsToRun).Select(e =>
            {

                long elapsed = DoTest(concatenator, listForTest, amountOfIterations);
                Console.Write(string.Format("   {0} - {1} ms", e, elapsed));
                return elapsed;

            }).ToList();

            Console.WriteLine();
            Console.WriteLine(string.Format("Average Test time for list with {0} strings is: {1} ms.", listForTest.Count, AverageTestDuration(results)));
            Console.WriteLine();
        }

        private static long DoTest(IStringConcatenator concatenator, List<string> listForTest, int amountOfIterations)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            Enumerable.Range(1, amountOfIterations).ToList().ForEach(i =>
            {
                concatenator.Reset();
                listForTest.ForEach(str => concatenator.DoConcatenation(str));
            });
            stopwatch.Stop();

            return stopwatch.ElapsedMilliseconds;
        }

        private static decimal AverageTestDuration(List<long> results)
        {
            return results.Select(e => e).Sum() / results.Count;
        }

    }
}
