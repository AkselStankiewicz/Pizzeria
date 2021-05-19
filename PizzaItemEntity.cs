using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    class PizzaItemEntity
    {
       
        public string name { get; set; }
        public string ingrediences { get; set; }
        public int price { get; set; }
        public PizzaItemEntity(string name, string ingrediences, int price)
        {
            this.name = name;
            this.ingrediences = ingrediences;
            this.price = price;
        }
    }
}
