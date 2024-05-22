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
        public static int TakeMonthByRecursion(float money,int rate)
        {
            if (money == 0)
            {
                return 0;
            }
            return TakeMonthByRecursion(money - money * rate, rate) + 1;
        }
        /// <summary>
        /// Take month follow fuction normal
        /// </summary>
        /// <param name="money"></param>
        /// <param name="rate"></param>
        /// <returns></returns>
        public static int TakeMonthByNormal(float money, int rate)
        {
            int res = 0;
            while (money > 0)
            {
                money -= money * rate;
                ++res;
            }
            return res;
        }
    }
}
