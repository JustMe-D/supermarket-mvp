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
    internal class CustomerRepository : BaseRepository, ICustomerRepository
    {
        public CustomerRepository(string connectionString) 
        {
            this.connectionString = connectionString;
        }
        public void Add(CustomerModel customerModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(CustomerModel customerModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CustomerModel> GetAll()
        {
            var customerList = new List<CustomerModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Customer ORDER BY Customer_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var customerModel = new CustomerModel();
                        customerModel.Id = (int)reader["Customer_Id"];
                        customerModel.DocumentNumber = reader["Customer_Document"].ToString();
                        customerModel.FirstName = reader["Customer_FirstName"].ToString();
                        customerModel.LastName = reader["Customer_LastName"].ToString();
                        customerModel.Address = reader["Customer_Address"].ToString();
                        customerModel.Birthday = reader["Customer_Birthday"] as DateTime?;
                        customerModel.PhoneNumber = reader["Customer_PhoneNumber"].ToString();
                        customerModel.Email = reader["Customer_Email"].ToString();

                        customerList.Add(customerModel);
                    }
                }
            }
            return customerList;
        }

        public IEnumerable<CustomerModel> GetByValue(string value)
        {
            var customersList = new List<CustomerModel>();
            int customerId = int.TryParse(value, out _)? Convert.ToInt32(value): 0;
            string customerName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Customer 
                                        WHERE Customer_Id = @id OR 
                                        Customer_FirstName LIKE @name+ '%' OR 
                                        Customer_LastName LIKE @name+ '%'
                                        ORDER BY Customer_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = customerId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = customerName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var customerModel = new CustomerModel();
                        customerModel.Id = (int)reader["Customer_Id"];
                        customerModel.DocumentNumber = reader["Customer_Document"].ToString();
                        customerModel.FirstName = reader["Customer_FirstName"].ToString();
                        customerModel.LastName = reader["Customer_LastName"].ToString();
                        customerModel.Address = reader["Customer_Address"].ToString();
                        customerModel.Birthday = reader["Customer_Birthday"] as DateTime?;
                        customerModel.PhoneNumber = reader["Customer_PhoneNumber"].ToString();
                        customerModel.Email = reader["Customer_Email"].ToString();
                        customersList.Add(customerModel);
                    }
                }
            }
             return customersList;
        }

    }
}
