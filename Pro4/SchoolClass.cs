using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pro4
{
    public class SchoolClass
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Class Id: {Id}, Name: {Name}";
        }
    }
}