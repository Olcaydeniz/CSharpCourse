using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {

            new Customer
            {
                FirtName="Olcay"
            },
            new Student
            {
                FirtName="Deniz"
            },
            new Person
            {
                FirtName="Upss"
            }

            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirtName);
            }
            Console.ReadLine();
        }
        class Person 
        {
            public int Id { get; set; }
            public string FirtName { get; set; }  
            public string LastName { get; set; }
        }

        class Customer : Person 
        {
            public string City { get; set; }
        }
class Student : Person
{
    public string Department { get; set; }
        }
    }
}
