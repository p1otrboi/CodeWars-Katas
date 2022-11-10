//Complete the function/method so that it returns the url with anything after the anchor (#) removed.

namespace CodeWars_Katas._7kyu
{
    internal class Remove_anchor_from_URL
    {
        public static string RemoveUrlAnchor(string url)
        {
            // TODO: complete
            string res = "";

            string[] a = url.Split("#");
            res = a[0];

            return res;
        }
    }
}
