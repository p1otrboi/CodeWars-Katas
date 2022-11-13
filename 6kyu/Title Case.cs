//A string is considered to be in title case if each word in the string is either(a)
//capitalised (that is, only the first letter of the word is in upper case) or(b) considered
//to be an exception and put entirely into lower case unless it is the first word, which
//is always capitalised.

//Write a function that will convert a string into title case, given an optional list of
//exceptions (minor words). The list of minor words will be given as a string with each
//word separated by a space. Your function should ignore the case of the minor words
//string -- it should behave in the same way even if the case of the minor word string
//is changed.

//First argument (required): the original string to be converted.
//Second argument (optional): space - delimited list of minor words that must always
//be lowercase except for the first word in the string. The JavaScript/CoffeeScript
//tests will pass undefined when this argument is unused.

//###Example

//Kata.TitleCase("a clash of KINGS", "a an the of")   => "A Clash of Kings"
//Kata.TitleCase("THE WIND IN THE WILLOWS", "The In") => "The Wind in the Willows"
//Kata.TitleCase("the quick brown fox")               => "The Quick Brown Fox"

namespace CodeWars_Katas._6kyu
{
    internal class Title_Case
    {
        public static string TitleCase(string title, string minorWords = "")
        {
            try
            {
                var words = title.Split(" ")
                           .Select(word => word.Substring(0, 1).ToUpper() +
                                           word.Substring(1).ToLower()).ToArray();
                if (!string.IsNullOrEmpty(minorWords))
                {
                    string[] keys = minorWords.ToLower().Split(" ");
                    for (int i = 1; i < words.Count(); i++)
                    {
                        foreach (string key in keys)
                        {
                            if (words[i].ToLower() == key)
                                words[i] = key;
                        }
                    }
                }
                return string.Join(" ", words);
            }
            catch
            {
                return "";
            }
        }
    }
}
