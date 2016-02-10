using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com
{
    class Complex
    {
        public int a, b; // a/b;
        public Complex(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public void Print()
        {
            Console.WriteLine(this.a + "/" + this.b);
        }
        public override string ToString()
        {
            return a + "/" + b;
        }
        public static Complex operator +(Complex c1, Complex c2)
        {
            int num1, num2;
            if (c1.b == c2.b)
            {
                num1 = c1.a + c2.a;
                num2 = c1.b;
            }
            else
            {
                num1 = c1.a * c2.b + c1.b * c2.a;
                num2 = c1.b * c2.b;
            }
            if (num1 > num2)
            {
                for (int i = num2; i > 1; i--)
                {
                    if (num1 % i == 0 && num2 % i == 0)
                    {
                        num1 = num1 / i;
                        num2 = num2 / i;
                    }
                }
            }
            else
            {
                for (int i = num1; i > 1; i--)
                {
                    if (num1 % i == 0 && num2 % i == 0)
                    {
                        num1 = num1 / i;
                        num2 = num2 / i;
                    }
                }
            }
            Complex q = new Complex(num1, num2);
            return q;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            string bir = Console.ReadLine();
            string eki = Console.ReadLine();
            string[] birinwi = bir.Split('/');
            string[] ekinwi = eki.Split('/');
            Complex c = new Complex(int.Parse(birinwi[0]), int.Parse(birinwi[1]));
            Complex d = new Complex(int.Parse(ekinwi[0]), int.Parse(ekinwi[1]));

            Complex e = c + d;
            Console.WriteLine(e);
            Console.ReadKey();


        }

    }
}
