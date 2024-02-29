using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Intarfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IntarfacesIntro();
            
            
            
            
            Console.ReadLine();
        }

        private static void IntarfacesIntro()
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Olcay",
                LastName = "Deniz",
                Address = "Adana"

            };
            Student student = new Student
            {
                Id = 1,
                FirstName = "Den",
                LastName = "Ups",
                Departmant = "Person"
            };
            manager.Add(customer);
            manager.Add(student);
        }

        interface IPerson
        {
            int Id { get; set; }
            string FirstName { get; set; }   
            string LastName { get; set; }
        }


        class Customer : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address {get; set;}
        }

        class Student : IPerson
        {
            public int Id { get ; set; }
            public string FirstName { get; set ; }
            public string LastName { get; set; }
            public string Departmant {  get; set; }

        }

        class PersonManager 
        {
            public void Add(IPerson person)
            {
                Console.WriteLine(person.FirstName);
            }

        }



    }
}
