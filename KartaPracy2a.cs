using System;

namespace KartaPracy2a
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. (easy) Sprawdź czy suma dwóch wpisanych przez użytkownika jest liczbą parzystą.
            // Wejście: a, b
            // Wyjście: TAK / NIE

            /*int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if ((a+b)%2==0)
            {
                Console.WriteLine("TAK");
            }
            else
            {
                Console.WriteLine("NIE");
            }*/

            // 2. (easy) Sprawdź, czy średnia arytmetyczna dwóch wpisanych liczb jest wieksza od jej średniej geometrycznej.
            // Wejście: a,g
            // Wyjście: TAK / NIE

            /*int a = int.Parse(Console.ReadLine());
            int g = int.Parse(Console.ReadLine());

            if ((a+g)/2>Math.Pow(a*g,2))
            {
                Console.WriteLine("TAK");
            }
            else
            {
                Console.WriteLine("NIE");
            }*/

            // 3. (easy) Użytkownik podaje 3 liczby całkowite. Sprawdź czy dokładnie dwie z nich są sobie równe.
            // Wejście: k,l,m
            // Wyjście: TAK / NIE (wraz z podaniem tych dwóch równych o ile są takowe)

            /*int k = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            if (k==l)
            {
                Console.WriteLine("TAK");
            }
            else if (l==m)
            {
                Console.WriteLine("TAK");
            }
            else if (m==k)
            {
                Console.WriteLine("TAK");
            }
            else
            {
                Console.WriteLine("NIE");
            }*/

            // 4. (medium) Niech użytkownik wprowadzi 4 różne liczby całkowite. Napisz program, który sprawdzi, która
            // z tych liczb jest najmniejsza.
            // Wejście: a,b,c,d
            // Wyjście: najmniejsza z nich

            /*int a = int.Parse(Console.ReadLine());
            int wynik = a;
            int b = int.Parse(Console.ReadLine());
            if (wynik > b)
            {
                wynik = b; 
            }
            int c = int.Parse(Console.ReadLine());
            if (wynik > c)
            {
                wynik = c;
            }
            int d = int.Parse(Console.ReadLine());
            if (wynik > d)
            {
                wynik = d;
            }
            Console.WriteLine($"Najmniejsza liczba to: {wynik}");*/

            // 5. (medium) Sprawdź czy trzy wprowadzone przez użytkownika liczby spełniają nierówność trójkąta.
            // Wejście: a, b, c
            // Wyjście: TAK / NIE

            /*int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a<b+c)
            {
                Console.WriteLine("TAK");
            }
            else if(b<a+c)
            {
                Console.WriteLine("TAK");
            }
            else if(c<a+b)
            {
                Console.WriteLine("TAK");
            }
            else
            {
                Console.WriteLine("NIE");
            }*/

            // 6. (medium) Niech z trzech wprowadzonych przez użytkwnika liczbach da się zbudować trójąt. Sprawdź czy
            // ten trójkąt jest ostrokątny, prostokątny czy rozwartokątny.
            // Wejście: a, b, c
            // Wyjście: ostro-, prosto-, rozwarto-kątny

            /*int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a > 0 & b > 0 & c > 0 & a < b + c && b < a + c && c < a + b)
            {
                Console.WriteLine("Trójkąt spełnia równanie");
                if (a*a + b*b == c*c | a*a + c*c == b*b | c*c + b*b == a*a)
                {
                    Console.WriteLine("Trójkąt prostokątny");
                }
                else if (a*a + b*b < c*c | a*a + c*c < b*b | c*c + b*b < a*a)
                {
                    Console.WriteLine("Trójkąt ostrokątny");
                }
                else if(a*a + b*b > c*c | a*a + c*c > b*b | c*c + b*b > a*a)
                {
                    Console.WriteLine("Trójkąt rozwartokątny");
                }
            }
            else
            {
                Console.WriteLine("Trójkąt nie spełnia równania");
            }*/
        }
    }
}
