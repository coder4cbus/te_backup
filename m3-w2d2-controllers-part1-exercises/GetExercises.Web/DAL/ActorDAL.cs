using GetExercises.Web.DAL.Interfaces;
using GetExercises.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GetExercises.Web.DAL
{
    public class ActorDAL : IActorDAL
    {
        private string connectionString;
        private string sql_actors = @"SELECT first_name, last_name FROM actor a WHERE a.last_name LIKE @name ORDER BY a.last_name";

        public ActorDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IList<Actor> FindActors(string lastNameSearch)
        {
            IList<Actor> actors = new List<Actor>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                //conn.Open();
                //SqlCommand cmd = new SqlCommand(sql_actors);
                //cmd.Connection = conn;

                //cmd.Parameters.AddWithValue("@last_name", "%" + lastNameSearch + "%");
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT first_name, last_name FROM actor WHERE last_name LIKE @name ORDER BY last_name", conn);
                cmd.Parameters.AddWithValue("@name", "%" + lastNameSearch + "%");


                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    actors.Add(MapRowToActor(reader));
                }
            }

            return actors;
        }

        private Actor MapRowToActor(SqlDataReader reader)
        {
            return new Actor()
            {
                FirstName = Convert.ToString(reader["first_name"]),
                LastName = Convert.ToString(reader["last_name"])
            };
        }
    }
}