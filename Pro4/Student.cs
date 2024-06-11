using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pro4
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
           return $"Student Id: {Id}, Name: {Name}";
        }
    }
}