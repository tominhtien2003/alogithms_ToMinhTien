using Algorithm.Base;
using System;

namespace Algorithm
{
    public class Product : BaseEntity
    {
        public int categoryID { get; set; }
        public Product(int id, string name, float price, int quantity , int categoryID)
        {
            this.id = id;

            this.name = name;

            this.price = price;

            this.quantity = quantity;

            this.categoryID = categoryID;
        }

        /// <summary>
        /// Take self
        /// </summary>
        /// <returns>self</returns>
        public override BaseEntity GetSelf()
        {
            return this;
        }
        /// <summary>
        /// Take infor of product
        /// </summary>
        public override void Infor()
        {
            base.Infor();

            Console.WriteLine("CategoryID : " + categoryID);
        }
    }
}
