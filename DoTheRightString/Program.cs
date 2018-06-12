using DoTheRightString.StringManipulators;
using DoTheRightString.Util;
using System;

namespace DoTheRightString
{
    class Program
    {


        static void Main(string[] args)
        {
            int iterations = 1000000;


            Console.WriteLine("Starting tests!");
            



            var plusSignTests = new UsingPlusSign();
            var shortTestRes = plusSignTests.TestConcatenation(TestStrings.GetShortList(), iterations);
            var mediumTestRes = plusSignTests.TestConcatenation(TestStrings.GetMediumList(), iterations);
            var longTestRes = plusSignTests.TestConcatenation(TestStrings.GetLongList(), iterations);

            var stringJoinTests = new UsingStringJoin();
            var shortTestRes1 = stringJoinTests.TestConcatenation(TestStrings.GetShortList(), iterations);
            var mediumTestRes1 = stringJoinTests.TestConcatenation(TestStrings.GetMediumList(), iterations);
            var longTestRes1 = stringJoinTests.TestConcatenation(TestStrings.GetLongList(), iterations);

            var stringbuilderTests = new UsingStringJoin();
            var shortTestRes2 = stringbuilderTests.TestConcatenation(TestStrings.GetShortList(), iterations);
            var mediumTestRes2 = stringbuilderTests.TestConcatenation(TestStrings.GetMediumList(), iterations);
            var longTestRes2 = stringbuilderTests.TestConcatenation(TestStrings.GetLongList(), iterations);

            Console.WriteLine();
            Console.WriteLine(string.Format("ShortTest time {0} - {1} - {2}", shortTestRes.TestTimeInMiliseconds, shortTestRes1.TestTimeInMiliseconds, shortTestRes2.TestTimeInMiliseconds));
            Console.WriteLine(string.Format("MediumTest time: {0} - {1} - {2}", mediumTestRes.TestTimeInMiliseconds, mediumTestRes1.TestTimeInMiliseconds, mediumTestRes2.TestTimeInMiliseconds));
            Console.WriteLine(string.Format("LongTest time: {0} - {1} - {2}", longTestRes.TestTimeInMiliseconds, longTestRes1.TestTimeInMiliseconds, longTestRes2.TestTimeInMiliseconds));
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
    }
}
