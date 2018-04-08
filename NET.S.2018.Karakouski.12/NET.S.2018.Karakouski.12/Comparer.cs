using System.Collections.Generic;
using System.Linq;

namespace NET.S._2018.Karakouski._12
{
    /// <summary>
    /// Implemts comparators for comparing arrays by max value
    /// </summary>
    class ComparerByMax : IComparer<int[]>
    {
        public int Compare(int[] x, int[] y)
        {
            if (ReferenceEquals(x, y)) return 0;
            int xValue = x.Max();
            int yValue = y.Max();
            return xValue - yValue;
        }
    }

    /// <summary>
    /// Implemts comparators for comparing arrays by min value
    /// </summary>
    class ComparerByMin : IComparer<int[]>
    {
        public int Compare(int[] x, int[] y)
        {
            if (ReferenceEquals(x, y)) return 0;
            int xValue = x.Min();
            int yValue = y.Min();
            return xValue - yValue;
        }
    }

    /// <summary>
    // Implemts comparators for comparing arrays by sum
    /// </summary>
    class ComparerBySum : IComparer<int[]>
    {
        public int Compare(int[] x, int[] y)
        {
            if (ReferenceEquals(x, y)) return 0;
            int xValue = x.Sum();
            int yValue = y.Sum();
            return xValue - yValue;
        }
    }
}
