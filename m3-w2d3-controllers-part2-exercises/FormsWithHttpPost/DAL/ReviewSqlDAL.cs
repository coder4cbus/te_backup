using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FormsWithHttpPost.Models;
using System.Data.SqlClient;

namespace FormsWithHttpPost.DAL
{
    public class ReviewSqlDAL : IReviewDAL
    {
        private string connectionString;

        private string sql_GetReviews = @"SELECT * FROM reviews";

        private string sql_InsertReview = @"INSERT INTO reviews VALUES (@username, @rating, @review_title, @review_text, @review_date)";


        public ReviewSqlDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }


        public List<Review> GetAllReviews()
        {
            List<Review> reviews = new List<Review>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = sql_GetReviews;
                    cmd.Connection = conn;

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Review review = MapReviewFromReader(reader);
                        reviews.Add(review);
                    }

                }
            }
            catch (SqlException ex)
            {
                throw;
            }

            return reviews;
        }

        public bool SaveReview(Review newReview)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(sql_InsertReview, conn);
                    
                    cmd.Parameters.AddWithValue("@username", newReview.Username);
                    cmd.Parameters.AddWithValue("@rating", newReview.Rating);
                    cmd.Parameters.AddWithValue("@review_date", DateTime.UtcNow);
                    cmd.Parameters.AddWithValue("@review_title", newReview.Title);
                    cmd.Parameters.AddWithValue("@review_text", newReview.Message);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (SqlException ex)
            {
                // Error Logging that a problem occurred, don't show the user
                throw;
            }
        }
        private Review MapReviewFromReader(SqlDataReader reader)
        {
            return new Review()
            {
                Id = Convert.ToInt32(reader["review_id"]),
                Username = Convert.ToString(reader["username"]),
                Rating = Convert.ToInt32(reader["rating"]),
                ReviewDate = Convert.ToDateTime(reader["review_date"]),
                Title = Convert.ToString(reader["review_title"]),
                Message = Convert.ToString(reader["review_text"]),
            };

        }
    }
}