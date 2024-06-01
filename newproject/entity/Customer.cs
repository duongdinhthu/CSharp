using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace newproject.entity
{
    public class Customer : Entity<Customer> {
        public int Customer_id { get; set; } 
        public string First_name { get; set; } 
        public string Last_name { get; set; } 
        public string Email { get; set; }
        public int Phone { get; set; }
        
        public Customer() { }

        public Customer(string first_name, string last_name, string email, int phone)
        {
            First_name = first_name;
            Last_name = last_name;
            Email = email;
            Phone = phone;
        }

        public Customer(int customer_id, string first_name, string last_name, string email, int phone)
        
        {
            Customer_id = customer_id;
            First_name = first_name;
            Last_name = last_name;
            Email = email;
            Phone = phone;
        }

        public override string ToString()
        {
            return $"Customer{{customer_id={Customer_id}, first_name='{First_name}', last_name='{Last_name}', email='{Email}', phone={Phone}}}";
        }
    }
}