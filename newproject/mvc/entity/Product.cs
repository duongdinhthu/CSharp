using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using newproject.mvc.entity;

namespace newproject.mvc.entity
{
    public class Product : Entity<Product>
    {
        public int Product_id { get; set; }
        public string Product_name { get; set; }   
        public string Description { get; set; }
        public decimal Price { get; set;}

        // Constructor mặc định

        // Constructor thừa kế từ constructor của lớp cha Entity<int>

        // Override phương thức ToString để hiển thị thông tin của đối tượng
        public override string ToString()
        {
            return $"Product ID: {Product_id}, Name: {Product_name}, Description: {Description}, Price: {Price:C}";
        }
    }
}