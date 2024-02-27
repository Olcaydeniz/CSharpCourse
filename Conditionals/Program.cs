using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            //if Şart Blok 
            var number = 441;



            if (number == 10)
            {
                Console.WriteLine("Number is 10");
            }
            else
            {
                Console.WriteLine("Number is not 10");
            }


            // Single Line if örneği
            //Console.WriteLine(number == 10 ? "Number is 15" : "Number is not 15");


            //İç içe if

            if (number == 10)
            {
                Console.WriteLine("Number is 10");
            }
            else if (number == 20)
            {
                Console.WriteLine("Number is 20");
            }
            else
            {
                Console.WriteLine("Number is not 10 or 20");
            }


            // Switch 

            //switch (number)
            //{
            //    case 10:
            //        Console.WriteLine("Number is 10");
            //        break;
            //    case 20:
            //        Console.WriteLine("Number is 20");
            //        break;
            //    default:
            //        Console.WriteLine("Number is not 10 or 20");
            //        break;

            //}


            //Çoklu şartlarda çalışma

            //if(number >= 0 && number<=100)
            //{
            //    Console.WriteLine("Number is between 0-100");
            //}
            //else if (number>100 && number <=200) //  && ve anlamı
            //{ 
            //    Console.WriteLine("Number is between 101-200");    
            //}
            //else if(number>200 || number<0) //    ||   veya anlamı 
            //{
            //    Console.WriteLine("Number is less than 0 or greater thab 200");
            //}


            //if(number<100)
            //{
            //    if (number >=90 && number<95)
            //    {

            //    }
            //    else
            //    {

            //    }

            //}
            //else
            //{

            //}
           

            Console.ReadLine();
        }
    }
}
