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
            megtoltTabla();
        }

        public static void megtoltTabla()
        {

            for (int x = 1; x <= 8; x++)
            {
                for (int y = 1; y <= 8; y++)
                {
                    int[] cuc = { x, y }
                    console.WriteLine(cuc.ToString());
                }
            }

        }
    }
}