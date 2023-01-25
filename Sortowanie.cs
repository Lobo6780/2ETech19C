using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Sortowanie
    {
        private List<int> lista;
        
        public List<int> sortuj(List<int> L)
        {
            return lista;
        }
        public void wyswietl(List<int> L)
        {
            foreach (int i in L)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }

    class Babelek : Sortowanie
    {
        public List<int> sortuj(List<int> L)
        {
            for (int i = 0; i < L.Count() - 1; i++)
            {
                for (int j= 0; j < L.Count() - 1 - i; j++)
                {
                    if (L[j] > L[j + 1])
                    {
                        int tmp = L[j + 1];
                        L[j + 1] = L[j];
                        L[j] = tmp;
                    }
                }
            }
            return L;
        }

    }

    class Debilne : Sortowanie
    {
        public List<int> sortuj(List<int> L)
        {
            L.Sort();
            L.Reverse();
            return L;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> K = new List<int>() { 7, 3, 2, 5, 1 };

            Babelek b = new Babelek();
            List<int> WYN = new List<int>();
            b.wyswietl(K);
            WYN = b.sortuj(K);
            b.wyswietl(WYN);

            List<int> WYN1 = new List<int>();
            Console.WriteLine();
            Debilne d = new Debilne();
            d.wyswietl(K);
            WYN1 = d.sortuj(K);
            d.wyswietl(WYN1);
        }
    }
}
