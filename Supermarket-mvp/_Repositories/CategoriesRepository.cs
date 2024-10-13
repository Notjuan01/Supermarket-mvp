﻿using System;
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
    internal class CategoriesRepository : BaseRepository, ICategoriesRepository
    {
        public CategoriesRepository(string connectionString)
        { 
            this.connectionString = connectionString;
        }
        public void Add(CategoriesModel category, CategoriesModel categoriesModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Categories VALUES (@name, @decription)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = categoriesModel.Name;
                command.Parameters.Add("@descripcion", SqlDbType.NVarChar).Value = categoriesModel.Description;
                command.ExecuteNonQuery();
            }
        }

        public void Add(CategoriesModel category)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Caategories WHERE Categories_Id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(CategoriesModel category, CategoriesModel categoriesModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Categories SET Categories_Name = @name,
                                        Categories_Description = @Description
                                        WHERE Categories_Id = @Id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = categoriesModel.Name;
                command.Parameters.Add("@Description", SqlDbType.NVarChar).Value = categoriesModel.Description;
                command.Parameters.Add("@id", SqlDbType.Int).Value = categoriesModel.Id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(CategoriesModel category)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoriesModel> GetAll()
            {
                var categoriesList = new List<CategoriesModel>();
                using (var connection = new SqlConnection(connectionString))
                using (var command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Categories ORDER BY Categories_Id DESC";
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var categoriesModel = new CategoriesModel();
                            categoriesModel.Id = (int)reader["Categories_Id"];
                            categoriesModel.Name = reader["Categories_Name"].ToString();
                            categoriesModel.Description = reader["Categories_Observation"].ToString();
                            categoriesList.Add(categoriesModel);
                        }
                    }
                }
                return categoriesList;
            }

            public IEnumerable<CategoriesModel> GetByValue(string value)
        {
            var categoriesList = new List<CategoriesModel>();
            int categoriesId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string categoriesName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Categories WHERE Categories_Id=@id or Categories_Name LIKE @name+ '%'
                                      ORDER by Categories_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = categoriesId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = categoriesName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var categoriesModel = new CategoriesModel();
                        categoriesModel.Id = (int)reader["Categories_Id"];
                        categoriesModel.Name = reader["Caategories_Name"].ToString();
                        categoriesModel.Description = reader["Categories_"].ToString();
                        categoriesList.Add(categoriesModel);
                    }
                }
            }

            return categoriesList;
        }
    }
    }

