using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    class MainDishItemEntity : ItemEntity
    {
        public MainDishItemEntity(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
    }
}
