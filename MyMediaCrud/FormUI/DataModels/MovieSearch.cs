using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{
    // This Class holds information from SearchMoviesControl
    // It will then be passed to DataAccess for a SQL query
    // This Class will be deleted when Movies can do the same thing

    public class MovieSearch
    {

        public string Title { get; set; }

        public int? Year { get; set; }

        public TimeSpan? Runtime { get; set; }

        public string ActorFirstName { get; set; }

        public string ActorLastName { get; set; }

        public string DirectorFirstName { get; set; }

        public string DirectorLastName { get; set; }
    }
}
