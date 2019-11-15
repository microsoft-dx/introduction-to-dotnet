using Classes.Classes;
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
            Product chocolate = new Product(50);
            Product foodFor4Days = new Product(2000);
            LuxuryProduct car = new LuxuryProduct(6000);
            SuperLuxuryProduct newHouse = new SuperLuxuryProduct(40000);

            var groceryList = new Product[]
            {
                chocolate,
                foodFor4Days,
                chocolate,
                chocolate,
                car,
                foodFor4Days,
                chocolate,
                chocolate,
                newHouse,
                chocolate
            };

            decimal buget = 12000;
            for (int i = 0; i < groceryList.Length; i++)
            {
                if (groceryList[i].CanBuy(buget))
                {
                    buget = groceryList[i].BuyProduct(buget);
                    groceryList[i].YouHaveBoughtThis();
                    Console.WriteLine("Now I have " + buget);
                }
                else
                {
                    Console.WriteLine(":(");
                }
            }

            // Console.WriteLine(car.IsItGenuine());

            Console.WriteLine("Can I buy Chcolate with 51?");
            Console.WriteLine(chocolate.CanBuy(51));
            Console.WriteLine();

            Console.WriteLine("Can I buy Masked Luxury car with 6001?");
            Console.WriteLine(car.CanBuy(6001));
            Console.WriteLine("Can I buy Masked Luxury car with 8001?");
            Console.WriteLine(car.CanBuy(8001));
            Console.WriteLine();


            LuxuryProduct luxuryCar = (LuxuryProduct)car;

            Console.WriteLine("Is the car a luxury car?");
            Console.WriteLine(car == luxuryCar);
            Console.WriteLine();

            Console.WriteLine("Is the luxury car genuine?");
            Console.WriteLine(luxuryCar.IsItGenuine());
            Console.WriteLine("Can i buy a luxury car with 6001?");
            Console.WriteLine(luxuryCar.CanBuy(6001));
            Console.WriteLine("Can i buy a luxury car with 8001?");
            Console.WriteLine(luxuryCar.CanBuy(8001));



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
