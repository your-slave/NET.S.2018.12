using System.Linq;

namespace NET.S._2018.Karakouski._12
{
    /// <summary>
    /// Impliments comapring logic for later use in delegates
    /// </summary>
    public static class DelegateComparerLogic
    {
        /// <summary>
        /// Compares arrays by max value
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static int ComparerByMax(int[] x, int[] y)
        {
            if (ReferenceEquals(x, y)) return 0;
            int xValue = x.Max();
            int yValue = y.Max();
            return xValue - yValue;
        }

        /// <summary>
        /// Compares arrays by min value
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static int ComparerByMin(int[] x, int[] y)
        {
            if (ReferenceEquals(x, y)) return 0;
            int xValue = x.Min();
            int yValue = y.Min();
            return xValue - yValue;
        }

        /// <summary>
        /// Comparey arrays by sum of elemts 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static int ComparerBySum(int[] x, int[] y)
        {
            if (ReferenceEquals(x, y)) return 0;
            int xValue = x.Sum();
            int yValue = y.Sum();
            return xValue - yValue;
        }
    }
}
