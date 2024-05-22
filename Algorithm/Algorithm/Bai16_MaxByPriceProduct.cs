using Algorithm.Base;
using System;
using System.Collections.Generic;


namespace Algorithm.Algorithm
{
    public static class Bai16_MaxByPriceProduct
    {
        /// <summary>
        /// Take max price in list product
        /// </summary>
        /// <returns></returns>
        public static void MaxByPriceProduct()
        {
            float result = float.MinValue;

            List<BaseEntity> products = Program.stores[Program.PRODUCT];

            for (int idx = 0; idx < products.Count - 1; idx++)
            {
                result = Math.Max(products[idx].price, result);
            }
            Console.WriteLine(result);
        }
    }
}
