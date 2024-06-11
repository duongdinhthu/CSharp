using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace newproject.mvc.entity
{
    public class Customer : Entity<Customer>
    {
        public int Customer_id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }



        public override string ToString()
        {
            return $"Customer{{customer_id={Customer_id}, first_name='{First_name}', last_name='{Last_name}', email='{Email}', phone={Phone}}}";
        }
    }
}