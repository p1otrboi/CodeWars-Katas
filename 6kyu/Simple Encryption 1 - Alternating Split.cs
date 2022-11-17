//Implement a pseudo-encryption algorithm which given a string S and an integer N concatenates all the odd-indexed
//characters of S with all the even-indexed characters of S, this process should be repeated N times.

//Examples:

//encrypt("012345", 1)  =>  "135024"
//encrypt("012345", 2)  =>  "135024"->  "304152"
//encrypt("012345", 3)  =>  "135024"->  "304152"->  "012345"

//encrypt("01234", 1)  =>  "13024"
//encrypt("01234", 2)  =>  "13024"->  "32104"
//encrypt("01234", 3)  =>  "13024"->  "32104"->  "20314"
//Together with the encryption function, you should also implement a decryption function which reverses the process.

//If the string S is an empty value or the integer N is not positive, return the first argument without changes.

namespace CodeWars_Katas._6kyu
{
    internal class Simple_Encryption_1___Alternating_Split
    {
        public static string Encrypt(string text, int n)
        {
            if (n <= 0)
                return text;
            if (text == null)
                return null;
            var a = new char[text.Length];
            var b = new char[text.Length];
            string encryptedText = text;
            for (int i = 0; i < n; i++)
            {
                a = encryptedText.Where((encryptedText, index) => index % 2 != 0).ToArray();
                b = encryptedText.Where((encryptedText, index) => index % 2 == 0).ToArray();
                encryptedText = String.Join(string.Empty, String.Join(string.Empty, a), String.Join(string.Empty, b));
            }
            return encryptedText;
        }

        public static string Decrypt(string encryptedText, int n)
        {
            if (n <= 0)
                return encryptedText;
            if (encryptedText == null)
                return null;

            var list = new List<char>();
            int mitt = encryptedText.Length / 2;
            string decryptedText = encryptedText;
            var jämna = new char[encryptedText.Length];
            var ojämna = new char[encryptedText.Length];
            Console.WriteLine(encryptedText.Length);

            for (int i = 0; i < n; i++)
            {
                jämna = decryptedText.Where((decryptedText, index) => index >= mitt).ToArray();
                ojämna = decryptedText.Where((decryptedText, index) => index < mitt).ToArray();

                if (encryptedText.Length % 2 != 0)
                {
                    for (int j = 0; j < encryptedText.Length / 2; j++)
                    {
                        list.Add(jämna[j]);
                        list.Add(ojämna[j]);
                        if (j == (encryptedText.Length / 2) - 1)
                            list.Add(jämna[encryptedText.Length / 2]);
                    }
                }
                else
                    for (int j = 0; j < encryptedText.Length / 2; j++)
                    {
                        list.Add(jämna[j]);
                        list.Add(ojämna[j]);
                    }
                decryptedText = String.Join(string.Empty, list);
                list.Clear();
            }
            return decryptedText;
        }
    }
}
