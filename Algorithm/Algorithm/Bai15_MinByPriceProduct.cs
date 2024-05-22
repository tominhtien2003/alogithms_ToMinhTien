using Algorithm.Base;
using System;
using System.Collections.Generic;

namespace Algorithm.Algorithm
{
    public static class Bai15_MinByPriceProduct
    {
        /// <summary>
        /// Take min price in list product
        /// </summary>
        /// <returns></returns>
        public static void MinByPriceProduct()
        {
            float result = float.MaxValue;

            List<BaseEntity> products = Program.stores[Program.PRODUCT];

            for (int idx = 0; idx < products.Count - 1; idx++)
            {
                result = Math.Min(products[idx].price, result);
            }
            Console.WriteLine(result);
        }
    }
}
