using System;


namespace Algorithm.Algorithm
{
    public static class Bai22_Month
    {
        /// <summary>
        /// Take Month follow Recursion
        /// </summary>
        /// <param name="money">Money start</param>
        /// <param name="rate">sale</param>
        /// <returns></returns>
        public static int TakeMonthByRecursion(float moneyStart,float rate,float targetMoney = 0)
        {
            targetMoney += moneyStart * rate;

            if (targetMoney >= moneyStart)
            {
                return 1;
            }           
            return TakeMonthByRecursion(moneyStart, rate, targetMoney) + 1;
        }
        /// <summary>
        /// Take month follow fuction n
        /// </summary>
        /// <param name="money"></param>
        /// <param name="rate"></param>
        /// <returns></returns>
        public static int TakeMonthByNormal(float money, float rate)
        {
            float targetMoney = 0;

            int count = 1;
            while (targetMoney < money)
            {
                targetMoney += money * rate;

                ++count;
            }
            return count;
        }
    }
}
