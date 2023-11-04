using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    public class Goods
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }

        public Goods (string name, decimal price, string description, string category)
        {
            Name = name;
            Price = price;
            Description = description;
            Category = category;
        }


    }

}
