using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.W._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int a1 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            int c1 = Convert.ToInt32(Console.ReadLine());
            double S, S1, Max;
            Squar(a, b, c, out S);
            Squar(a1, b1, c1, out S1);
            Max = Math.Max(S1, S);
            Console.WriteLine(S);
            Console.WriteLine(S1);
            Console.WriteLine(Max);
            Console.ReadKey();
        }
        static void Squar(int a,int b,int c, out double S)
        {
            double p = (a + b + c) / 2;

            S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
