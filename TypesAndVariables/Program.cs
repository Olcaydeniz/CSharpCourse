using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Value Types

            //Integer Veri Tipi
            int number1 = 2147483647;  //* -2 147 483 648 milyar  değeri alabilir  // 10 karakter değeri alır  //32bitlik yer kaplar
            Console.WriteLine("Number1 is {0}",number1);

            //Long Veri Tipi 
            long number2 = 2147483648;  // 19 karakter almaktadır //64bitlik yer kaplar
            Console.WriteLine("Numbe2 is {0}",number2);

            //Short Veri Tipi
            short number3 = -32768;   //16 bit yer kaplar
            Console.WriteLine("Numbe3 is {0}",number3);

            //byte Veri Tipi
            byte number4 = 255;                // 8 bit
            Console.WriteLine("Numbe4 is {0}", number4);

            // Bool Veri Tipi
            bool condition = true; //true veya false olarak şart kullanılır.

            //Char
            char charecter = 'A'; // klavyedki bütün  karakterlerin sayısal değerini gösterir.
            Console.WriteLine("Charracter is : {0}",(int)charecter);
            

            // Double Veri Tipi
            double number5 = 10.1; //64 bitlik veri tutar // virgülden 15 hane tutar
            Console.WriteLine("Numbe5 is {0}",number5);


            //Decimal Veri Tipi
            decimal number6 = 10.1m;  // virgülden 28 hane tutar
            Console.WriteLine("Numbe6 is {0}", number6);

            //Enum Veri Tipi //indexleme olarak enum sabitlerini tutar
            Console.WriteLine((int)Days.Friday);


            // Var   Değişken Tutma
            var number7 = 10; //var içine belirtilen değişken integer olarak tutulur
            number7 = 'A' ; // char ataması ile karakter sayısal değerini belirtir
            //   number7 = "A" ;  integer veriye string veri olarak tanımlanmayancağından hata olarak alınır.
            Console.WriteLine("Numbe6 is {0}", number7);








            Console.ReadLine();
        }
        enum Days
        {
            Monday,Tuesday,Wednesday,Thursday, Friday,Saturday
            //  Monday=1, Tuesday=2, Wednesday=3, Thursday=4, Friday =5, Saturday=6 // değişken atama işlemide yapılabilir
        }
    }
}
