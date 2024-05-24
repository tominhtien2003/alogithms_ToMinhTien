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
        public static float MinByPriceProduct()
        {
            List<BaseEntity> products = Program.stores[Program.PRODUCT];

            float result = products[0].price;

            for (int idx = 1; idx < products.Count; idx++)
            {
                result = Math.Min(products[idx].price, result);
            }
            return result;
        }
    }
}
