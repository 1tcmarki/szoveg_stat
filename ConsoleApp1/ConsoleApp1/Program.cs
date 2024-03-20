using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   



    class Program
    {
        static int Osszegzes(string f)
        {
            int db = 0;

            foreach (int item in f)
            {
                db++;
            }



            return db;
        }



        static void Main(string[] args)
        {
            string forras = "szoveg";

            int Forras_szama = Osszegzes(forras);
            Console.WriteLine($"{Forras_szama}");


        }
    }
}
