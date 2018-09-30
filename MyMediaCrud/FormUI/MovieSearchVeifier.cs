using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace FormUI
{
    public static class MovieSearchVerifier
    {
        public static void IsRuntimeCorrectFormat(string timeSpan)
        {
            //This Regex format is 0:00, 00:00, or 00:00:00
            Regex timeSpanFormat = new Regex(@"(^\d{1,2})(\:\d{2}){1,2}|^$");

            if (!timeSpanFormat.IsMatch(timeSpan))
            {
                throw new IncorrectMovieRuntimeFormat();
            }
        }
        public static void IsYearCorrectFormat(string year)
        {
            Regex yearFormat = new Regex(@"(^\d{4}$)");

            if (!yearFormat.IsMatch(year))
            {
                throw new IncorrectMovieYearFormat();
            }
        }
    }
}
