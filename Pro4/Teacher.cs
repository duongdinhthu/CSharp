using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pro4
{
    public class Teacher
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public override string ToString(){
            return $"Teacher Id: {Id}, Name: {Name}";
        }
    }
}