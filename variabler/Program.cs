using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variabler
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Övning 1
            Console.WriteLine("Mata in tal 1:");
            string tal1 = Console.ReadLine();
            int nummer1 = int.Parse(tal1);
            Console.WriteLine("Mata in tal 2:");
            string tal2 = Console.ReadLine();
            int nummer2 = int.Parse(tal2);

            Console.WriteLine("Summa:" + (nummer1 + nummer2));
            Console.WriteLine("Produkten:" + nummer1 * nummer2);
            Console.WriteLine("Divitionen:" + nummer1 / nummer2);
            Console.WriteLine("Tryck på valfri knapp för att förtsätta...");

            Console.ReadKey();
            */

            //Övning 2
            /*
            Console.WriteLine("Mata in dit förnamn:");
            string förnamn = Console.ReadLine();
            Console.WriteLine("Mata in ditt efternamn");
            string efternamn = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Hej " + förnamn + " " + efternamn + "!");

            Console.WriteLine();

            Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
            Console.ReadKey();
            */
            //Övning3
            /*
            Console.WriteLine("Mata in grader i Celsius:");
            string graderC = Console.ReadLine();
            double graderF = double.Parse(graderC);
            Console.WriteLine("Det blir " + (graderF * 1.8 + 32) + " grader Farenheit.");
            Console.WriteLine("Tryck ned valfri tangent för att fortsätta...");
            Console.ReadKey();
            */
            //Övning4
            /*
            Console.Write("Mata in grader i Celsius: ");
            string graderC = Console.ReadLine();
            double graderF = double.Parse(graderC);
            Console.WriteLine("Det blir " + (graderF * 1.8 + 32) + " grader Farenheit.");
            Console.WriteLine("Tryck ned valfri tangent för att fortsätta...");
            Console.ReadKey();
            */
            //Övning5
            Console.Write("Cirkelns radie: ");
            string radie = Console.ReadLine();
            double nyttVärde = double.Parse(radie);
            double pi = Math.PI;
            Console.WriteLine("Area: " + (nyttVärde * nyttVärde * pi));
            Console.WriteLine("Omkrets " + (nyttVärde * 2 * pi));
            Console.WriteLine("Tryck ned valfri tangent för att fortsätta...");
            Console.ReadKey();
        }
    }
}
