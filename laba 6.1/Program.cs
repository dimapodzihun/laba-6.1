using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Значення b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Значення c:");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Значення a:");
            int a = Convert.ToInt32(Console.ReadLine());
            double result1 = mediana(b, c, a);
            Console.WriteLine("Результат 1(a):  " + result1);
            double result2 = mediana(c, a, b);
            Console.WriteLine("Результат 2(b):  " + result2);
            double result3 = mediana(b, a, c);
            Console.WriteLine("Результат 3(c):  " + result3);

        }
            static double mediana(int b, int c, int a)
            {

                double y = 0.5 * Math.Sqrt(2 * Math.Pow(b, 2) + 2 * Math.Pow(c, 2) - Math.Pow(a, 2));
                return y;
            }
        }
    }

