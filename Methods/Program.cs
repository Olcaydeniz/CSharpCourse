using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Method
            //Add();

            ////Parametreli Methodlar
            //var result = Add2(20,30);
            //Console.WriteLine(result);


            ////defauld parametreli methodlar
            //var result2 = Add3(50);
            //Console.WriteLine(result2);


            ////Ref Keyword
            //int number1 = 20;
            //int number2 = 100;
            //var result3 = Add4(ref number1, number2);
            //Console.WriteLine(result3);
            //Console.WriteLine(number1);


            ////out Keyword
            //int number3;
            //int number4 = 200;
            //var result4 = Add5(out number3, number4);
            //Console.WriteLine(result4);
            //Console.WriteLine(number3);


            ////Method Overloading
            //Console.WriteLine(Multifly(8, 4));
            //Console.WriteLine(Multifly(8, 4,2));

            //params
            Console.WriteLine(Add6(1, 2, 3, 5, 4, 6, 8));

            Console.ReadLine(); 
        }

        //Method
        static void Add()
        {
            Console.WriteLine("Added!");
        }
        //Parametreli Methodlar
        static int Add2(int number1, int number2)
        {
            var result = number1 + number2;
            return result;
        }

        //defauld parametreli methodlar
        static int Add3(int number1,int number2=30) // tek bir default değer her zaman parametrenin sonuna yazılır.
        {
            var result2=number1 + number2;
            return result2; 
        }

        //Ref Keyword
        static int Add4(ref int number1, int number2) // eğerki methodtan gönderilen değerin işlevsel olması için 'ref' eklenmesi gerekir
        {
            number1 = 30;
           return  number1 + number2;
       
        }

        //Out Keyword
        static int Add5(out int number3, int number4) // 'out' için bir değişken değerine ihtiyacı yoktur gerekir. fakat method içinde değere sahip olması gerekir.
        {
            number3 = 100;
            return number3 + number4;

        }

        //Method Overloading
        static int Multifly(int number1, int numnber2)
        { return number1 * numnber2; }
        static int Multifly(int number1, int numnber2,int number3)
        {
            return number1 * numnber2*number3; 
        }

        static int Add6(int number,params int[] numbers) //params'dan önce parametre  tanımlanır ise hesaplamada ilk değeri yer tutar
                                                         // paramstan sonra parametre tanımlamaz
        {
            return numbers.Sum();
        }



    }
}
