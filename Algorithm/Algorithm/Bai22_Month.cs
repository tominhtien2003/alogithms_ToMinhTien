using System;


namespace Algorithm.Algorithm
{
    public static class Bai22_Month
    {
        /// <summary>
        /// Take Month follow Recursion
        /// </summary>
        /// <param name="money"></param>
        /// <param name="rate"></param>
        /// <returns></returns>
        public static int TakeMonthByRecursion(float money,float rate,int count = 0)
        {
            if (rate * count >= 1)
            {
                return count;
            }
            return TakeMonthByRecursion(money, rate, count + 1);
        }
        /// <summary>
        /// Take month follow fuction n
        /// </summary>
        /// <param name="money"></param>
        /// <param name="rate"></param>
        /// <returns></returns>
        public static int TakeMonthByNormal(float money, float rate)
        {
            return (int)Math.Ceiling(1/rate);
        }
    }
}
