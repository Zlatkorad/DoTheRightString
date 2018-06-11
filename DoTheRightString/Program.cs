using System;

namespace DoTheRightString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

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
