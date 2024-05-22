using Algorithm.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Algorithm
{
    public static class Bai11_SortByPriceProductByBubbleSort
    {
        /// <summary>
        /// Sort list product by price
        /// </summary>
        public static void SortByPrice()
        {
            List<BaseEntity> products = Program.stores[Program.PRODUCT];

            for (int idx_i = 0; idx_i < products.Count-1; idx_i++)
            {
                for (int idx_j = 0 ; idx_j < products.Count; idx_j++)
                {
                    if (products[idx_i].price > products[idx_j].price)
                    {
                        BaseEntity temp = products[idx_i];

                        products[idx_i] = products[idx_j];

                        products[idx_j] = temp;
                    }
                }
                Program.stores[Program.PRODUCT] = products;
            }
        }
    }
}
