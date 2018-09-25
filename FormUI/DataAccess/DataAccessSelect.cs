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

        public List<Movie> GetMovies()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnValue("MyMediaDB")))
            {
                var output = connection.Query<Movie>("dbo.spSelect_All_Movies").ToList();
                return output;
            }
        }

        public List<Movie> GetMovieByDirector(string firstName, string lastName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnValue("MyMediaDB")))
            {
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

                
                return output;
            }
        }

        public  List<Movie> GetMovieByActor(string firstName, string lastName)
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
    }
}
