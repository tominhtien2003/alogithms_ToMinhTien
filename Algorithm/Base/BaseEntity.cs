using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Base
{
    public abstract class BaseEntity
    {
        public int id { get; set; }
        public string name { get; set; }
        public float price { get; set; }
        public int quantity { get; set; }

        /// <summary>
        /// Take infor of product
        /// </summary>
        public virtual void Infor()
        {
            Console.WriteLine("Id : " + id + "\n");

            Console.WriteLine("Name : " + name + "\n");

            Console.WriteLine("Price : " + price + "\n");

            Console.WriteLine("Quantity : " + quantity + "\n");
        }
        /// <summary>
        /// Get self obj
        /// </summary>
        /// <returns></returns>
        public abstract BaseEntity GetSelf();
    }
}
