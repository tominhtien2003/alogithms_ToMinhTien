using Algorithm.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Entity
{
    public class Category : BaseEntity
    {
        public Category(int id, string name)
        {
            this.id = id;

            this.name = name;
        }

        public override void Infor()
        {
            Console.WriteLine("Id : " + id + "\n");

            Console.WriteLine("Name : " + name + "\n");
        }
        /// <summary>
        /// Get self
        /// </summary>
        /// <returns>self</returns>
        public override BaseEntity GetSelf()
        {
            return this;
        }
    }
}
