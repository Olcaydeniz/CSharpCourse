﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
     class Customer
    {
        //field
        // public string FirstName;

        //Property

        public int Id { get; set; }
        private string _firstName;
        public string FirtName { get; set; }
        //{
        //    get { return "Mr." + _firstName; }
        //    set { _firstName = value; }
        //}


        public string LastName { get; set; }
        public string City { get; set; }
    }
}
