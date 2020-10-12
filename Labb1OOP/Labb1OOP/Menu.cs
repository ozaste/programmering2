using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Labb1OOP
{

    
    public class Menu
    {

        public Register register;

        public Customer costumer;

        public Menu(Register register)
        {
            this.register = register;
        }

        public void MainMenu()
        { 
       
        }


    public void AddCustomer()
        {
            int age;
            
            Console.Clear();
            Console.WriteLine("Enter name of the customer.");
            string name = Console.ReadLine();
            Console.WriteLine("{0}", name);
            Console.ReadLine();
            name.ToLower();

            Console.WriteLine("Enter the age of the customer.");
            int.TryParse(Console.ReadLine(), out age);
            Console.WriteLine("{0},{1}", name, age);
            Console.ReadLine();

            Console.WriteLine("Enter the gender of the customer.");
            string gender = Console.ReadLine();
            Console.WriteLine("{0},{1},{2}", name, age, gender);
            Console.ReadLine();
            gender.ToLower();

            register.RegisterCustomer(name, age, gender);
            Console.WriteLine("Bekräfta kund med namn: Name:{0} , Age:{1}, Gender:{2}", name, age, gender);
            Console.ReadLine();
        }
    }
}
