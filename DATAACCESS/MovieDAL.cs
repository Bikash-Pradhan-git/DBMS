using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.DATAACCESS
{
    public class MovieDAL
    {
        
        public void show()
        {

            //System.Diagnostics.Debug.WriteLine(mv.Id);
            string queryString = "SELECT Id, Title,Description,Genre,Duration,ReleaseDate FROM dbo.Movies;";

            using (SqlConnection connection = new SqlConnection("data source=BFL-COMP-7472\\SQLEXPRESS;database=MovieBooking;Trusted_Connection=True"))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    // get the results of each column
                    int id = (int)reader["Id"];

                    string Title = reader["Title"].ToString();

                    string Description = reader["Description"].ToString();

                    string Genre = reader["Genre"].ToString();

                    int Duration = (int)reader["Duration"];

                    DateTime ReleaseDate =(DateTime)reader["Duration"];


                    
                }
            }
        }
    }
}