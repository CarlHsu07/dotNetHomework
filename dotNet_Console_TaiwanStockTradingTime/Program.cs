using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet_Console_TaiwanStockTradingHours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2022, 12, 25, 13, 30, 00);
            Console.WriteLine($"{dt}\n{IsTradingHours(dt)}");
            
        }

        public static bool IsTradingHours(DateTime dt)
        {
            TimeSpan ts1 = new TimeSpan(9, 00, 00);
            TimeSpan ts2 = new TimeSpan(13, 30, 00);

            if ((dt.DayOfWeek != DayOfWeek.Saturday) && (dt.DayOfWeek != DayOfWeek.Sunday)) {
                if (dt.TimeOfDay >= ts1 && dt.TimeOfDay <= ts2) { return true; }
            }
            return false;
        }
    }
}
