﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IWorker[] workers = new IWorker[3] {

            new Worker(),
            new Manager(),
            new Robot()
            };
            foreach (var worker in workers)
            {
                worker.Work(); 
            }

            IEat[] eats = new IEat[2] 
            { 
                new Worker(),
                new Manager()
            };

            foreach (var eat in eats)
            {
                eat.Eat();
            }


        }
    }
    interface IEat
    {
        void Eat();
    }
    //SOLID, Interface Segregation
    interface IWorker
    {
        void Work();
    }
    interface ISalary
    {
        void Salary();
    }




    class Manager : IWorker, ISalary, IEat
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Salary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    class Worker : IWorker, ISalary, IEat
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Salary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}
