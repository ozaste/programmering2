using System;
using System.Collections.Generic;
using System.Text;

namespace Labb1OOP
{



    public class Customer
    {
        public string name {get; set;}

        public int age {get; set;}

        public string gender {get; set;}

        public Customer(string Name, int Age, string Gender)
        {

            name = Name;
            age = Age;
            gender = Gender;
            
        }

    }
}
