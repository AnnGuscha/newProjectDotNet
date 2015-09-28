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
        public BuyWithBonusItem(int id, int day, int month, int count, int price, Buy bonusItem) : base(id, day, month, count, price)
        {
            this.bonusItem = bonusItem;
        }

        public BuyWithBonusItem ( )
            : base ( )
        { }
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
            return base.ToString ( ) + "Стоимость бонусного товара: " + bonusItem.Price;
        }
    }
}
