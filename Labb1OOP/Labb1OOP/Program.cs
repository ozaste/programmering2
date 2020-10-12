using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb1OOP
{
    public class Program
    {
        public Menu menu;

        public Register register;

        public Customer customer;

        public Product product;

        public Program()
        {
            menu = new Menu(register);
            register = new Register();
            
        }

        static void Main(string[] args)
        {
            new Program().Run();

        }
        public void Run()
        {

            string reg1 = "1";
            int age = 12;
            string gender = "hej;";
        register.RegisterCustomer(reg1, age, gender);

        string reg2 = "2";
            int age2 = 12;
            string gender2 = "hej;";
            register.RegisterCustomer(reg1, age, gender);


        string reg3 = "3";
            int age3 = 12;
            string gender3 = "hej;";
            register.RegisterCustomer(reg1, age, gender);

            Console.WriteLine("Press Enter to start");
            Console.ReadKey();
            MainMenu();
        }

        public void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("(1)-{Add new Customer}(2)-{Exit program}");
            string Action = Console.ReadLine();
            Action.ToLower();
            switch (Action)
            {
                case "1":
                    Console.Clear();
                    AddCustomer();
                    break;
                case "2":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
        public void AddCustomer()
        {

            string ChosenProductName;
            int totalCost;

            int Price1 = 19;
            string ProductName1 = "frukt";
            var prod1 = register.RegisterProduct(ProductName1, Price1);
            
            int Price2 = 109;
            string ProductName2 = "film";
            var prod2 = register.RegisterProduct(ProductName2, Price2);

            int Price3 = 699;
            string ProductName3 = "spel";
            var prod3 = register.RegisterProduct(ProductName3, Price3);

            int age;

            Console.Clear();
            Console.WriteLine("Enter name of the customer.");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the age of the customer.");
            int.TryParse(Console.ReadLine(), out age);

            Console.WriteLine("Enter the gender of the customer.");
            string gender = Console.ReadLine();
            

            Console.WriteLine("Do you want to buy a fruit(1), a movie(2) or a game(3)?");
            string answer = Console.ReadLine();

            if (answer == "1")
            {
                Console.WriteLine("You chose {0}", ProductName1);
                ChosenProductName = ProductName1;
                totalCost = Price1;
                Console.WriteLine("customer name: {0} , age: {1}, gender: {2}, product to buy: {3}, totalprice: {4}kr", name, age, gender, ChosenProductName, totalCost);

            }
            else if (answer == "2")
            {
                Console.WriteLine("You chose {0}", ProductName2);
                ChosenProductName = ProductName2;
                totalCost = Price2;
                Console.WriteLine("customer name: {0} , age: {1}, gender: {2}, product to buy: {3}, totalprice: {4}kr", name, age, gender, ChosenProductName, totalCost);

            }
            else if (answer == "3")
            {
                Console.WriteLine("You chose {0}", ProductName3);
                ChosenProductName = ProductName3;
                totalCost = Price3;
                Console.WriteLine("customer name: {0} , age: {1}, gender: {2}, product to buy: {3}, totalprice: {4}kr", name, age, gender, ChosenProductName, totalCost);

            }
            Console.ReadLine();
            MainMenu();
        }

    }



}
