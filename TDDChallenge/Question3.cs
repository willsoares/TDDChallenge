using System.Linq;

namespace TDDChallenge
{
    public class Kata
    {
        public static string FormatWords(string[] words)
        {
            var normalizedArray = words.Where(w => !string.IsNullOrWhiteSpace(w)).Select(w => w).ToArray();
            if (normalizedArray.Length == 1)
                return normalizedArray.First();

            var formatted = "";

            formatted = string.Join(", ", normalizedArray.Take(normalizedArray.Length - 1).Select(w => w));

            formatted = string.Concat(formatted, " and ", normalizedArray.Last());
            return formatted;
        }
    }
}