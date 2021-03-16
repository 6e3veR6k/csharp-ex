using System;
using System.Collections.Generic;
using System.Linq;

namespace codewars_katas
{
    public class Finder
    {
        public static int FindDeletedNumber(List<int> startingList, List<int> mixedList)
        {
            // Your code here
            int[] result = startingList.Where(x => !mixedList.Any(t => t == x)).ToArray();
            int a = result.Length == 0 ? 0 : result[0];
            return a;
        }

    }
}
