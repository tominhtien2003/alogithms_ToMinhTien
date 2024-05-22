using Algorithm.Base;
using System;
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
            List<BaseEntity> categorys = Program.stores[Program.CATEGORY];

            for (int i = 0; i < categorys.Count; i++)
            {
                for (int j = i; j > 0 && string.Compare(categorys[j].name, categorys[j - 1].name) < 0; j--)
                {
                    BaseEntity temp = categorys[j];

                    categorys[j] = categorys[j - 1];

                    categorys[j - 1] = temp;

                }
            }
            Program.stores[Program.CATEGORY] = categorys;
        }
    }
}
