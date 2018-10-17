using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace FormUI
{
    public class Actor
    {
        public int id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public char? Gender { get; set; }

        public override string ToString()
        {
            return FirstName + ' ' + LastName + ' ' + Gender;
        }

        public static implicit operator Actor(string actorString)
        {
            Actor converted = new Actor();

            if (actorString != null)
            {
                IsValidActorString(actorString);
                var actorArr = actorString.Split(' ');
                converted.id = int.Parse(actorArr[0]);
                converted.FirstName = actorArr[1];
                converted.LastName = actorArr[2];
            }
            return converted;
        }

        private static void IsValidActorString(string actorString)
        {
            Regex actorFormat = new Regex(@"^\d + (\s +\w +) { 2 }");
            if (actorFormat.IsMatch(actorString))
            {
                throw new FormatException(); //create new exception?
            }
        }
    }
}
