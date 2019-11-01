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
            GettersAndSetters();

            Console.Read();
        }

        static void GettersAndSetters()
        {
            Human Bob = new Human("Bob");
            Console.WriteLine(Human.Count);

            Bob.FullName = "Alice";
            Bob.FullName = "Maria";

            Bob.FullName = "Sir. Bob the Great";
            Bob.FullName = "Mariaaaaaaaaa";
            Bob.FullName = "IDK anymore";
            Bob.FullName = "Sir. Bob the Greatest";
            Bob.FullName = "Sir. Bob";

            Console.WriteLine(Bob.FullName);
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
            //John._currentName += " Something";
            //Console.WriteLine(John._currentName);
            Console.WriteLine(John.TellGender());

            // Creating another Human
            Human Ana = new Human("Ana");

            // Using the Static Member of a Class
            Console.WriteLine(Human.Count);
            Console.WriteLine(Ana.FullDescription());

            _ = new Human("");
            _ = new Human("");
            _ = new Human("");
            _ = new Human("");
            _ = new Human("");
            _ = new Human("");

            Console.WriteLine(Human.Count);

            Human.HumanCount += 6;

            Console.WriteLine(Human.Count);
            Console.WriteLine(Ana.FullDescription());
        }

        static string CustomHello()
        {
            return "Hello World!";
        }
    }
}
