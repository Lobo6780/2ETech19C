using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    interface IRemote
    {
        void zdalnie();
    }
    interface IKeyless
    {
        void wejdz();
    }

    abstract class Auto
    {
        public abstract string Model { get; set; }
        public virtual void jedz()
        {
            Console.WriteLine("Jadę");
        }
    }
    class Audi : Auto, IRemote, IKeyless
    {
        public override string Model { get; set; }
        public override void jedz()
        {
            Console.WriteLine("Jadę ");
        }
        public void zdalnie()
        {
            Console.WriteLine("Zdalny...");
        }
        public void wejdz()
        {
            Console.WriteLine("Wchodze...");
        }
    }
    class BMW : Auto
    {
        public override string Model { get; set; }
        public override void jedz()
        {
            Console.WriteLine("Jadę ");
        }
    }
    class Mercedes : Auto
    {
        public override string Model { get; set; }
        public override void jedz()
        {
            Console.WriteLine("Jadę ");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
