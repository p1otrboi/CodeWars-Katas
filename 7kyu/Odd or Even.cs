//Given a list of integers, determine whether the sum of its elements is odd or even.

//Give your answer as a string matching "odd" or "even".

//If the input array is empty consider it as: [0] (array with a zero).

namespace CodeWars_Katas._7kyu
{
    internal class Odd_or_Even
    {
        public static string OddOrEven(int[] array)
        {
            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                result += array[i];
            }
            return result % 2 == 0 ? "even" : "odd";
        }
    }
}
