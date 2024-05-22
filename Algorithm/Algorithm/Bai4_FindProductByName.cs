using Algorithm.Base;
using System;

namespace Algorithm
{
    public static class Bai4_FindProductByName
    {
        /// <summary>
        /// Find object by name
        /// </summary>
        /// <param name="nameProduct"></param>
        /// <returns></returns>
        public static void FindProduct(string nameProduct)
        {
            foreach (BaseEntity product_item in Program.stores[Program.PRODUCT])
            {
                if (product_item.name == nameProduct)
                {
                    product_item.Infor();
                }
            }
        }
    }
}
