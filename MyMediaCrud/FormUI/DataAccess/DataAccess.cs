﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace FormUI
{
    public class DataAccess
    {

        public List<Movie> GetAllMovies()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnValue("MyMediaDB")))
            {
                var output = connection.Query<Movie>("dbo.spSelect_All_Movies");
                return output.ToList();
            }
        }

        public List<Director> GetDirectors()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnValue("MyMediaDB")))
            {
                var output = connection.Query<Director>("dbo.spSelect_All_Directors").ToList();
                return output;
            }
        }

        public List<Movie> SearchMovies(MovieSearch movieSearch)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnValue("MyMediaDB")))
            {
                return connection.Query<Movie>("dbo.spSearch_Movies_By_All @Title, " +
                                                                        "@Runtime, " +
                                                                        "@Year, " +
                                                                        "@ActorFirstName, " +
                                                                        "@ActorLastName, " +
                                                                        "@DirectorFirstName," +
                                                                        "@DirectorLastName",
                         new
                         {
                             movieSearch.Title,
                             movieSearch.Runtime,
                             movieSearch.Year,
                             movieSearch.ActorFirstName,
                             movieSearch.ActorLastName,
                             movieSearch.DirectorFirstName,
                             movieSearch.DirectorLastName
                         }).ToList();
            }
        }

        public void UpdateMovie(Movie movie)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnValue("MyMediaDB")))
            {
                connection.Query<Movie>("dbo.spUpdate_Movie_Selected @Title, " +
                                                                   "@id, " +
                                                                   "@Runtime, " +
                                                                   "@Year, " +
                                                                   "@FirstName," +
                                                                   "@LastName",
                         new
                         {
                             movie.Title,
                             movie.id,
                             movie.Runtime,
                             movie.Year,
                             movie.Director.FirstName,
                             movie.Director.LastName

                         });
            }
        }
    }
}