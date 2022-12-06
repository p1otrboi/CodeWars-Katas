//Create a RomanNumerals class that can convert a roman numeral to and from an integer value.
//It should follow the API demonstrated in the examples below. Multiple roman numeral values will be tested for each helper method.

//Modern Roman numerals are written by expressing each digit separately starting with the left
//most digit and skipping any digit with a value of zero. In Roman numerals 1990 is rendered:
//1000 = M, 900 = CM, 90 = XC; resulting in MCMXC. 2008 is written as 2000 = MM, 8 = VIII; or
//MMVIII. 1666 uses each Roman symbol in descending order: MDCLXVI.

//Input range : 1 <= n< 4000

//In this kata 4 should be represented as IV, NOT as IIII (the "watchmaker's four").

//Examples
//RomanNumerals.toRoman(1000); // should return 'M'
//RomanNumerals.fromRoman('M'); // should return 1000
//Help
//Symbol	Value
//I	          1
//IV	      4
//V	          5
//X	          10
//L	          50
//C	          100
//D	          500
//M	          1000



namespace CodeWars_Katas._4kyu;

internal class Roman_numerals_helper
{
    public static string ToRoman(int n)
    {
        if ((n < 0) || (n > 3999)) throw new Exception();
        if (n < 1) return string.Empty;
        if (n >= 1000) return "M" + ToRoman(n - 1000);
        if (n >= 900) return "CM" + ToRoman(n - 900);
        if (n >= 500) return "D" + ToRoman(n - 500);
        if (n >= 400) return "CD" + ToRoman(n - 400);
        if (n >= 100) return "C" + ToRoman(n - 100);
        if (n >= 90) return "XC" + ToRoman(n - 90);
        if (n >= 50) return "L" + ToRoman(n - 50);
        if (n >= 40) return "XL" + ToRoman(n - 40);
        if (n >= 10) return "X" + ToRoman(n - 10);
        if (n >= 9) return "IX" + ToRoman(n - 9);
        if (n >= 5) return "V" + ToRoman(n - 5);
        if (n >= 4) return "IV" + ToRoman(n - 4);
        if (n >= 1) return "I" + ToRoman(n - 1);
        throw new Exception();
    }

    public static int FromRoman(string romanNumeral)
    {
        int sum = 0;
        Dictionary<char, int> dict = new()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };
        for (int i = 0; i < romanNumeral.Length; i++)
        {
            char current = romanNumeral[i];
            dict.TryGetValue(current, out int num);
            if (i + 1 < romanNumeral.Length && dict[romanNumeral[i + 1]] > dict[current])
                sum -= num;
            else
                sum += num;
        }
        return sum;
    }
}
