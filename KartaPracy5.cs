using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0, pow = 0;
            for (int i = 10; i < 100; i++)
            {
                pow = 0;
                for (int j = 2; j < i; j++)
                {
                    if (i%j==0)
                    {
                        pow = pow + 1;
                        break;
                    }
                }
                if (pow == 0)
                {
                    Console.WriteLine($"pierwsza to {i}");
                    suma += i;
                }
            }
            Console.WriteLine(suma);
        }
    }
}
