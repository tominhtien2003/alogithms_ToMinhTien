using Algorithm.Base;
using System;

namespace Algorithm.Algorithm
{
    public static class Bai5_FindCategoryById
    {
        /// <summary>
        /// Find category follow id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static BaseEntity FindCategoryById(int id)
        {
            foreach(BaseEntity item in Program.stores[Program.CATEGORY])
            {
                if (item.id == id)
                {
                    return item;
                }
            }
            Console.WriteLine("Don't have object category with id is " + id);

            return null;
        }
    }
}
