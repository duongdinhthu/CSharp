using System;
using MySql.Data.MySqlClient;
using newproject.entity;
using newproject.model;
namespace newproject.controller
{
    class Controller<T> where T : Entity<T>
    {
        private Model<T> model = new Model<T>();

        public Controller(Model<T> model)
        {
            this.model = model;
        }

        public int Insert(T entity)
        {
            try
            {
                return model.Insert(entity);
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            
        }

        public void Update(T entity)
        {
            try
            {
                model.Update(entity);
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            
        }

        public void Delete(T entity)
        {
            try
            {
                model.Delete(entity);
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }

        public List<T> List(T entity)
        {
            try
            {
                List<T> list = model.GetAll(entity.GetType());
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<T> GetEntityById(T entity)
        {
            try
            {
                List<T> entityList = model.GetEntityById(entity);
                return entityList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void InsertAll(List<T> entities)
        {
            try
            {
                model.InsertAll(entities);
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            
        }
    }
}