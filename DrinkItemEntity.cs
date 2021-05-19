using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    class DrinkItemEntity : ItemEntity
    {
        public DrinkItemEntity(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
    }
}
