using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onroni.Extensions.Generic.Classic
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<string> Replace(this IEnumerable<string> list, string stringToReplace, string newString)
        {
            var newList = new List<string>();

            foreach (var item in list)
            {
                var cleanItem = item.Replace(stringToReplace, newString);
                newList.Add(cleanItem);
            }

            return newList;
        }

        public static IEnumerable<string> RemoveString(this IEnumerable<string> list, string stringToRemove)
        {
            var newList = new List<string>();

            foreach (var item in list)
            {
                var cleanItem = item.Replace(stringToRemove, "");
                newList.Add(cleanItem);
            }

            return newList;
        }
    }
}
