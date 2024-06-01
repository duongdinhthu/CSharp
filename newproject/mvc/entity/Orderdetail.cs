using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using newproject.mvc.entity;

namespace newproject.mvc.entity
{
    public class Orderdetail : Entity<Orderdetail>
    {
        public int OrderDetail_id { get; set; }
        public int Order_id { get; set; }
        public int Product_id { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

    }
}
