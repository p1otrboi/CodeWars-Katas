//Your task in order to complete this Kata is to write a function which formats a duration, given as a number of seconds,
//in a human-friendly way.

//The function must accept a non-negative integer. If it is zero, it just returns "now". Otherwise, the duration is expressed
//as a combination of years, days, hours, minutes and seconds.

//It is much easier to understand with an example:

//*For seconds = 62, your function should return 
//    "1 minute and 2 seconds"
//* For seconds = 3662, your function should return
//    "1 hour, 1 minute and 2 seconds"
//For the purpose of this Kata, a year is 365 days and a day is 24 hours.

//Note that spaces are important.

//Detailed rules
//The resulting expression is made of components like 4 seconds, 1 year, etc. In general, a positive integer and one
//of the valid units of time, separated by a space. The unit of time is used in plural if the integer is greater than 1.

//The components are separated by a comma and a space (", "). Except the last component, which is separated by " and ",
//just like it would be written in English.

//A more significant units of time will occur before than a least significant one. Therefore, 1 second and 1 year is not
//correct, but 1 year and 1 second is.

//Different components have different unit of times. So there is not repeated units like in 5 seconds and 1 second.

//A component will not appear at all if its value happens to be zero. Hence, 1 minute and 0 seconds is not valid, but it
//should be just 1 minute.

//A unit of time must be used "as much as possible". It means that the function should not return 61 seconds, but 1 minute
//and 1 second instead. Formally, the duration specified by of a component must not be greater than any valid more significant unit of time.

using System.Text;

namespace CodeWars_Katas._4kyu
{
    internal class Human_readable_duration_format
    {
        public static string formatDuration(int seconds)
        {
            var sb = new StringBuilder();
            int y = seconds / 31536000;
            int d = (seconds / 86400) - (y * 365);
            int h = (seconds / 3600) - (y * 8760) - (d * 24);
            int m = (seconds / 60) - (y * 525600) - (d * 1440) - (h * 60);
            int s = seconds - (y * 31536000) - (d * 86400) - (h * 3600) - (m * 60);
            var dict = new Dictionary<string, int>() { { "year", y }, { "day", d }, { "hour", h }, { "minute", m }, { "second", s } };
            var list = new List<string>();
            foreach (var value in dict)
            {
                if (value.Value == 1) list.Add($"{value.Value} {value.Key}");
                if (value.Value > 1) list.Add($"{value.Value} {value.Key}s");
            }

            if (seconds == 0) return "now";

            if (list.Count == 1) return list[0];

            if (list.Count == 2) return String.Join(" and ", list.ToArray());

            if (list.Count >= 3)
            {
                sb.Append(String.Join(", ", list.SkipLast(1).ToArray()));
                sb.Append($" and {list.Last()}");
            }
            return sb.ToString();
        }
    }
}
