using DoTheRightString.StringManipulators;
using System;

namespace DoTheRightString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var plusSignTests = new UsingPlusSign(1000000, GetShortArray(), GetMediumArray(), GetLongArray());
            var shortTestRes = plusSignTests.ShortTest();
            var mediumTestRes = plusSignTests.MediumTest();
            var longTestRes = plusSignTests.LongTest();

            Console.WriteLine();
            Console.WriteLine(string.Format("ShortTest time: {0}", shortTestRes.TestTimeInMiliseconds));
            Console.WriteLine(string.Format("MediumTest time: {0}", mediumTestRes.TestTimeInMiliseconds));
            Console.WriteLine(string.Format("LongTest time: {0}", longTestRes.TestTimeInMiliseconds));
            Console.WriteLine();
            CloseOnKeyPress();
        }

        /// <summary>
        /// Just standard console app exit.
        /// Application waits for key press by user so that user can investigate information on screen.
        /// </summary>
        static void CloseOnKeyPress()
        {
            Console.WriteLine("Press any key to close screen");
            Console.ReadKey();
            System.Environment.Exit(1);
        }

        private static string[] GetShortArray()
        {
            return new string[] { "This ", "is ", "short ", "sentence."};
        }

        private static string[] GetMediumArray()
        {
            return new string[] { "Medium ", "test. ", "it. ", "can ", "talk ", "to ", "ghosts" };
        }

        private static string[] GetLongArray()
        {
            return new string[] { "Are ", "you ", "really ", "serious ", "about ", "the ", "length ", "of ", "this ", "test ", "sentence?" };
        }
    }
}
