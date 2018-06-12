using DoTheRightString.StringConcatenators;
using DoTheRightString.Util;
using System;

namespace DoTheRightString
{
    class Program
    {
        /// <summary>
        /// Main body of the program. You should do all the setting up here.
        /// </summary>
        static void Main()
        {
            int iterations = 10000;
            IStringConcatenator testClass = new UsingPlusSign();

            Console.WriteLine("Starting tests!");
            TestEngine.PerformTest(testClass, TestStrings.GetShortList(), 5, iterations);
           
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
