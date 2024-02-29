using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();   

            ProductrManager productrManager = new ProductrManager();    
            productrManager.Add();
            productrManager.Update();

            Customer customer = new Customer();
            customer.Id =  1 ;
            customer.FirtName = "Olcay";
            customer.LastName = "Deniz";
            customer.City = "Adana";

            Customer customer2 = new Customer
            {
                Id = 2 ,FirtName="Ol",LastName="De",City="Ada"
            };
            Console.WriteLine(customer2.FirtName);   

            Console.ReadLine();
        }

        

      


    }
}
