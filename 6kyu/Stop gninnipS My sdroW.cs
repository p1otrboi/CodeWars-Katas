//Write a function that takes in a string of one or more words, and returns the same string,
//but with all five or more letter words reversed (Just like the name of this Kata). Strings
//passed in will consist of only letters and spaces. Spaces will be included only when more
//than one word is present.

//Examples:

//spinWords("Hey fellow warriors") => returns "Hey wollef sroirraw"
//spinWords("This is a test") => returns "This is a test"
//spinWords("This is another test")=> returns "This is rehtona test"

namespace CodeWars_Katas._6kyu
{
    internal class Stop_gninnipS_My_sdroW
    {
        public static string SpinWords(string sentence)
        {
            var res = new List<string>();

            foreach (string s in sentence.Split(' '))
            {
                if (s.Length >= 5)
                {
                    res.Add(string.Concat(s.Reverse()));
                    continue;
                }
                res.Add(s);
            }
            return string.Join(' ', res);
        }
    }
}
