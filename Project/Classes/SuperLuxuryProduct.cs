using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Classes
{
    class SuperLuxuryProduct : LuxuryProduct
    {
        private new int sth;

        public SuperLuxuryProduct(decimal givenPrice) : base(givenPrice)
        {
        }
        public override decimal BuyProduct(decimal ammountOfMoney)
        {
            return base.BuyProduct(ammountOfMoney);
        }
    }
}
