using System.Collections.Generic;

namespace NET.S._2018.Karakouski._12
{
    public delegate int DelegateComparer(int[] x, int[] y);

    /// <summary>
    /// Impliments buble sort method of sorting jagged array
    /// </summary>
    public static class ArraySort
    {
        /// <summary>
        /// Sort jagged array using bubble sort with an IComparer as parameter
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="mode">Selects sort mode: 0 for sorting by sum, 1 for by max, 2 by min</param>
        public static void BubbleSortBySums(int[][] arr, IComparer<int[]> comparator)
        {
            int[] temp = new int[0];
 
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (comparator.Compare(arr[i], arr[j]) > 0)
                        Swap(arr[i], arr[j], temp);                    
                }
            }
        }

        /// <summary>
        /// Sort jagged array using bubble sort with an IComparer a delegate
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="comparator"></param>
        public static void BubbleSortBySums(int[][] arr, DelegateComparer delegateComparer)
        {
            int[] temp = new int[0];

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (delegateComparer(arr[i], arr[j]) > 0)
                        Swap(arr[i], arr[j], temp);
                }
            }
        }

        /// <summary>
        /// Help method for swapping arrays
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="temp"></param>
        private static void Swap(int[] a, int[] b, int[] temp)
        {
            temp = new int[b.Length];
            b.CopyTo(temp, 0);

            b = new int[a.Length];
            a.CopyTo(b, 0);

            a = new int[temp.Length];
            temp.CopyTo(a, 0);
        }

    }
}
