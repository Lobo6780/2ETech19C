using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        public static int Kp4z2(int n)
        {
            int sum = 0,cyfra;
            while (n > 0)
            {
                cyfra = n % 10;
                sum += cyfra;
                n /= 10;
            }
            return sum;
        }
        public static int Kp4z3(int n)
        {
            int suma = 1;
            for (int i = 1; i <= n; i++)
            {
                suma *= i;
            }
            return suma;
        }
        public static int Kp4z4(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            return Kp4z4(n - 1) + Kp4z4(n + 2);
        }

        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            //Console.WriteLine(Kp4z2(a));
            //Console.WriteLine(Kp4z3(a));
            Console.WriteLine(Kp4z4(a));
        }
    }
}
