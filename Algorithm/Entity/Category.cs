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
        public Category(int id, string name, float price, int quantity)
        {
            this.id = id;

            this.name = name;

            this.price = price;

            this.quantity = quantity;

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
