using Algorithm.Base;
using System.Collections.Generic;

namespace Algorithm.Algorithm
{
    public static class Bai12_SortByNameProductByInserttion
    {
        /// <summary>
        /// Sort list product by name
        /// </summary>
        public static void SortByName()
        {
            List<BaseEntity> products = Program.stores[Program.PRODUCT];

            for (int i=0; i<products.Count; i++)
            {
                for (int j = i; j > 0 && string.Compare(products[j].name, products[j - 1].name) > 0; j--)
                {
                    BaseEntity temp = products[j];

                    products[j] = products[j-1];

                    products[j-1] = temp;
                    
                }
            }
            Program.stores[Program.PRODUCT] = products;
        }
    }
}
