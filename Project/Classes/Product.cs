using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Classes
{
    class Product
    {
        protected decimal Price;
        protected string Name;

        public string WhoAmI()
        {
            return Name;
        }

        public Product(decimal givenPrice)
        {
            Price = givenPrice;
        }

        public virtual bool CanBuy(decimal ammountOfMoney)
        {
            return Price < ammountOfMoney;
        }

        public virtual decimal BuyProduct(decimal ammountOfMoney)
        {
            return ammountOfMoney - Price;
        }

        public void YouHaveBoughtThis()
        {
            Console.WriteLine("Yey, I got the product that costs " + Price);
        }
    }
}
