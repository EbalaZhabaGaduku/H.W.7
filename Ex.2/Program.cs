using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            double S, V;
            Squar(a, out S,out V);
            Console.WriteLine(S);
            Console.WriteLine(V);
            Console.ReadKey();
        }
        static void Squar(int a,  out double S,out double V)
        {
            S = 6 * a * a;
            V = a * a * a;

        }
    }
}
