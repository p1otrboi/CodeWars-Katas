//Write a function that takes a string of parentheses, and determines if the
//order of the parentheses is valid. The function should return true if the
//string is valid, and false if it's invalid.

//Examples
//"()"              =>  true
//")(()))"          =>  false
//"("               =>  false
//"(())((()())())"  =>  true
//Constraints
//0 <= input.length <= 100

//Along with opening (() and closing()) parenthesis, input may contain any
//valid ASCII characters. Furthermore, the input string may be empty and/or
//not contain any parentheses at all. Do not treat other forms of brackets as
//parentheses (e.g. [], { }, <>).

namespace CodeWars_Katas._5kyu;

internal class Valid_Parantheses
{
    public static bool ValidParentheses(string input)
    {
        int open = 0;
        foreach (char c in input)
        {
            if (open == -1)
                return false;
            if (c == '(')
                open++;
            if (c == ')')
                open--;
        }
        return open == 0;
    }
}
