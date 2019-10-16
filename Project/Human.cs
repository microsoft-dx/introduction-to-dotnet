namespace Humans
{
    class Human
    {
        // Those are non-static Members
        public string Name;
        private bool isABoy;
        private int ID;

        // This is a static Member
        public static int HumanCount = -100;

        // This is a constructor with a parameter
        public Human(string nameOfHuman)
        {
            Name = nameOfHuman;
            //isABoy = true;

            ID = HumanCount;
            HumanCount += 1;
        }

        // This is a method
        public string FullDescription()
        {
            return ID.ToString() + " " + Name;
        }

        // This is also method
        public string TellGender()
        {
            if (isABoy)
                return "Male";
            else
                return "Female";
        }
    }
}
