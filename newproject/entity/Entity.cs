using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace newproject.entity
{
    public class Entity<T> {
        public T Id { get; set; }
        public Entity(T id)
        {
            Id = id;
        }

        public Entity()
        {
        }
    }
}