//Write a function that will return the count of distinct case-insensitive alphabetic characters and
//numeric digits that occur more than once in the input string. The input string can be assumed to
//contain only alphabets (both uppercase and lowercase) and numeric digits.

//Example
//"abcde" -> 0 # no characters repeats more than once
//"aabbcde" -> 2 # 'a' and 'b'
//"aabBcde" -> 2 # 'a' occurs twice and 'b' twice (`b` and `B`)
//"indivisibility" -> 1 # 'i' occurs six times
//"Indivisibilities" -> 2 # 'i' occurs seven times and 's' occurs twice
//"aA11" -> 2 # 'a' and '1'
//"ABBA" -> 2 # 'A' and 'B' each occur twice

using System.Text;

namespace CodeWars_Katas._6kyu;

internal class Give_me_a_Diamond
{
    public static string? print(int n)
    {
        if (n < 1 || n % 2 == 0) return null;

        var sbbottom = new StringBuilder();
        var sbtop = new StringBuilder();

        int spaces = 0;
        for (int i = n; i > 0; i -= 2)
        {
            sbbottom.Append(' ', spaces++);
            sbbottom.Append('*', i);
            sbbottom.Append("\n");
        }
        spaces--;
        for (int i = 1; i < n; i += 2)
        {
            sbtop.Append(' ', spaces--);
            sbtop.Append('*', i);
            sbtop.Append("\n");
        }
        return string.Concat(sbtop.ToString(), sbbottom.ToString());
    }
}
