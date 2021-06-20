using System.Linq;

namespace TDDChallenge
{
    public class Question1
    {
        public static int ReturnUnevenNumber(int[] array)
        {
            var evens = array.Where(n => n % 2 == 0);
            var odds = array.Where(n => n % 2 == 1);
            return evens.Count() == 1 ? evens.First() : odds.First();
        }
    }
}