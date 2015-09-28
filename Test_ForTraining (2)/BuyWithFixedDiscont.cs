using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_ForTraining__2_
{
    class BuyWithFixedDiscount : Buy
    {
        private int transportCost;
        public BuyWithFixedDiscount(int id, int day, int month, int count, int price, int transportCost) : base(id, day, month, count, price)
        {
            this.transportCost = transportCost;
        }

        public BuyWithFixedDiscount()
            : base()
        {
            transportCost = 10;
        }
        public override int Cost()
        {
            return base.Price*base.Count-transportCost;
        }

        public override string ToString()
        {
            return base.ToString ( ) + "Фиксированная скидка: " + transportCost;
        }
    }
}
