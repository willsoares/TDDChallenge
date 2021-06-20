using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDChallenge
{
    public class Question2
    {
        public static IEnumerable<int> GetIntegersFomList(IEnumerable<object> elements)
        {
            return elements
                .Where(e => e.GetType() == typeof(int))
                .Select(e => (int)e);
        }
    }
}
