using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int M = Convert.ToInt32(Console.ReadLine());
            int T = Convert.ToInt32(Console.ReadLine());

            string MM = "";
            string NN = "";

            M += T;
            N += M / 60;
            M = M % 60;
            N = N % 24;

            if (M >= 0)
            {
                N += M / 60;
                M -= M / 60 * 60;
                N -= N / 24 * 24;
            }

            if (M < 10)
            {
               MM = '0' + Convert.ToString(M);
            }
            else
            {
                MM = Convert.ToString(M);
            }
            if (N < 10)
            {
                NN = '0' + Convert.ToString(N);
            }
            else
            {
                NN = Convert.ToString(N);
            }

            Console.WriteLine(NN + ":" + MM);
            Console.ReadKey();
        }
    }
}
