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
            ClassesWithSimpleInstructions();
            Console.Read();
        }

        static void ClassesWithSimpleInstructions()
        {

            Human Bob = new Human("Bobert");
            Console.WriteLine(Bob.PresentYourself());
            Console.WriteLine(Human.Count);
            Console.WriteLine(Bob.TellGender());

            Human Alice = new Human("Ana");
            Console.WriteLine(Alice.PresentYourself());
            Console.WriteLine(Human.Count);
            Console.WriteLine(Alice.TellGender());

            Console.WriteLine(Alice.NumberOfVowelsWithFor());
            Console.WriteLine(Alice.NumberOfVowelsWithWhile());
            Console.WriteLine(Alice.NumberOfVowelsWithDoWhile());

            // OneLiner
            // Alice.Name.ToLower().ToCharArray().Sum(x => (new char[]{'a', 'e', 'i', 'o', 'u', 'y'}).Contains(x) ? 1 : 0));
        }
        static void JustClasses()
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
        }

        static string CustomHello()
        {
            return "Hello World!";
        }
    }
}
