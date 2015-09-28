using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_ForTraining__2_
{
    class BuyFactory
    {
        public Buy CreateBuy(Discount discount)
        {
            Buy buy = null;
            switch ( discount )
            {
                case Discount.noDiscount:
                    {
                        buy = new Buy ( );
                    }
                    break;
                case Discount.Type1:
                    {
                        buy = new BuyWithDiscountPrecent();
                    }
                    break;
                case Discount.Type2:
                    {
                        buy = new BuyWithFixedDiscount(); 
                    }
                    break;
                case Discount.Type3:
                    {
                        buy = new BuyWithBonusItem(); 
                    }
                    break;
            }
            return buy;
        }

    }
}
