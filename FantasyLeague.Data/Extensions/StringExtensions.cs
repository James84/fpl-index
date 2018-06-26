using System.Text.RegularExpressions;

namespace FantasyLeague.Data.Extensions
{
    public static class StringExtensions
    {
        private static readonly Regex imageRegex = new Regex(@"(?<=([0-9]*\.))jpg", RegexOptions.Compiled);

        public static string ConvertJpgToPng(this string imagePath)
        {
            return $"p{imageRegex.Replace(imagePath, "png")}";
        }
    }
}
