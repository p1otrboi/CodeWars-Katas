//You 're writing code to control your town's traffic lights. You need a function to handle each change from green, to yellow, to red, and then to green again.

//Complete the function that takes a string as an argument representing the current state of the light and returns a string representing the state the light should change to.

//For example, when the input is green, output should be yellow.

namespace CodeWars_Katas._8kyu
{
    internal class Thinkful___Logic_Drills_Traffic_light
    {
        public static string UpdateLight(string current)
        {
            switch (current)
            {
                case "green":
                    return "yellow";
                case "yellow":
                    return "red";
                case "red":
                    return "green";
                default:
                    return "sum ting wong";
            }
        }
    }
}
