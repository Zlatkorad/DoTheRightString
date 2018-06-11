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

        static void CloseOnKeyPress()
        {
            Console.WriteLine("Press any key to close screen");
            Console.ReadKey();
            System.Environment.Exit(1);
        }
    }
}
