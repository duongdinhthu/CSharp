using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using newproject.mvc.entity;
using newproject.mvc.model;
using newproject.mvc.controller;
namespace newproject.mvc.view
{
    public class View
    {
        private static Model<Customer> customerModel = new Model<Customer>();
        private static Model<Product> productModel = new Model<Product>();
        private static Model<Orders> ordersModel = new Model<Orders>();
        private static Model<Orderdetail> orderdetailModel = new Model<Orderdetail>();
        private Controller<Customer> customerController = new Controller<Customer>(customerModel);
        private Controller<Product> productController = new Controller<Product>(productModel);
        private Controller<Orders> ordersController = new Controller<Orders>(ordersModel);
        private Controller<Orderdetail> orderdetailController = new Controller<Orderdetail>(orderdetailModel);
        public void Test()
        {
            while (true)
            {
                Console.WriteLine("Product Management");
                Console.WriteLine("1. Add product");
                Console.WriteLine("2. Add Customer");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        MenuProduct();
                        break;
                    case "2":
                        AddCustomer();
                        break;
                    default:
                        Console.WriteLine("Invalid choice, pls try again");
                        break;
                }
            }
        }
        public void MenuProduct()
        {
            while (true)
            {
                Console.WriteLine("Product Management");
                Console.WriteLine("1. Add product");
                Console.WriteLine("2. Update product");
                Console.WriteLine("3. Get All product");
                Console.WriteLine("4. Delete product");
                Console.WriteLine("5. Get Product By Id");
                Console.WriteLine("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddProduct();
                        break;
                    case "2":
                        UpdateProduct();
                        break;
                    default:
                        Console.WriteLine("Invalid choice, pls try again");
                        break;
                }
            }
        }
        public void AddProduct()
        {
            Console.WriteLine("Enter product name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter product price: ");
            decimal price = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter description: ");
            string description = Console.ReadLine();
            Product product = new Product { Product_name = name, Description = description, Price = price };

            productController.Insert(product);
        }
        public void UpdateProduct()
        {
            Console.WriteLine("Enter product Id update: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter product name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter product price: ");
            decimal price = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter description: ");
            string description = Console.ReadLine();
            Product product = new Product { Product_id = id, Product_name = name, Description = description, Price = price };
            productController.Update(product);
        }
        public void AddCustomer()
        {

            Console.WriteLine("Enter Customer first_name: ");
            string Fname = Console.ReadLine();
            Console.WriteLine("Enter customer last name: ");
            string Lname = Console.ReadLine();
            Console.WriteLine("Enter email: ");
            string Email = Console.ReadLine();
            Console.WriteLine("Enter phone: ");
            int Phone = Convert.ToInt32(Console.ReadLine());
            Customer customer = new Customer { First_name = Fname, Last_name = Lname, Email = Email, Phone = Phone };

            customerController.Insert(customer);
        }
        public void UpdateCustomer()
        {
            Console.WriteLine("Enter Customer id: ");
            int Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Customer first_name: ");
            string Fname = Console.ReadLine();
            Console.WriteLine("Enter customer last name: ");
            string Lname = Console.ReadLine();
            Console.WriteLine("Enter email: ");
            string Email = Console.ReadLine();
            Console.WriteLine("Enter phone: ");
            int Phone = Convert.ToInt32(Console.ReadLine());
            Customer customer = new Customer { Customer_id = Id, First_name = Fname, Last_name = Lname, Email = Email, Phone = Phone };
            customerController.Update(customer);
        }
    }
}