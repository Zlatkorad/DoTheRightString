﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DoTheRightString.Util;

namespace DoTheRightString.StringConcatenators
{
    public class UsingStringJoin : IStringConcatenator
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
            return "String.Join Concatenation test";
        }

        /// <summary>
        /// Adds addition to final string.
        /// </summary>
        /// <param name="addition"></param>
        public void DoConcatenation(string addition)
        {
            FinalValue = string.Join(string.Empty, FinalValue, addition);
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
        public UsingStringJoin()
        {
            Reset();
        }
    }
}
