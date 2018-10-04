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
        public Director(string fullName)
        {
            if (fullName == "" || fullName == null)
            {

            }
            else
            {
                var directorArr = CapitalizeFirstLetters(fullName);
                FirstName = directorArr[0];
                LastName = directorArr[1];
            }
        }

        public Director() { }

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

        private string[] CapitalizeFirstLetters(string fullName)
        {
            
            fullName = fullName.ToLower().Trim();
            var fullNameArr = fullName.Split(' ');

            for(int i = 0; i < fullNameArr.Length; i++)
            {
                var nameChars = fullNameArr[i].ToCharArray();
                nameChars[0] = char.ToUpper(nameChars[0]);
                fullNameArr[i] = new string(nameChars);
            }
            return fullNameArr;
        }
    }
}
