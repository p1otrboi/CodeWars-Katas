//Build a pyramid-shaped tower, as an array/list of strings, given a positive
//integer number of floors. A tower block is represented with "*" character.

//For example, a tower with 3 floors looks like this:

//[
//  "  *  ",
//  " *** ",
//  "*****"
//]
//And a tower with 6 floors looks like this:

//[
//  "     *     ",
//  "    ***    ",
//  "   *****   ",
//  "  *******  ",
//  " ********* ",
//  "***********"
//]
using System.Text;

namespace CodeWars_Katas._6kyu
{
    internal class Build_Tower
    {
        public static string[] TowerBuilder(int nFloors)
        {
            string[] tower = new string[nFloors];
            string space = "";
            string floor = "*";
            int bottomFloor = 1 + (nFloors - 1) * 2;
            for (int i = nFloors; i >= 1; i--)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(space);
                for (int j = bottomFloor; j >= 1; j--)
                {
                    sb.Append(floor);
                }
                sb.Append(space);
                space += " ";
                bottomFloor -= 2;
                tower[i - 1] = sb.ToString();
            }
            return tower;
        }
    }
}
