using Algorithm.Entity;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Algorithm.Algorithm
{
    public static class Bai23_PrintMenu
    {
        private static HashSet<Tuple<int, int>> visited = new HashSet<Tuple<int, int>>();
        /// <summary>
        /// Print list menu
        /// </summary>
        public static void PrintMenu()
        {
            foreach (Menu menu in Program.menus)
            {
                var keyParent = new Tuple<int, int>(menu.id, menu.ParentId);
                if (!visited.Contains(keyParent))
                {
                    visited.Add(keyParent);

                    List<string> res = new List<string>();

                    res.Add(menu.name);

                    FindFamily(menu.id, ref res);

                    PrintMenuRes(res);
                }
            }
        }
        /// <summary>
        /// Take Genealogy with parent have id is parentId
        /// </summary>
        /// <param name="parentId"></param>
        /// <param name="res"></param>
        /// <param name="dash"></param>
        
        private static void FindFamily(int parentId,ref List<string>res,string dash = "--")
        {
            if (parentId == 0) return;

            foreach (Menu item in Program.menus)
            {
                var keyParent = new Tuple<int, int>(item.id, item.ParentId);

                if (!visited.Contains(keyParent) && item.ParentId == parentId)
                {
                    visited.Add(keyParent);

                    res.Add(dash + item.name);

                    FindFamily(item.id,ref res,dash+"--");
                }
            }
        }

        private static void PrintMenuRes(List<string> res)
        {
            foreach (string item in res)
            {
                Console.WriteLine(item);
            }
        }
        
    }
}
