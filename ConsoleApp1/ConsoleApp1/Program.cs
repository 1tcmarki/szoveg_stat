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
        static void Forditas(string f)
        {
            for (int i = f.Length-1; i > 0; i--)
            {
                Console.WriteLine(f[i]);


            }
        
        

        }

        static void Main(string[] args)
        {
            //0. feladat
            string forras = "szoveg";
            //1. feladat
            int Forras_szama = Osszegzes(forras);
            Console.WriteLine($"{Forras_szama} betubol all");
            //2. feladat
            string forditott_szoveg = "a";
            Console.WriteLine($"{forditott_szoveg}");


            Console.WriteLine("gomb");
            Console.ReadKey();
        }
    }
}
