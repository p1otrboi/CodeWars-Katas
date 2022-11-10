//Make a function that returns the value multiplied by 50 and increased by 6. If the value 
//    entered is a string it should return "Error".

//Note: in C#, you'll always get the input as a string, so the above applies if the string 
//    isn't representing a double value.

namespace CodeWars_Katas._8kyu
{
    internal class Super_Duper_Easy
    {
        public static string Problem(String a)
        {
            bool res = double.TryParse(a, out double b);
            if (res)
            {
                double c = b * 50 + 6;
                return (b * 50 + 6).ToString();
            }
            else
                return "Error";
        }
    }
}
