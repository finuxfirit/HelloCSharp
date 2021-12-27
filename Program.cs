using System;

namespace HelloWorld
{
    class Program
    {
        // A new method
        static void myMethod()
        {
            Console.WriteLine("\nI am a new method");
        }

        static void Main(string[] args)
        {
            // Let's print out a nice text
            Console.WriteLine("Hello World");

            /*
            I am a block comment and can be used 
            when you want to add multiple lines 
            to a comment without having to use
            / on every line.
            */

            // Let's create some variables
            string myMessage = "";

            if (args.Length < 1)
            {
                myMessage = "Welcome to .NET Core!";
            }
            else 
            {
                foreach (string item in args)
                {
                    myMessage += item;
                }
            }

             // Output the myMessage
            Console.WriteLine(myMessage);

            // Write something to prompt for input
            Console.WriteLine("What is your name?");

            // Get input
            var name = Console.ReadLine();

            // The current date
            var currentDate = DateTime.Now;

            // Do some magic
            Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");

            // Call our created method
            myMethod();

            // It's the end of our program
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}
