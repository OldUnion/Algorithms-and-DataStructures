using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Sorting
{
    public static class BubbleSort
    {
        public static void Sort<T>(IList<T> array, IComparer<T> comparer = null)
        {
            var sortingComparer = comparer ?? Comparer<T>.Default;
            for (int i = 0; i < array.Count(); i++)
            {
                for (int j = 0; j < array.Count() - i - 1; j++)
                {
                    if (sortingComparer.Compare(array[j], array[j + 1]) > 0)
                    {
                        array.Swap(j, j + 1);
                    }
                }
            }
        }
    }
}
