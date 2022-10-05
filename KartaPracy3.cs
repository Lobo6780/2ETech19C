using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zad 1
            /*
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i*i*i+3);
            }
            */

            //Zad 2
            /*
            for (int i = 105; i < 1000; i+=15)
            {
                if (i%15==0)
                {
                    Console.WriteLine(i);
                }
            }
            */

            //Zad 3
            /*
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                if (n%i==0)
                {
                    Console.WriteLine(i);
                }
            }
            */

            //Zad 4
            /*
            int suma = 0;
            for (int i = 10; i < 100; i++)
            {
                suma += i;
            }
            Console.WriteLine(suma);
            */

            //Zad 5
            /*
            int n = int.Parse(Console.ReadLine());
            int suma = (n * (n + 1) / 2);
            int liczba = 0;
            Console.WriteLine(suma + "\n");
            for (int i = 0; i < n-1; i++)
            {
                liczba = int.Parse(Console.ReadLine());
                suma -= liczba;
            }
            Console.WriteLine(suma);
            */

            //Zad 6
            int a = 0,b = 1;
            int temp;
            for (int i = 0; i < 20; i++)
            {
                temp = b;
                b += i;
                temp = a;
                Console.WriteLine(b);
            }
        }
    }
}
