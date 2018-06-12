using System;
using System.Collections.Generic;
using System.Text;

namespace DoTheRightString.Util
{
    public class TestStrings
    {
        /// <summary>
        /// Returns list of strings that has 4 elements.
        /// </summary>
        /// <returns>string list</returns>
        public static List<string> GetShortList()
        {
            return new List<string>() { "This ", "is ", "short ", "sentence." };
        }

        /// <summary>
        /// Returns list of strings that has 7 elements.
        /// </summary>
        /// <returns>string list</returns>
        public static List<string> GetMediumList()
        {
            return new List<string>() { "Medium ", "test. ", "It. ", "can ", "talk ", "to ", "ghosts" };    
        }

        /// <summary>
        /// Returns list of strings that has 11 elements.
        /// </summary>
        /// <returns>string list</returns>
        public static List<string> GetLongList()
        {
            return new List<string>() { "Are ", "you ", "really ", "serious ", "about ", "the ", "length ", "of ", "this ", "test ", "sentence?" };
        }
    }
}
