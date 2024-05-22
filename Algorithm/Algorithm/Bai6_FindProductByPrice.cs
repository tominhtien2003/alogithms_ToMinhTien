using Algorithm.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Algorithm
{
    public static class Bai6_FindProductByPrice
    {
        public static void FindProductByPrice(float price)
        {
            foreach (BaseEntity item in Program.stores[Program.PRODUCT])
            {
                if (item.price == price)
                {
                    item.Infor();
                }
            }
        }
    }
}
