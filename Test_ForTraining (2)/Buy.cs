using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_ForTraining__2_
{
    class Buy : IComparable<Buy>
    {
        private int id;
        private int day;
        private int count;
        private int price;

        public int Day
        {
            get { return day; }
            set { day = value; }
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

        public Buy ( int id, int day, int count, int price )      
        {
            this.id = id;
            this.day = day;
            this.count = count;
            this.price = price;
        }

        public virtual int Cost ( )
        {
            return price * count;
        }

        public int CompareTo ( Buy temp )
        {
            if ( temp.Day < this.Day )
                return 1;
            else if ( temp.Day > this.Day )
            {
                return -1;
            }
            else
                return 0;
        }

        public override string ToString ( )
        {
            return string.Format ( "Day: {0,2}, Count: {1,2}, Price: {2,4}, Cost: {3,5}", Day, Count, Price, Cost ( ) );
        }
    }
}
