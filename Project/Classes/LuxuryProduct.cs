using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Classes
{
    class LuxuryProduct : Product
    {
        protected int sth;
        public bool Demo;
        public LuxuryProduct(decimal givenPrice) : base(givenPrice)
        {
        }

        protected string TaxCut()
        {
            return "Get Some";
        }

        public bool IsItGenuine()
        {
            return Price > 5000;
        }

        public override bool CanBuy(decimal ammountOfMoney)
        {
            return (Price * (decimal)1.2) < ammountOfMoney ;
        }

        public override decimal BuyProduct(decimal ammountOfMoney)
        {
            return ammountOfMoney - (Price * (decimal)1.2);
        }
    }
}
