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
        public static BaseEntity FindProduct(string nameProduct)
        {
            foreach (BaseEntity product_item in Program.stores[Program.PRODUCT])
            {
                if (product_item.name == nameProduct)
                {
                    return product_item;
                }
            }
            Console.WriteLine("Don't have object product with name is " + nameProduct);

            return null;
        }
    }
}
