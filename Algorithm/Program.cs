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

            stores[PRODUCT].Add(new Product(1 , "CPU" , 750 , 10, 1));

            stores[PRODUCT].Add(new Product(2 , "RAM" , 50 , 2, 2));

            stores[PRODUCT].Add(new Product(3 , "HDD" , 70 , 1, 2));

            stores[PRODUCT].Add(new Product(4 , "Main" , 400 , 3, 1));

            stores[PRODUCT].Add(new Product(5 , "Keyboard" , 30 , 8, 4));

            stores[PRODUCT].Add(new Product(6 , "Mouse" , 25 , 50, 4));

            stores[PRODUCT].Add(new Product(7 , "VGA" , 60 , 35, 3));

            stores[PRODUCT].Add(new Product(8 , "Monitor" , 120 , 28, 2));

            stores[PRODUCT].Add(new Product(9 , "Case" , 120 , 28, 5));

            stores[CATEGORY].Add(new Category(1,"Comuter"));

            stores[CATEGORY].Add(new Category(2,"Memory"));

            stores[CATEGORY].Add(new Category(3,"Card"));

            stores[CATEGORY].Add(new Category(4,"Accessory"));
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
                    if (name == CATEGORY)
                    {
                        ((Category)entity).Infor();
                    }
                    else
                    {
                        ((Product)entity).Infor();
                    }
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
        private static void PrintListByTypename(string typename)
        {
            foreach (BaseEntity entity in stores[typename])
            {
                entity.Infor();
            }
        }
        static void Main(string[] args)
        {
            InitStores();

            //InforStores();

            //Bai4_FindProductByName.FindProduct("Case");

            //Bai5_FindCategoryById.FindCategoryById(1).Infor();

            //Bai6_FindProductByPrice.FindProductByPrice(120);

            //Bai11_SortByPriceProductByBubbleSort.SortByPrice();

            //PrintListByTypename(PRODUCT);

            //Bai12_SortByNameProductByInserttion.SortByName();

            //PrintListByTypename(PRODUCT);

            //Bai13_SortByNameCategoryByInsertion.SortByName();

            //PrintListByTypename(CATEGORY);

            //Bai14.Bai14Function();

            //Bai15_MinByPriceProduct.MinByPriceProduct();

            //Bai16_MaxByPriceProduct.MaxByPriceProduct();

            //Console.WriteLine(Bai21_TakeSalary.TakeSalaryByRecursion(20,1));

            //Console.WriteLine(Bai21_TakeSalary.TakeSalaryByNormal(20,1));

            //Console.WriteLine(Bai22_Month.TakeMonthByRecursion(20, .5f));

            //Console.WriteLine(Bai22_Month.TakeMonthByNormal(20, .5f));

            InitMenu();

            Bai23_PrintMenu.PrintMenu();

            //Stackk<BaseEntity> stackk = new Stackk<BaseEntity>();

            //foreach (BaseEntity entity in stores[CATEGORY])
            //{
            //    stackk.Push(entity);
            //}
            //while (!stackk.IsEmpty())
            //{
            //    stackk.Top().Infor();

            //    stackk.Pop();
            //}

            //Queuee<BaseEntity> queuee = new Queuee<BaseEntity>();

            //foreach (BaseEntity entity in stores[CATEGORY])
            //{
            //    queuee.Push(entity);
            //}
            //while (!queuee.IsEmpty())
            //{
            //    queuee.Front().Infor();

            //    queuee.Pop();
            //}

        }
    }
}
