﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{
    public class IncorrectMovieRuntimeFormat : FormatException
    {
        public IncorrectMovieRuntimeFormat() 
            : base("Incorrect Runtime Format: \nCorrect Format: HH:MM:SS")
        {
        }

        public IncorrectMovieRuntimeFormat(string message) 
            : base("Incorrect Runtime Format: \nCorrect Format: HH:MM:SS")
        { 
        }
    }
}
