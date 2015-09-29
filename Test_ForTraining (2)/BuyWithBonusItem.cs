using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_ForTraining__2_
{
    class BuyWithBonusItem : Buy
    {
        private Buy bonusItem;
        public BuyWithBonusItem(int id, int day, int count, int price, Buy bonusItem) : base(id, day, count, price)
        {
            this.bonusItem = bonusItem;
        }

        public override int Cost()
        {
            int cost;
            if (bonusItem != null)
            {
                cost = base.Price*base.Count - bonusItem.Price;
            }
            else
            {
                cost = base.Price * base.Count;
            }
            return cost;
        }

        public override string ToString()
        {
            return base.ToString ( ) + ", Bonus item cost: " + bonusItem.Price;
        }
    }
}
