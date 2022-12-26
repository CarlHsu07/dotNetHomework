using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet_Console_MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(MultiplicationTableUtility.CalcMultiplication(2, 9, 9));
        }


    }

    public class MultiplicationTableUtility
    {
        public static string CalcMultiplication(int MultiplicandStart, int MultiplicandEnd, int Multiplier)
        {
            if (MultiplicandStart > MultiplicandEnd) {
                int temp;
                temp = MultiplicandStart;
                MultiplicandStart = MultiplicandEnd;
                MultiplicandEnd = temp;
            }
            if (MultiplicandStart < 2 || MultiplicandEnd > 9) { 
                MultiplicandStart = 2;
                MultiplicandEnd = 9;
            }
            if (Multiplier < 1 || Multiplier > 9) { Multiplier = 9; }

            string result = string.Empty;
            for (int multiplicand = MultiplicandStart; multiplicand <= MultiplicandEnd; multiplicand++)
            {
                for (int multiplier = 1; multiplier <= Multiplier; multiplier++)
                {
                    result += $"{multiplicand} * {multiplier} = {(multiplicand * multiplier).ToString().PadLeft(2)}\n";
                }
                result += "\n";
            }
            return result;
        }

    }


}
