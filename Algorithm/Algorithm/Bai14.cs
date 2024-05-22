using Algorithm.Base;
using System;
using System.Collections.Generic;


namespace Algorithm.Algorithm
{
    public static class Bai14
    {
        /// <summary>
        /// Take list name category follow categoryID in product
        /// </summary>
        /// <returns></returns>
        public static List<string> Bai14Function()
        {
            List<string> res = new List<string>();

            List<BaseEntity> products = Program.stores[Program.PRODUCT];

            for (int i=0;i< products.Count; i++)
            {
                res.Add(FindCategoryById(((Product)products[i]).categoryID));
            }
            return res;
        }
        /// <summary>
        /// return name of category with id
        /// </summary>
        /// <param name="id">id of categoryID</param>
        /// <returns></returns>
        private static string FindCategoryById(int id)
        {
            List<BaseEntity> categorys = Program.stores[Program.CATEGORY];

            for (int idx = 0;idx < categorys.Count; idx++)
            {
                if (categorys[idx].id == id)
                {
                    return categorys[idx].name;
                }
            }
            return "";
        }
    }
}
