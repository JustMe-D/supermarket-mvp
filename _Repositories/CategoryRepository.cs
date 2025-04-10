using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using Supermarket_mvp.Models;
using System.Data;

namespace Supermarket_mvp._Repositories
{
    internal class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public CategoryRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(CategoryModel categoryModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = connection.CreateCommand())
            {
                connection.Open();
                command.CommandText = "INSERT INTO Category VALUES (@name, @description)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = categoryModel.Name;
                command.Parameters.Add("@description", SqlDbType.NVarChar).Value = categoryModel.Description;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = connection.CreateCommand())
            {
                connection.Open();
                command.CommandText = "DELETE FROM Category WHERE Category_Id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }

        }
        public void Edit(CategoryModel categoryModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = connection.CreateCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Category SET Category_Name = @name,
                                        Category_Description = @description WHERE Category_Id = @id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = categoryModel.Name;
                command.Parameters.Add("@description", SqlDbType.NVarChar).Value = categoryModel.Description;
                command.Parameters.Add("@id", SqlDbType.Int).Value = categoryModel.Id;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<CategoryModel> GetAll()
        {
            var categoryList = new List<CategoryModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Category ORDER BY Category_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var categoryModel = new CategoryModel();
                        categoryModel.Id = (int)reader["Category_Id"];
                        categoryModel.Name = reader["Category_Name"].ToString();
                        categoryModel.Description = reader["Category_Description"].ToString();
                        categoryList.Add(categoryModel);
                    }
                }
            }

            return categoryList;
        }

        public IEnumerable<CategoryModel> GetByValue(string value)
        {
            var categoryList = new List<CategoryModel>();
            int categoryId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string categoryName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Category
                                        WHERE Category_Id = @id or Category_Name LIKE @name+ '%'
                                        ORDER BY Category_Id DESC"; 
                command.Parameters.Add("@id", SqlDbType.Int).Value = categoryId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = categoryName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var categoryModel = new CategoryModel();
                        categoryModel.Id = (int)reader["Category_Id"];
                        categoryModel.Name = reader["Category_Name"].ToString();
                        categoryModel.Description = reader["Category_Description"].ToString();
                        categoryList.Add(categoryModel);
                    }
                }
            }
            return categoryList;
        }



    }
}
