using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectTest
{
    class Program
    {//
        static void Main(string[] args)
        {
            int broj1;
            Console.WriteLine("Ubacite broj 1");
            broj1 = Convert.ToInt32(Console.ReadLine());
            int broj2;
            Console.WriteLine("Ubacite slovo");
            broj2 = Convert.ToInt32(Console.ReadLine());

            int rez = broj1 + broj2;
            Console.WriteLine("Rezultat je : "+rez);
            Thread.Sleep(1000);



        }
    }
}
