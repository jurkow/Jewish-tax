using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    // classy
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Tax(23));
            Console.WriteLine(Tax(5000));
            Console.WriteLine(Tax(5800));
            Console.WriteLine(Tax(9000));
            Console.WriteLine(Tax(15000));
            Console.WriteLine(Tax(50000));
            // for (int i = 0; i < 500000; i++) Console.WriteLine(Tax(i));
            Console.ReadLine();
        }

        private static readonly double[] TaxTable = new double[] { 0, 0.1, 0.14, 0.23, 0.3, 0.33, 0.45 };
        private static readonly double[] T = new double[] { 0, 5070, 8660, 14070, 21240, 40230 };
        public static double Tax(double value, int t = 0, double tax = 0)
        {
            return (++t < T.Count() && value > T[t] - T[t - 1]) ? Tax(value - T[t] + T[t - 1], t, tax + (T[t] - T[t - 1]) * TaxTable[t]) : tax + value * TaxTable[t];
        }


        //public static double Tax2(double value, int t = 0, double tax = 0)
        //{
        //    if (++t < T.Count() && value > T[t] - T[t - 1]) return Tax(value - T[t] + T[t - 1], t, tax + (T[t] - T[t - 1]) * TaxTable[t]);
        //    return tax + value * TaxTable[t];
        //}
    }
}
