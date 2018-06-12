using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoTheRightString.Util
{
    /// <summary>
    /// This class provides lists of string to be used in concatenation testing.
    /// </summary>
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

        /// <summary>
        /// Returns a list of strings that has 1500 elements (guids)
        /// </summary>
        /// <returns></returns>
        public static List<string> GetTooLongList()
        {
            return GetArbitraryLengthList(1500);
        }

        /// <summary>
        /// Generates 'listLength' amount of guids and packs them in nice little list.
        /// </summary>
        /// <param name="listLength"></param>
        /// <returns></returns>
        public static List<string> GetArbitraryLengthList(int listLength)
        {
            var arbitraryList = new List<string>();
            Enumerable.Range(1, listLength).ToList().ForEach((e) =>
            {
                arbitraryList.Add(Guid.NewGuid().ToString());
            });

            return arbitraryList;
        }
    }
}
