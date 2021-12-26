using System;
using System.Collections.Generic;

namespace Onroni.Extensions.Generic
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<string> Replace(this IEnumerable<string> list, string stringToReplace, string newString)
        {
            var newList = new List<string>();

            foreach(var item in list)
            {
                var cleanItem = item.Replace(stringToReplace, newString);
                newList.Add(cleanItem);
            }

            return newList;
        } 
    }
}
