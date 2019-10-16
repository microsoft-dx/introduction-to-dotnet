using Humans;
using System;

namespace Classes
{
    class Program
    {
        static string SecondHello = "I am second";

        // Main Entry Point
        static void Main(string[] args)
        {
            /*
            Console.Write(CustomHello());
            Console.Write(CustomHello());
            */
            Human John = new Human("John");
            // John.Name = "John";
            // John.isABoy= true;

            // Calling the console witht the method of an object
            Console.WriteLine(John.FullDescription());
            John.Name += " Something";
            Console.WriteLine(John.Name);
            Console.WriteLine(John.TellGender());

            // Creating another Human
            Human Ana = new Human("Ana");

            // Using the Static Member of a Class
            Console.WriteLine(Human.HumanCount);
            Console.WriteLine(Ana.FullDescription());

            _ = new Human("");
            _ = new Human("");
            _ = new Human("");
            _ = new Human("");
            _ = new Human("");
            _ = new Human("");

            Console.WriteLine(Human.HumanCount);

            Human.HumanCount += 6;


            Console.WriteLine(Human.HumanCount);
            Console.WriteLine(Ana.FullDescription());

            Console.Read();
        }

        static string CustomHello()
        {
            return "Hello World!";
        }
    }

    class NewClass { }



}
