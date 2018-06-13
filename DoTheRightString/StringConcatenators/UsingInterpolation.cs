using System;
using System.Collections.Generic;
using System.Text;

namespace DoTheRightString.StringConcatenators
{
    /// <summary>
    /// Does concatenation using interpolation
    /// </summary>
    public class UsingInterpolation : IStringConcatenator
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
            return "Interpolation Concatenation test";
        }

        /// <summary>
        /// Adds addition to final string.
        /// </summary>
        /// <param name="addition"></param>
        public void DoConcatenation(string addition)
        {
            FinalValue = $"{FinalValue}{addition}";
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
        public UsingInterpolation()
        {
            Reset();
        }
    }
}
