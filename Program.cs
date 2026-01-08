using System;
using System.Collections.Generic;
using System.Text;

namespace feladat
{

    public class Program
    {

        Negyzet[,] tabla = new Negyzet[8, 8];
        public static void Main(string[] args)
        {
            //Megkérdezi a játék, hogy mit akarunk csinálni
            Console.WriteLine("Üdv a sakk játékban!");
            Console.WriteLine("--------------------");
            Console.WriteLine("Mit szeretne csinálni? (új játék/játék folytatása)");
            string valasz = Console.ReadLine();
            switch (valasz)
            {
                case "új játék":
                    feltoltTabla("alap.csv");
                    break;
                case "játék folytatása":
                    feltoltTabla("mentes.csv");
                    break;
                default:
                    Console.WriteLine("Érvénytelen válasz.");
                    break;
            }

        }

        public static void feltoltTabla(string flie)
        {
            while (true)
            {

                string[] sorok = System.IO.File.ReadAllLines(flie);
                foreach (string sor in sorok)
                {
                    for (int karakter = 0; karakter < sor.Length; karakter+=2) {
                    }
                }
                break;


            }
        }
    }
}