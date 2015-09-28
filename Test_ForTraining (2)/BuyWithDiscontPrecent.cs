using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_ForTraining__2_
{
    class BuyWithDiscountPrecent : Buy
    {
        private int discountPercent;
        public BuyWithDiscountPrecent ( int id, int day, int month, int count, int price, int discountPercent )
            : base ( id, day, month, count, price )
        {
            this.discountPercent = discountPercent;
        }
        public BuyWithDiscountPrecent() : base ()
        { }
        override public int Cost()
        {
            return base.Price * base.Count* ( 1 - discountPercent / 100 );
        }

        public override string ToString()
        {
            return base.ToString ( ) + "Процент скидки: " + discountPercent;
        }
    }
}
