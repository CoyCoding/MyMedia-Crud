﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{
    public class Movie
    {
        private Director _Director;

        public int? id { get; set; }

        public string Title { get; set; }

        public TimeSpan? Runtime { get; set; }
       
        public int? Year  { get; set; }
        
        public Director Director
        {
            get
            { if(_Director == null)
                {
                    _Director = new Director();
                }
                return _Director;
            }
            set { _Director = value; }
        }

        public List<Actor> Actors { get; set; }

        public override string ToString()
        {
            return $"{Title} {Runtime} {Year} {Director}";
        }

        public bool IsMovieInfoNull()
        {
            return (Title == "" && Runtime == null && Year == null);        
        }

        public bool IsDirectorInfoNull()
        {
            return Director.FirstName == null || Director.LastName == null;
        }
    }
}
