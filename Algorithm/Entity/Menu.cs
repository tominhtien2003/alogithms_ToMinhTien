using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Entity
{
    public class Menu
    {
        public int id { get; set; }
        public string name { get; set; }
        public int parent_id { get; set; }
        public Menu(int id, string name, int parent_id)
        {
            this.id = id;

            this.name = name;

            this.parent_id = parent_id;
        }
    }
}
