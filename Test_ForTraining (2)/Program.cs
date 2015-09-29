using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Test_ForTraining__2_
{

    class Program
    {
        static void Main ( string[] args )
        {
            List<Buy> items = new List<Buy> ( );
          
            items.Add ( new Buy ( 1, 5, 3, 20 ) );
            items.Add ( new Buy ( 2, 5, 2, 10 ) );
            items.Add ( new Buy ( 3, 7, 3, 10 ) );
            items.Add ( new BuyWithBonusItem ( 4, 25, 5, 5, items[0] ) );
            items.Add ( new BuyWithBonusItem ( 5, 1, 3, 300, items[0] ) );
            items.Add ( new Buy ( 6, 10, 2, 10 ) );
            items.Add ( new Buy ( 7, 3, 4, 20 ) );
            items.Add ( new BuyWithDiscountPrecent ( 8, 11, 6, 5, 12 ) );
            items.Add ( new Buy ( 9, 27, 2, 300 ) );
            items.Add ( new Buy ( 10, 1, 3, 200 ) );
            items.Add ( new BuyWithFixedDiscount ( 11, 10, 2, 10, 7 ) );
            items.Add ( new BuyWithDiscountPrecent ( 12, 22, 4, 15, 10 ) );

            Console.WriteLine ( "Mounth buy list" );
            items.ForEach ( i => Console.WriteLine ( i.ToString ( ) ) );

            Console.WriteLine();
            Console.WriteLine ( "Buy list sorted by date" );
            items.Sort ( );
            items.ForEach ( i => Console.WriteLine ( i.ToString ( ) ) );

            Console.WriteLine ( );
            Console.WriteLine ( "Buy list by category" );
            items.Sort(((buy, buy1) => String.Compare(buy.GetType().ToString(), buy1.GetType().ToString(), StringComparison.Ordinal)));
            items.ForEach ( i => Console.WriteLine ( i.ToString ( ) ) );

            Console.WriteLine();
            var isBuyInTenDay = items.Any ( i => i.Day == 10 );
            Console.WriteLine ( isBuyInTenDay ? "10 numbers have been buying" : "do not make a purchase of 10." );

            Console.ReadKey ( );
        }
    }
}
