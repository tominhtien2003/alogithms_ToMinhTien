using Algorithm.Base;
using System.Collections.Generic;


namespace Algorithm.Algorithm
{
    public static class Bai13_SortByNameCategoryByInsertion
    {
        /// <summary>
        /// Sort category by name
        /// </summary>
        public static void SortByName()
        {
            List<BaseEntity> products = Program.stores[Program.PRODUCT];

            for (int i = 0; i < products.Count; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    var item1 = (Product)products[j];
                    var item2 = (Product)products[j - 1];
                    if (item1.categoryID > item2.categoryID)
                    {
                        BaseEntity temp = products[j];

                        products[j] = products[j - 1];

                        products[j - 1] = temp;
                    }   
                }
            }
            Program.stores[Program.PRODUCT] = products;
        }
    }
}
