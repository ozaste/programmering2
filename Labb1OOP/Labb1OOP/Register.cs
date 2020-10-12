using System;
using System.Collections.Generic;
using System.Text;

namespace Labb1OOP
{
        public class Register
    {
        public List<Product> Product { get; }
        public List<Customer> Customer { get; }
        //Constructor
        public Register()
        {
            Customer = new List<Customer>();
            Product = new List<Product>();
        }
        public Customer RegisterCustomer(string name, int age, string gender)
        {
            Customer customer = new Customer(name, age, gender);
            Customer.Add(customer);

            return customer;
        }
        public Product RegisterProduct(string productName, int price)
        {
            Product product = new Product(productName, price);
            Product.Add(product);

            return product;
        }
    }
}
