using System;
using System.Net.Http.Headers;
using MySql.Data.MySqlClient;
using mvcExample.controller;
using mvcExample.model;
using mvcExample.service;

namespace newproject.mvcExample.view{
    class View{
        static string connectionString ="Server=127.0.0.1;Database=ordermanager;User Id=root;Password=;";
        public void Start()
        {
            IProductService productService = new ProductService(connectionString);
            ProductController productController = new ProductController(productService);
            while(true){
                Console.WriteLine("Product Management");
                Console.WriteLine("1. Add product");
                Console.WriteLine("2. Display all products");
                Console.WriteLine("3. Find Product By ID");
                Console.WriteLine("4. Edit Product");
                Console.WriteLine("5. Delete Product");
                Console.WriteLine("6. Exit");
                Console.WriteLine("Choose an option: ");
                string choice = Console.ReadLine();

                switch(choice){
                    case "1": 
                        Console.WriteLine("Enter product name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Etner product price: ");
                        decimal price = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Enter product description: ");
                        string description = Console.ReadLine();
                        Product newProduct = new Product{Name = name, Price = price, Description = description};
                        productController.AddProduct(newProduct);
                        Console.WriteLine("Product added Successfully!!!!");
                        break;
                    case "2": 
                        break;
                    case "3": return;
                    default:
                        Console.WriteLine("Invalid choice, pls try again");
                        break;
                }
            }
        }
    }
}