﻿using GetExercises.Web.DAL.Interfaces;
using GetExercises.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GetExercises.Web.DAL
{
    public class FilmDAL : IFilmDAL
    {
        private string connectionString;

        public FilmDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IList<Film> GetFilmsBetween(string genre, int minLength, int maxLength)
        {
            IList<Film> films = new List<Film>();

            string filmSearchSql = @"SELECT * FROM film f
                JOIN film_category fc ON fc.film_id = f.film_id 
                JOIN category c ON c.category_id = fc.category_id
                WHERE c.name = @genre AND length BETWEEN @minLength AND @maxLength";

            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(filmSearchSql, conn);
                cmd.Parameters.AddWithValue("@genre", genre);
                cmd.Parameters.AddWithValue("@minLength", minLength);
                cmd.Parameters.AddWithValue("@maxLength", maxLength);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    films.Add(MapRowToFilm(reader));
                }
            }

            return films;
        }

        private Film MapRowToFilm(SqlDataReader reader)
        {
            return new Film()
            {
                Title = Convert.ToString(reader["title"]),
                Description = Convert.ToString(reader["description"]),
                ReleaseYear = Convert.ToInt32(reader["release_year"]),
                Length = Convert.ToInt32(reader["length"]),
                Rating = Convert.ToString(reader["rating"])
            };
        }
    }
}