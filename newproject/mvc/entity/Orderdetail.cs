using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using newproject.entity;

namespace newproject.entity
{
    public class Orderdetail : Entity<Orderdetail>
    {
        public int OrderDetail_id { get; set; }
        public int Order_id { get; set; }
        public int Product_id { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public Orderdetail() { }
        public Orderdetail(int order_id, int product_id, int quantity, decimal unitPrice)
        {
            Order_id = order_id;
            Product_id = product_id;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }

        public Orderdetail(int product_id, int quantity, decimal unitPrice)
        {
            Product_id = product_id;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }

        public Orderdetail(int id, int orderDetail_id, int order_id, int product_id, int quantity, decimal unitPrice)
        {
            OrderDetail_id = orderDetail_id;
            Order_id = order_id;
            Product_id = product_id;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }
    }
}
