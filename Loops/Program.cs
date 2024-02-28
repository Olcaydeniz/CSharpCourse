﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();
            //While
            //WhileLoop();
            //DoWhileLoop();
            //ForEachLoop();



            Console.ReadLine();
        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number-1; i++)
            {
                if (number%i==0)
                {
                    result = false;
                }
            }
            return result;

        }


        private static void ForEachLoop()
        {
            string[] students = new string[] { "Olcay", "Deniz", "Engin" };
            foreach (var student in students)
            {
                //student = "Ups"; //Döngü içerisine eleman eklenemez 
                Console.WriteLine(student);
            }
        }

        private static void DoWhileLoop()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 10);
        }

        private static void WhileLoop()
        {
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("Now number is {0}", number);
        }

        private static void ForLoop()
        {
            for (int i = 2; i <= 100; i = i + 2)  //(int i = 100; i >=0; i=i-1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finish!!!");
        }
    }
}
