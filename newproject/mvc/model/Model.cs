using System.Reflection.Metadata;
using System;
using MySql.Data.MySqlClient;
using System.Reflection;
using newproject.mvc.entity;
using System.Text;
using newproject.mvc.connection;
namespace newproject.mvc.model
{
    class Model<T> : ModelDAO<T> where T : Entity<T>
    {
        private List<T> entities = new List<T>();
        private static MySqlConnection connection;
        static string connectionString ="Server=127.0.0.1;Database=ordermanager;User Id=root;Password=;";
        public static MySqlConnection OpenConnection()
        {
            Connection.ConnectionDTB();
            return connection;
        }

        private static string GetTableName(Type entityClass) => entityClass.Name;
        private static string QueryUpdate(T entity)
        {
            Type entityClass = typeof(T);
            string tableName = GetTableName(entityClass);
            StringBuilder query = new StringBuilder($"update {tableName} set ");
            PropertyInfo[] propertyInfos = entityClass.GetProperties();
            List<string> columns = new List<string>();
            List<string> parameters = new List<string>();
            string idColumn = ""; // Lưu tên cột ID
            
            foreach (var propertyInfo in propertyInfos)
            {
                object value = propertyInfo.GetValue(entity);
                
                if (value != null)
                {
                    if (propertyInfo.Name != "Id" && propertyInfo.Name != "Customer_id") // Bỏ qua Customer_id
                    {
                        columns.Add(propertyInfo.Name);
                        parameters.Add($"@{propertyInfo.Name}");
                    }
                    else
                    {
                        idColumn = propertyInfo.Name == "Id" ? "Id" : propertyInfo.Name;
                    }
                }
            }
            
            string setValues = string.Join(", ", columns.Select(c => $"{c} = @{c}"));
            
            query.Append(setValues);
            query.Append(" ");
            
            if (!string.IsNullOrEmpty(idColumn))
            {
                query.Append($"where {idColumn} = @Id");
            }

            return query.ToString();
        }
       private static string QueryInsert(Entity<T> entity)
        {
            Type entityClass = entity.GetType();
            string tableName = GetTableName(entityClass);
            StringBuilder query = new StringBuilder($"INSERT INTO {tableName} (");
            PropertyInfo[] propertyInfos = entityClass.GetProperties();
            List<string> columns = new List<string>();
            List<string> parameters = new List<string>();
            
            foreach (var propertyInfo in propertyInfos)
            {
                object value = propertyInfo.GetValue(entity);
                
                if (value != null)
                {
                    columns.Add(propertyInfo.Name);
                    parameters.Add($"@{propertyInfo.Name}");
                }
            }

            query.Append(string.Join(", ", columns));
            query.Append(") VALUES (");
            query.Append(string.Join(", ", parameters));
            query.Append(")");            
            return query.ToString();
        }

        public int Insert(T entity)
        {
            int rowsAffected = 0;
            
            using (MySqlConnection db = new MySqlConnection(connectionString))
            {
                db.Open();
                
                PropertyInfo[] propertyInfos = typeof(T).GetProperties();
                
                string query = QueryInsert(entity);
                
                using (MySqlCommand cmd = new MySqlCommand(query, db))
                {
                    foreach (var propertyInfo in propertyInfos)
                    {
                        object value = propertyInfo.GetValue(entity);
                        if (value != null)
                        {
                            cmd.Parameters.AddWithValue("@" + propertyInfo.Name, value);

                        }
                    }

                    rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine("add Success!");
                }
                
                db.Close();
            }

            if (rowsAffected > 0)
            {
                return rowsAffected;
            }
            else
            {
                throw new Exception("Creating record failed, no rows affected.");
            }
        }

        public void InsertAll(List<T> entities)
        {
            foreach (var entity in entities)
            {
                Insert(entity);
            }
        }
        
        public bool Update(T entity)
{
    int rowsAffected = 0;
    
    using (MySqlConnection db = new MySqlConnection(connectionString))
    {
        db.Open();
        
        PropertyInfo[] propertyInfos = typeof(T).GetProperties();
        
        string query = QueryUpdate(entity); // Thêm cột Id vào hàm QueryUpdate
        Console.WriteLine(query);
        
        using (MySqlCommand cmd = new MySqlCommand(query, db))
        {
            foreach (var propertyInfo in propertyInfos)
            {
                object value = propertyInfo.GetValue(entity);
                if (value != null)
                {
                    cmd.Parameters.AddWithValue("@" + propertyInfo.Name, value);
                }
            }
            
            // Lấy giá trị của Id
            PropertyInfo idProperty = typeof(T).GetProperty("Customer_id");
            object idValue = idProperty.GetValue(entity);
            cmd.Parameters.AddWithValue("@Id", idValue);

            rowsAffected = cmd.ExecuteNonQuery();
            Console.WriteLine("Update Success!");
        }
        
        db.Close();
    }
    
    return rowsAffected > 0;
}

        public bool Delete(T entity)
        {
            // Implement logic for deleting entity
            return true; // Placeholder return value
        }

        public List<T> GetEntityById(T entity)
        {
            // Implement logic for getting entity by ID
            return new List<T>(); // Placeholder return value
        }

        public List<T> GetAll(Type entityClass)
        {
            // Implement logic for getting all entities of specified type
            return new List<T>(); // Placeholder return value
        }
    }
}