/*
Check to see if a string has the same amount of 'x's and 'o's. The method must return a boolean and 
be case insensitive. The string can contain any char.

Examples input/output:

XO("ooxx") => true
XO("xooxx") => false
XO("ooxXm") => true
XO("zpzpzpp") => true // when no 'x' and 'o' is present should return true
XO("zzoo") => false
*/

using System.Text.RegularExpressions;

namespace CodeWars_Katas._7kyu
{
    internal class Exes_and_Ohs
    {
        public static bool XO(string input)
        {
            if (!Regex.IsMatch(input.ToUpper(), "[XO]"))
                return true;
            if (input.ToUpper().Count(x => x == 'X') == input.ToUpper().Count(x => x == 'O'))
                return true;
            else
                return false;
        }
    }
}
