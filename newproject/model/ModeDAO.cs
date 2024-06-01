using System;
using System.Collections.Generic;
using newproject.entity;

namespace newproject.model
{    
    interface ModelDAO<T> where T : Entity<T>
    {
        int Insert(T entity);
        void InsertAll(List<T> entity);
        bool Update(T entity);
        bool Delete(T entity);
        List<T> GetEntityById(T entity);
        List<T> GetAll(Type entityClass);
    }
}