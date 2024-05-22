using Algorithm.Entity;
using System;
using System.Collections.Generic;


namespace Algorithm.Algorithm
{
    public static class Bai23_PrintMenu
    {
        /// <summary>
        /// Print list menu
        /// </summary>
        public static void PrintMenu()
        {
            SortMenuByParentId();

            string dash = "--";

            int prev_Parent = -Program.menus[0].id;

            foreach (Menu item in Program.menus)
            {
                Console.Write(dash + item.name);

                if (item.parent_id != prev_Parent)
                {
                    dash += "--";
                }
            }
        }
        /// <summary>
        /// Sort list menu
        /// </summary>
        private static void SortMenuByParentId()
        {
            List<Menu> menus = Program.menus;

            for (int i = 0; i < menus.Count-1; i++)
            {
                for (int j=i+1;j<menus.Count;j++)
                {
                    if (menus[i].parent_id > menus[j].parent_id)
                    {
                        Menu temp = menus[i];

                        menus[i] = menus[j];

                        menus[j] = temp;
                    }
                }
            }
        }
    }
}
