using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_ForTraining__2_
{
    public enum Discount
        {
            noDiscount,
            Type1,
            Type2,
            Type3
        }
    class Program
    {     
        static void Main ( string[] args )
        {
            BuyFactory factory ;
            List<Buy> items = new List<Buy> ( );

            //создание и добавление объектов
        
            items.Sort ( );

            int countBuy = 0;
            foreach ( var item in items )
            {
                if ( item.Day == 10 )
                    countBuy++;
                Console.WriteLine ( item.ToString ( ) );
            }

            if ( countBuy > 0 )
            {
                Console.WriteLine ( "Покупок 10-го числа: " + countBuy );
            }
            else
            {
                Console.WriteLine ( "10-го числа не совершено ни одной покупки." );
            }

            Console.ReadKey ( );
        }
    }
}
