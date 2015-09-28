using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_ForTraining__2_
{
    class Buy
    {
        private int id;
        private int day;
        private int month;
        private int count;
        private int price;

        public int Day
        {
            get { return day; }
            set { day = value; }
        }

        public int Month
        {
            get { return month; }
            set { month = value; }
        }

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public Buy ()
        {
            this.id = 0;
            this.day = 1;
            this.month = 1;
            this.count = 1;
            this.price = 300;
        }

        public Buy ( int id, int day, int month, int count, int price )      
        {
            this.id = id;
            this.day = day;
            this.month = month;
            this.count = count;
            this.price = price;
        }

        public virtual int Cost ( )
        {
            return price * count;
        }

        public int CompareTo ( Buy obj )
        {
            if ( obj.Day < this.Day )
                return 1;
            else if ( obj.Day > this.Day )
            {
                return -1;
            }
            else
                return 0;
        }

        public override string ToString ( )
        {
            return string.Format ( "День: {0}, Месяц: {1}, Кол-во: {2}, Цена: {3}, Общая ст-ть: {4}", Day, Month, Count, Price, Cost ( ) );
        }
    }
}
