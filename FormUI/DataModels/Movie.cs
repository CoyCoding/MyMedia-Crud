using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{
    public class Movie
    {
        public int id { get; set; }

        public string Title { get; set; }

        public TimeSpan Runtime { get; set; }
       
        public int Year { get; set; }     
        
        public string Info
        {
            get
            {
                return $"{ Title } { Runtime } { Year }";
            }
        }

    }
}
