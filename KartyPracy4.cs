using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zad 1

            /*int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine(a*a + b*b);*/

            //Zad 3

            /*int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());

            if (x>=y && x>=z)
            {
                if (y>=z) Console.WriteLine($"{x} {y} {z}");
                else Console.WriteLine($"{x} {z} {y}");
            }
            else if (x<=y && y>=z)
            {
                if (x>=z) Console.WriteLine($"{y} {x} {z}");
                else Console.WriteLine($"{y} {z} {x}");
            }
            else if (z>=x && z>=y)
            {
                if (x >= y) Console.WriteLine($"{z} {x} {y}");
                else Console.WriteLine($"{z} {y} {x}");
            }*/

            //Zad 4

            /*int n = int.Parse(Console.ReadLine());
            int wynik = 1;

            for (int i = 1; i <= n; i++)
            {
                wynik = wynik * i;
            }
            Console.WriteLine(wynik);*/

            //Zad 5

            /*for (int i = -7; i <= 17; i+=4)
            {
                Console.WriteLine(i);
            }

            int n = -7;
            while (n <= 17)
            {
                Console.WriteLine(n);
                n += 4;
            }*/

            //Zad 6

            /*for (int i = 2; i <= 486; i*=3)
            {
                Console.WriteLine(i);
            }

            int x = 2;
            while (x <= 486)
            {
                Console.WriteLine(x);
                x *= 3;
            }*/

            //Zad 9

            /*int n = int.Parse(Console.ReadLine());
            int liczba = n;
            int x = 0, suma = 0;

            while (liczba > 0)
            {
                x = liczba % 10;
                suma += x;
                liczba = liczba / 10;
            }
            Console.WriteLine(suma);*/

            //Zad 8

            /*int n = int.Parse(Console.ReadLine());
            int z = 0;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n%i == 0)
                {
                    z += 1;
                    break;
                }
            }
            if (z == 0) Console.WriteLine("TAK");
            else Console.WriteLine("NIE");*/


        }
    }
}
