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
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO Customer (Customer_Document, Customer_FirstName, Customer_LastName, 
                                        Customer_Address, Customer_Birthday, Customer_PhoneNumber, Customer_Email) 
                                        VALUES (@document, @firstName, @lastName, @address, @birthday, @phoneNumber, @email)";
                command.Parameters.Add("@document", SqlDbType.NVarChar).Value = customerModel.DocumentNumber;
                command.Parameters.Add("@firstName", SqlDbType.NVarChar).Value = customerModel.FirstName;
                command.Parameters.Add("@lastName", SqlDbType.NVarChar).Value = customerModel.LastName;
                command.Parameters.Add("@address", SqlDbType.NVarChar).Value = customerModel.Address;
                command.Parameters.Add("@birthday", SqlDbType.DateTime).Value = customerModel.Birthday;
                command.Parameters.Add("@phoneNumber", SqlDbType.NVarChar).Value = customerModel.PhoneNumber;
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = customerModel.Email;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Customer WHERE Customer_Id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(CustomerModel customerModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Customer SET 
                                        Customer_FirstName = @firstName,
                                        Customer_LastName = @lastName, 
                                        Customer_Address = @address, 
                                        Customer_Birthday = @birthday, 
                                        Customer_PhoneNumber = @phoneNumber, 
                                        Customer_Email = @email 
                                        WHERE Customer_Id = @id";
                command.Parameters.Add("@firstName", SqlDbType.NVarChar).Value = customerModel.FirstName;
                command.Parameters.Add("@lastName", SqlDbType.NVarChar).Value = customerModel.LastName;
                command.Parameters.Add("@address", SqlDbType.NVarChar).Value = customerModel.Address;
                command.Parameters.Add("@birthday", SqlDbType.DateTime).Value = customerModel.Birthday;
                command.Parameters.Add("@phoneNumber", SqlDbType.NVarChar).Value = customerModel.PhoneNumber;
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = customerModel.Email;
                command.Parameters.Add("@id", SqlDbType.Int).Value = customerModel.Id;

                command.ExecuteNonQuery();
            }

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
                        customerModel.DocumentNumber = reader["Customer_Document"].ToString().Trim();
                        customerModel.FirstName = reader["Customer_FirstName"].ToString().Trim();
                        customerModel.LastName = reader["Customer_LastName"].ToString().Trim();
                        customerModel.Address = reader["Customer_Address"].ToString().Trim();
                        customerModel.Birthday = reader["Customer_Birthday"] as DateTime?;
                        customerModel.PhoneNumber = reader["Customer_PhoneNumber"].ToString().Trim();
                        customerModel.Email = reader["Customer_Email"].ToString().Trim();

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
                        customerModel.DocumentNumber = reader["Customer_Document"].ToString().Trim();
                        customerModel.FirstName = reader["Customer_FirstName"].ToString().Trim();
                        customerModel.LastName = reader["Customer_LastName"].ToString().Trim();
                        customerModel.Address = reader["Customer_Address"].ToString().Trim();
                        customerModel.Birthday = reader["Customer_Birthday"] as DateTime?;
                        customerModel.PhoneNumber = reader["Customer_PhoneNumber"].ToString().Trim();
                        customerModel.Email = reader["Customer_Email"].ToString().Trim();
                        customersList.Add(customerModel);
                    }
                }
            }
             return customersList;
        }

    }
}
