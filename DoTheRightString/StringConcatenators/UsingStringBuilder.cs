using DoTheRightString.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoTheRightString.StringConcatenators
{
    /// <summary>
    /// Concatenator that uses string builder to get strings assembled.
    /// </summary>
    public class UsingStringBuilder:  IStringConcatenator
    {
        private StringBuilder _sb;

        /// <summary>
        /// Value after all concatenations
        /// </summary>
        public string FinalValue
        {
            get { return _sb.ToString(); }
        }

        /// <summary>
        /// Returns test name that can be used for output.
        /// </summary>
        /// <returns></returns>
        public string GetTestName()
        {
            return "String builder Concatenation test";
        }

        /// <summary>
        /// Adds addition to final string.
        /// </summary>
        /// <param name="addition"></param>
        public void DoConcatenation(string addition)
        {
            _sb.Append(addition);
        }

        /// <summary>
        /// Resets the final value to empty string to avoid memory leak.
        /// </summary>
        public void Reset()
        {
            _sb.Clear();
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public UsingStringBuilder()
        {
            _sb = new StringBuilder();
        }
    }
}
