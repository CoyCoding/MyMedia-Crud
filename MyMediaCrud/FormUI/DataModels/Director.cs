using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace FormUI
{
    public class Director
    {
        public int id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public override string ToString()
        {
            return FirstName + ' ' + LastName;
        }

        public static implicit operator Director(string directorString)
        {
            Director converted = new Director();

            if (directorString != null)
            {
                IsValidDirectorString(directorString);
                var directorArr = directorString.Split(' ');
                converted.id = int.Parse(directorArr[0]);
                converted.FirstName = directorArr[1];
                converted.LastName = directorArr[2];
            }
            return converted;
        }

        private static void IsValidDirectorString(string directorString)
        {
            Regex directorFormat = new Regex(@"^\d + (\s +\w +) { 2 }");
             if (directorFormat.IsMatch(directorString))
            {
                throw new Exception(); //create new exception?
            }
        }

    }
}
