using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using newproject.model;
using newproject.controller;
using newproject.entity;
namespace newproject.view
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
            public void Test(){
                while(true){
                Console.WriteLine("Product Management");
                Console.WriteLine("1. Add product");
                Console.WriteLine("2. Add Customer");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Choose an option: ");
                string choice = Console.ReadLine();

                switch(choice){
                    case "1": AddProduct();
                        break;
                    case "2":AddCustomer();
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
                string Product_name = Console.ReadLine();
                Console.WriteLine("Enter product price: ");
                decimal Price = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter description: ");
                string Description = Console.ReadLine();
                Product product = new Product(Product_name,Description,Price);

                productController.Insert(product);
            }
            public void AddCustomer(){
                
                Console.WriteLine("Enter Customer first_name: ");
                string Fname = Console.ReadLine();
                Console.WriteLine("Enter customer last name: ");
                string Lname = Console.ReadLine();
                Console.WriteLine("Enter email: ");
                string Email = Console.ReadLine();
                Console.WriteLine("Enter phone: ");
                int Phone = Convert.ToInt32(Console.ReadLine());
                Customer customer = new Customer(Fname,Lname,Email,Phone);

                customerController.Insert(customer);
            }
    }
}