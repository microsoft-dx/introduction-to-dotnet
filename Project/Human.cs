using System;
using System.Linq;

namespace Humans
{
    class Human
    {
        public static int Count = 10;
        public string Name;

        public Human(string givenName)
        {
            Count++;

            Name = Count.ToString() + givenName;
        }

        public string PresentYourself()
        {
            return "My name is " + Name;
        }

        public string TellGender()
        {
            if (Name == null)
                return "";

            if (Name.EndsWith("a"))
            {
                return "I am a girl";
            }
            else
            {
                return "I am a boy";
            }
        }

        public int NumberOfVowelsWithFor()
        {
            char[] nameByChar = Name.ToCharArray();
            int numberOfV = 0;
            char[] listOfVowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'y' };

            for (int i = 0; i < nameByChar.Length; i += 1)
            {
                if (listOfVowels.Contains(nameByChar[i]))
                {
                    numberOfV++;
                }
            }

            return numberOfV;
        }

        public int NumberOfVowelsWithWhile()
        {
            char[] nameByChar = Name.ToCharArray();
            int numberOfV = 0;
            char[] listOfVowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'y' };

            int j = 0;
            while (j < nameByChar.Length)
            {
                char currentLetter = nameByChar[j];
                if (listOfVowels.Contains(currentLetter))
                {
                    numberOfV++;
                }
                j++;
            }

            return numberOfV;
        }

        internal string FullDescription()
        {
            return "Hello, my name is " + Name;
        }

        public int NumberOfVowelsWithDoWhile()
        {
            char[] nameByChar = Name.ToCharArray();
            int numberOfV = 0;
            char[] listOfVowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'y' };

            int j = 0;
            while (j < nameByChar.Length)
            {
                char currentLetter = nameByChar[j];
                if (listOfVowels.Contains(currentLetter))
                {
                    numberOfV++;
                }
                j++;
            }

            return numberOfV;
        }
        
    }
}