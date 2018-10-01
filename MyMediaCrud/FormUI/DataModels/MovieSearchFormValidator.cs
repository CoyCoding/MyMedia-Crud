using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace FormUI
{
    public static class MovieSearchFormValidator
    {
        public static bool IsValidMovieRuntime(string timeSpan)
        {
            if (!IsDefaultRuntimeValue(timeSpan))
            {
                IsRuntimeCorrectFormat(timeSpan);
                return true;
            }
            return false;
        }

        public static bool IsDefaultRuntimeValue(string timeSpan)
        {
            if ((timeSpan == "" || timeSpan == "HH:mm"))
            {
                return true;
            }
            return false;
        }

        private static void IsRuntimeCorrectFormat(string timeSpan)
        {
            Regex timeSpanFormat = new Regex(@"(^\d{1,2})(\:\d{2}){1,2}|^$");

            if (!timeSpanFormat.IsMatch(timeSpan))
            {
                throw new IncorrectMovieRuntimeFormat();
            }
        }

        public static bool IsValidMovieYear(string year)
        {
            if (!IsDefaultYearValue(year))
            {
                IsYearCorrectFormat(year);
                return true;
            }
            return false;
        }   

        public static bool IsDefaultYearValue(string year)
        {
            if ((year == "" || year == "YYYY"))
            {
                return true;
            }
            return false;
        }

        private static void IsYearCorrectFormat(string year)
        {
                Regex yearFormat = new Regex(@"(^\d{4}$)");

                if (!yearFormat.IsMatch(year))
                {
                    throw new IncorrectMovieYearFormat();
                }
        }
        
    }
}
