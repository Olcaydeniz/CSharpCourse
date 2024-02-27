using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Array
            //string[] students = new string[3];
            ////students[0] = "Olcay";
            ////students[1] = "Deniz";
            ////students[2] = "Engin";

            //string[] students2 = new string[] {"Olcay","Deniz","Engin" };
            //string[] students3 = { "Olcay", "Deniz", "Engin" };


            //foreach (var student in students) 
            //{
            //    Console.WriteLine(student);
            //}

            //Çok Boyutlu Diziler
            string[,] regions = new string[5,3]
            {
                { "İstanbul","İzmit", "Balıkesir"},
                { "Ankara","Konya","Kırıkkale"},
                { "Antalya","Adana","Mermsin"},
                { "Rize","Trabzon","Samsun"},
                { "İzmir","Muğla","Manisa"}
            };
            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("***********");
            }
;
            Console.WriteLine();
            Console.ReadLine(); 

        }
    }
}
