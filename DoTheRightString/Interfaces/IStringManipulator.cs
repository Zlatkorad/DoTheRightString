using System;
using System.Collections.Generic;
using System.Text;

namespace DoTheRightString
{
    interface IStringManipulator
    {
        /// <summary>
        /// Test string manipulation using short list as source.
        /// </summary>
        /// <returns>Test Result</returns>
        TestResult ShortTest();

        /// <summary>
        /// Test string manipulation medium short list as source.
        /// </summary>
        /// <returns>Test Result</returns>
        TestResult MediumTest();

        /// <summary>
        /// Test string manipulation using long list as source.
        /// </summary>
        /// <returns>Test Result</returns>
        TestResult LongTest();

        /// <summary>
        /// Sets number of iterations for all the tests. Default should be 10,000.
        /// </summary>
        /// <param name="amount"></param>
        void SetTestIterations(uint amount);
    }
}
