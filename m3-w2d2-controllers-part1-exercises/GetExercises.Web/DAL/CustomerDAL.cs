using GetExercises.Web.DAL.Interfaces;
using GetExercises.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GetExercises.Web.DAL
{
    public class CustomerDAL : ICustomerDAL
    {
        private string connectionString;

        private string sql_lastName = @"SELECT * FROM customer c WHERE c.last_name Like @name 
OR c.first_name Like @name ORDER By c.last_name";

        private string sql_email = @"SELECT * FROM customer c WHERE c.last_name Like @name 
OR c.first_name Like @name ORDER By c.email";

        private string sql_active = @"SELECT * FROM customer c WHERE c.last_name Like @name 
OR c.first_name Like @name ORDER By c.active";


        public CustomerDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IList<Customer> SearchForCustomers(string name, string sortBy)
        {
            IList<Customer> customers = new List<Customer>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string stringSql = " ";

                    if ((!string.IsNullOrWhiteSpace(name)) && (!string.IsNullOrWhiteSpace(sortBy)))
                    {
                        if (sortBy == "name")
                        {
                            stringSql = sql_lastName;
                        }
                        else if (sortBy == "email")
                        {
                            stringSql = sql_email;
                        }
                        else if (sortBy == "active")
                        {
                            stringSql = sql_active;
                        }

                        SqlCommand cmd = new SqlCommand(stringSql);
                        cmd.Connection = conn;

                        cmd.Parameters.AddWithValue("@name", "%" + name + "%");
                        cmd.Parameters.AddWithValue("@sortBy", sortBy);



                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {

                            customers.Add(MapCustomerFromReader(reader));
                        }

                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }

            return customers;
        }

        private Customer MapCustomerFromReader(SqlDataReader reader)
        {
            return new Customer()
            {
                FirstName = Convert.ToString(reader["first_name"]),
                LastName = Convert.ToString(reader["last_name"]),
                Email = Convert.ToString(reader["email"]),
                IsActive = Convert.ToBoolean(reader["activebool"])
            };
        }
    }
}