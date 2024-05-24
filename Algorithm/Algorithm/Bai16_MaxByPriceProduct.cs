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
        public static float MaxByPriceProduct()
        {
            List<BaseEntity> products = Program.stores[Program.PRODUCT];
            float result = products[0].price;

            for (int idx = 1; idx < products.Count; idx++)
            {
                result = Math.Max(products[idx].price, result);
            }
            return result;
        }
    }
}
