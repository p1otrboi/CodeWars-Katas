//Write a function that accepts an array of 10 integers (between 0 and 9), that returns a string of those numbers in the form of a phone number.

//Example
//Kata.CreatePhoneNumber(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }) // => returns "(123) 456-7890"
//The returned format must be correct in order to complete this challenge.

//Don't forget the space after the closing parentheses!

namespace CodeWars_Katas._6kyu
{
    internal class Create_Phone_Number
    {
        public static string CreatePhoneNumber(int[] numbers)
        {
            string numberstring = "";
            foreach (int i in numbers)
                numberstring += i.ToString();
            return String.Format("{0:(000) 000-0000}", double.Parse(numberstring));
        }
    }
}
