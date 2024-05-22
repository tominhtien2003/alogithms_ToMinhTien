using Algorithm.Algorithm;
using Algorithm.Base;
using Algorithm.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class Program
    {
        public static string PRODUCT = "Product";

        public static string CATEGORY = "Category";

        public static Dictionary<string,List<BaseEntity>> stores = new Dictionary<string,List<BaseEntity>>();

        public static List<Menu> menus = new List<Menu>();
        /// <summary>
        /// Init list BaseEntity
        /// </summary>
        private static void InitStores()
        {
            stores[PRODUCT]= new List<BaseEntity>();

            stores[CATEGORY]= new List<BaseEntity>();

            for (int i = 0; i < 10; i++)
            {
                stores[PRODUCT].Add(new Product(i, i.ToString(), i, i, 9 - i));

                stores[CATEGORY].Add(new Category(i, i.ToString(), i,i));
            }
        }
        /// <summary>
        /// Take infor of all object
        /// </summary>
        private static void InforStores()
        {
            foreach (string name in stores.Keys)
            {
                foreach (BaseEntity entity in stores[name])
                {
                    entity.Infor();
                }
            }
        }

        private static void InitMenu()
        {
            menus.Add(new Menu(1, "The thao", 0));

            menus.Add(new Menu(2, "Xa hoi", 0));

            menus.Add(new Menu(3, "The thao trong nuoc", 1));

            menus.Add(new Menu(4, "Giao thong", 2));

            menus.Add(new Menu(5, "moi truong", 2));

            menus.Add(new Menu(6, "The thao quoc te", 1));

            menus.Add(new Menu(7, "Moi truong do thi", 5));

            menus.Add(new Menu(8, "Giao thong un tac", 4));
        }
        static void Main(string[] args)
        {
            InitStores();

            //InforStores();

            //Bai4_FindProductByName.FindProduct("1").Infor();

            //Bai5_FindCategoryById.FindCategoryById(1).Infor();

            List<string> res = Bai14.Bai14Function();

            foreach (string name in res)
            {
                Console.WriteLine(name);
            }
        }
    }
}
