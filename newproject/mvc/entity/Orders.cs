using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace newproject.mvc.entity
{
    public class Orders : Entity<Orders>
    {
        public int Order_id { get; set; }
        public int Customer_id { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Total { get; set; }

       
        public override string ToString() => $"Orders{{order_id={Order_id}, customer_id={Customer_id}, orderDate={OrderDate}, total={Total}}}";
    }
}
