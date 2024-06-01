using System;
using System.Collections.Generic;

namespace newproject.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int Phone { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
