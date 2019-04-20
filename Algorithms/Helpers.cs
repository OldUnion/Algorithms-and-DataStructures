using System.Collections.Generic;

namespace Algorithms
{
    public static class Helpers
    {
        public static void Swap<T>(this IList<T> list, int firstIndex, int secondIndex)
        {
            var temp = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = temp;
        }
    }
}
