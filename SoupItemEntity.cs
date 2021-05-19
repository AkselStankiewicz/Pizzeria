using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    class SoupItemEntity : ItemEntity
    {
        public SoupItemEntity(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
    }
}
