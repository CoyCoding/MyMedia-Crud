using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace FormUI
{
    public class DataAccessSelect
    {

        public List<Movie> GetAllMovies()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnValue("MyMediaDB")))
            {
                var output = connection.Query<Movie>("dbo.spSelect_All_Movies").ToList();
                return output;
            }
        }

        public List<Movie> GetMovieByDirector(string firstName, string lastName)
        {
            if (firstName == null && lastName == null ||
                firstName == "" && lastName == "")
            {
                throw new Exception();
            }
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnValue("MyMediaDB")))
            {
                return connection.Query<Movie>("dbo.spSearch_By_Director @FirstName, @LastName",
                        new { FirstName = firstName, LastName = lastName }).ToList();



                //This is old code with 3 seperate stored procedures cleaner with one but unsure where the logic should go 

                /*
                List<Movie> output = null;
                if (firstName != "" && lastName != "")
                {
                    output = connection.Query<Movie>("dbo.spSearch_By_Director @FirstName, @LastName",
                        new { FirstName = firstName, LastName = lastName }).ToList();
                }
                else if (firstName == "" && lastName != "")
                {
                    output = connection.Query<Movie>("dbo.spSearch_By_Director_LastName  @LastName",
                        new { LastName = lastName }).ToList();
                }
                else if (firstName != "" && lastName == "")
                {
                    output = connection.Query<Movie>("dbo.spSearch_By_Director_FirstName @FirstName",
                      new { FirstName = firstName }).ToList();
                }
                else
                {
                    throw new Exception();
                }
                return output;\
                */
            }
        }

        public List<Movie> GetMovieByActor(string firstName, string lastName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnValue("MyMediaDB")))
            {
                List<Movie> output = null;
                if (firstName != "" && lastName != "")
                {
                    output = connection.Query<Movie>("dbo.spSearch_By_Actor @FirstName, @LastName",
                        new { FirstName = firstName, LastName = lastName }).ToList();
                }
                else if (firstName == "" && lastName != "")
                {
                    output = connection.Query<Movie>("dbo.spSearch_By_Actor_LastName  @LastName",
                        new { LastName = lastName }).ToList();
                }
                else if (firstName != "" && lastName == "")
                {
                    output = connection.Query<Movie>("dbo.spSearch_By_Actor_FirstName @FirstName",
                      new { FirstName = firstName }).ToList();
                }
                else
                {
                    throw new Exception();

                }


                return output;
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
    }
}
