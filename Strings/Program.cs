using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro();

            string sentence = "My name is Olcay Deniz";
            var result =  sentence.Length;
            //Console.WriteLine(result);    
           
            var result2=sentence.Clone();
            sentence = "My name is Engin Demiroğ";
            bool result3 = sentence.EndsWith("ğ");
            bool result4 = sentence.StartsWith("M");
            var result5 = sentence.IndexOf("Olcay");
            var result6 = sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf(" ");
            var result8 = sentence.Insert(0," Upss,");
            var result9 = sentence.Substring(3,4);
            var result10 = sentence.ToUpper();
            var result11 = sentence.ToLower();
            var result12 = sentence.Replace(" ","-");  
            var result13=sentence.Remove(0,3);  



            Console.WriteLine(result13); 
            
            
            
            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Adana";
            //Console.WriteLine(city[0]);


            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";
            //string result=city+city2;
            //Console.WriteLine(result);

            Console.WriteLine(String.Format("{1} {0}", city, city2));
        }
    }
}
