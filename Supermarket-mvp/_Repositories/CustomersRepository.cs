using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using Supermarket_mvp.Models;
using System.Data;
using Supermarket_mvp.Repositories;

namespace Supermarket_mvp._Repositories
{
    internal class CustomersRepository : BaseRepository, ICustomersRepostory
    {
        public CustomersRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(CustomersModel customersModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(CustomersModel customersModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CustomersModel> GetAll()
        {
            var customersList = new List<CustomersModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM customers ORDER BY Customers_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var customersModel = new CustomersModel();
                        customersModel.Id = (int)reader["Customers_Id"];
                        customersModel.document_number = reader["Customers_Document_number"].ToString();
                        customersModel.firts_name = reader["Customers_first_name"].ToString();
                        customersModel.last_name = reader["Customers_last_name"].ToString();
                        customersModel.address = reader["Customers_address"].ToString();
                        customersModel.birthday = reader["Customers_birthday"] != DBNull.Value ? (DateTime)reader["Customers_Birthday"] : (DateTime?)null;
                        customersModel.phone_numbers = reader["Customers_phone_numbers"].ToString();
                        customersModel.email = reader["Customers_email"].ToString();
                        customersList.Add(customersModel);
                    }
                }
            }
            return customersList;
        }

        public IEnumerable<CustomersModel> GetByValue(string value)
        {
            var customersList = new List<CustomersModel>();
            int customersId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string customersName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Customers WHERE Customers_Id=@id or Customers_Firts_Name LIKE @name+ '%'
                                      ORDER by Customers_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = customersId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = customersName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var customers = new CustomersModel();
                        customers.Id = (int)reader["Customers_Id"];
                        customers.document_number = reader["Customers_Document"].ToString();
                        customers.firts_name = reader["Customers_Firts_Name"].ToString();
                        customers.last_name = reader["Customers_Last_Name"].ToString();
                        customers.address = reader["Customers_Addres"].ToString();
                        customers.birthday = reader["Customers_Birthday"] != DBNull.Value ? (DateTime)reader["Customers_Birthday"] : (DateTime?)null;
                        customers.phone_numbers = reader["Customers_Phone_Numbers"].ToString();
                        customers.email = reader["Customers_Email"].ToString();
                        customersList.Add(customers);
                    }
                }
            }
            return customersList;
        }
    }
    }


