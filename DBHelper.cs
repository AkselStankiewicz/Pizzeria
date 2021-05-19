using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    public abstract class DBHelper
    {
        public void PobierzMenu() { }
        public string server = "SERVER=localhost;PORT=3306;DATABASE=pizzeria;UID=pizzeria;PASSWORD=pizza";
    }
}