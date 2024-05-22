using System;
namespace Algorithm.Algorithm
{
    public static class Bai21_TakeSalary
    {
        /// <summary>
        /// Take salary by function recursion
        /// </summary>
        /// <param name="salary">salary</param>
        /// <param name="n">number time</param>
        /// <returns></returns>
        public static float TakeSalaryByRecursion(float salary,int n)
        {
            if (n== 0)
            {
                return salary;
            }
            return TakeSalaryByRecursion(salary * .1f, --n);
        }
        /// <summary>
        /// Take salary by function Normal
        /// </summary>
        /// <param name="salary"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static float TakeSalaryByNormal(float salary, int n)
        {
            for (int i = 0; i < n; i++)
            {
                salary = salary * .1f;
            }
            return salary;
        }
    }
}
