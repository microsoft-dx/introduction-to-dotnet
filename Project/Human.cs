using System;
using System.Linq;

namespace Humans
{
    class Human
    {
        private static int _humanCount = 10;
        public static int Count => _humanCount;

        public static int HumanCount;

        private string _currentName;

        private bool _policeFoundMe;

        public string FullName
        {
            get
            {
                Console.WriteLine("I am a getter and I am amazing");

                return _currentName;
            }
            set
            {
                if (value.Contains(_currentName))
                    _currentName = value;
                else
                {
                    Console.WriteLine(
                        "The new name does not containt the initial name, sorry" +
                        "! The new name should be: " + value);
                }
            }
        }
        private string _autoFullName;
        public string NonAutoFullName
        {
            get { return _autoFullName; }
            set { _autoFullName = value; }
        }
        public string AutFullName { get; set; }

        public Human(string givenName)
        {
            _humanCount++;

            _currentName = givenName;
        }

        public string PresentYourself()
        {
            return "My name is " + _currentName;
        }

        public string TellGender()
        {
            if (_currentName == null)
                return "";

            if (_currentName.EndsWith("a"))
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
            char[] nameByChar = _currentName.ToCharArray();
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

        public string TellFullName(bool isThePolice)
        {
            if (isThePolice)
                return _currentName;

            return "";
        }

        public int NumberOfVowelsWithWhile()
        {
            char[] nameByChar = _currentName.ToCharArray();
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
            return "Hello, my name is " + _currentName;
        }

        public int NumberOfVowelsWithDoWhile()
        {
            char[] nameByChar = _currentName.ToCharArray();
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