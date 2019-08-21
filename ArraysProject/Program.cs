using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] adlar = {
            //    "Ulvi",
            //    "Gunel"
            //};

            //foreach (string ad in adlar)
            //{
            //    Console.WriteLine(ad);
            //}

            //Console.WriteLine("____________________");

            //for (int i = 0; i < adlar.Length; i++)
            //{
            //    string ad = adlar[i];
            //    Console.WriteLine(ad);
            //}

            //Console.WriteLine("____________________");

            //int olcu = adlar.Length;
            //int counter = 0;
            //while (counter < olcu)
            //{
            //    string ad = adlar[counter];
            //    Console.WriteLine(ad);
            //    counter++;
            //}


            //int[,] numbers = new int[3, 5];

            //int counter = 50;

            //for (int i = 0; i < 3; i++)
            //{

            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.WriteLine($"i = {i} | j = {j}");
            //        numbers[i, j] = counter;
            //        counter++;
            //    }
            //}


            //int[,] arr = new int[3, 2]
            //{
            //    { 5, 555},
            //    { 17, 1},
            //    { 50, 50}
            //};


            //int[][] scores = new int[5][];
            //scores[0] = new int[3] { 5, 15, 22 };
            //scores[1] = new int[5] { 50, 60, 70, 80, 90 };
            //scores[2] = new int[2] { 1, 99 };
            //scores[3] = new int[] { 77, 88, 40, 10 };
            //scores[4] = new int[] { 5, 11, 33 };

            //Console.WriteLine(scores[1][3]);


            //string[][] names = new string[3][];

            //names[0] = new string[] { "Gunel", "Ulvi" };

            Program p = new Program();

            string[] marka = new string[] {
                "BMW",
                "Subaru",
                "Mercedes",
                "Mazda",
                "Maseratti"
            };
            p.Display(marka);

            string[] cities = new string[] {
                "Baku",
                "Sumqayit",
                "Zeynalabdin qesebesi",
                "Xizi",
                "Quba",
                "Xacmaz"
            };

            Array.Sort(cities);
            Array.Reverse(cities);
            p.Display(cities);










            Console.ReadLine();
        } // End of Main


        public void Display(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{i+1}. {arr[i]}");
            }
        }
    }
}
