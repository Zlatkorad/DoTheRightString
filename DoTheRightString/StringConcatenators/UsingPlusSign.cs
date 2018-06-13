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
        /// Value after all concatenations
        /// </summary>
        public string FinalValue { get; private set; }

        /// <summary>
        /// Returns test name that can be used for output.
        /// </summary>
        /// <returns></returns>
        public string GetTestName()
        {
            return "Plus Sign Concatenation test";
        }

        /// <summary>
        /// Adds addition to final string.
        /// </summary>
        /// <param name="addition"></param>
        public void DoConcatenation(string addition)
        {
            FinalValue += addition;
        }

        /// <summary>
        /// Resets the final value to empty string to avoid memory leak.
        /// </summary>
        public void Reset()
        {
            FinalValue = string.Empty;
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public UsingPlusSign()
        {
            Reset();
        }
    }
}
