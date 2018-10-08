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
        #region DataAccess Movies

        public List<Movie> GetAllMovies()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnValue("MyMediaDB")))
            {
                var output = connection.Query<Movie>("dbo.spSelect_All_Movies");
                return output.ToList();
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

        public void AddMovieWithDirector(Movie movie)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnValue("MyMediaDB")))
            {
                connection.Query<Movie>("dbo.spAdd_Movie @Title, " +
                                                        "@Runtime, " +
                                                        "@Year, " +
                                                        "@FirstName," +
                                                        "@LastName",
                         new
                         {
                             movie.Title,
                             movie.Runtime,
                             movie.Year,
                             movie.Director.FirstName,
                             movie.Director.LastName

                         });
            }
        }

        public void AddMovie(Movie movie)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnValue("MyMediaDB")))
            {
                connection.Query<Movie>("dbo.spCreate_New_Movie @Title, " +
                                                               "@Runtime, " +
                                                               "@Year", 

                         new
                         {
                             movie.Title,
                             movie.Runtime,
                             movie.Year
                         });
            }
        }

        public void DeleteMovie(Movie movie)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnValue("MyMediaDB")))
            {
                connection.Query<Movie>("dbo.spDelete_Movie_And_FK @id",
                    new
                    {
                        movie.id
                    });
            }
        }

        #endregion

        #region DataAccess Director

        public List<Director> GetDirectors()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnValue("MyMediaDB")))
            {
                var output = connection.Query<Director>("dbo.spSelect_All_Directors").ToList();
                return output;
            }
        }

        public List<Director> SearchDirectors(Director director)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnValue("MyMediaDB")))
            {
                return connection.Query<Director>("dbo.spSearch_By_Director @FirstName, @LastName",
                         new
                         {
                             director.FirstName,
                             director.LastName
                         }).ToList();
            }
        }

        public void UpdateDirector(Director director)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnValue("MyMediaDB")))
            {
                connection.Query<Director>("dbo.spUpdate_Director @id, " +
                                                              "@FirstName," +
                                                              "@LastName",
                         new
                         {
                             director.id,
                             director.FirstName,
                             director.LastName

                         });
            }
        }

        public void AddDirector(Director director)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnValue("MyMediaDB")))
            {
                connection.Query<Director>("dbo.spAdd_Director @FirstName, " +
                                                              "@LastName",
                         new
                         {
                             director.FirstName,
                             director.LastName
                         });
            }
        }

        public void DeleteDirector(Director director){
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnValue("MyMediaDB")))
            {
                connection.Query<Director>("dbo.spDelete_Director_And_FK @id",
                    new
                    {
                        director.id
                    });
            }
        }

        #endregion
    }
}
