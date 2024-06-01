using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using newproject.entity;

namespace newproject.entity
{
    public class Product : Entity<Product>
    {
        public int Product_id { get; set; }
        public string Product_name { get; set; }   
        public string Description { get; set; }
        public decimal Price { get; set;}

        // Constructor mặc định
        public Product() { }

        // Constructor có tham số
        public Product(int product_id, string product_name, string description, decimal price)
        {
            Product_id = product_id;
            Product_name = product_name;
            Description = description;
            Price = price;
        }
        public Product(string product_name, string description, decimal price){
            Product_name = product_name;
            Description = description;
            Price = price;
        }
        // Constructor thừa kế từ constructor của lớp cha Entity<int>

        // Override phương thức ToString để hiển thị thông tin của đối tượng
        public override string ToString()
        {
            return $"Product ID: {Product_id}, Name: {Product_name}, Description: {Description}, Price: {Price:C}";
        }
    }
}