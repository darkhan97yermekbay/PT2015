using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, j;
            n = 0;
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            for (i = a; i <= b; i++)
            {
                for (j = 1; j <= i; j++) 
                {
                    if (i % j == 0)
                        n++;
                }
                if (n <= 2)
                {
                    Console.Write("{0} ",i);
                }
                n = 0;
            }
        Console.ReadKey();
            }

    }
}
