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
        /// Value after all concatenations
        /// </summary>
        string FinalValue { get; }

        /// <summary>
        /// Test string concatenation using provided list, over number of iterations.
        /// </summary>
        /// <returns>Test Result</returns>
        void DoConcatenation(string addition);

        /// <summary>
        /// Returns test name that can be used for output.
        /// </summary>
        /// <returns></returns>
        string GetTestName();

        /// <summary>
        /// Resets the final value to empty string to avoid memory leak.
        /// </summary>
        void Reset();
    }
}
