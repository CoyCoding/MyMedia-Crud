using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{
    // This Class holds information from SearchMoviesControl
    // It will then be passed to DataAccess for a SQL query

    public class MovieSearch
    {
        public MovieSearch(string title, int? year, TimeSpan? runtime, 
                           string actorFirstName, string actorLastName, string directorFirstName,  string directorLastName)
        {
            Title = title;
            Year = year;
            Runtime = runtime;
            ActorFirstName = actorFirstName;
            ActorLastName = actorLastName;
            DirectorFirstName = directorFirstName;
            DirectorLastName = directorLastName;    
        }

        public string Title { get; set; }

        public int? Year { get; set; }

        public TimeSpan? Runtime { get; set; }

        public string ActorFirstName { get; set; }

        public string ActorLastName { get; set; }

        public string DirectorFirstName { get; set; }

        public string DirectorLastName { get; set; }
    }
}
