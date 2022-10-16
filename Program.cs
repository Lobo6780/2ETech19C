using System;

namespace Nowak1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sprawdź czy liczba jest trzycyfrowa i podzielna przez 17
            int x = int.Parse(Console.ReadLine());
            int y = 0;

            while (x>0)
            {
                y = x % 10;
                x /= 10;
            }

            System.Console.WriteLine(y);
        }
    }
}
