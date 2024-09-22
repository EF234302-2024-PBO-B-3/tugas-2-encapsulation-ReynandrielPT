using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Encapsulation.Calendar
{
    public class Date
    {
  

        public int Month { get; private set; }
        public int Day { get; private set; }
        public int Year { get; private set; }

        public Date(int a, int b, int c)
        {
            if (a < 1 || a > 12 || b < 1 || b > 31)
            {
                Month = 1;
                Day = 1;
                Year = 1970;
            }
            else
            {
                Month = a;
                Day = b;
                Year = c;
            }

        }

        public void DisplayDate()
        {
            Console.WriteLine($"{Day}/{Month}/{Year}");
        }
    }

    //public class Program
    //{
    //    static void Main()
    //    {
    //        Date test = new Date(17, 8, 1945);
    //        Date test1 = new Date(-1, 11, 2001);
    //        test.DisplayDate();
    //        test1.DisplayDate();
    //    }
    //}

}
