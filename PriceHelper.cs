using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzeria
{
    class PriceHelper
    {
        public void AddPrice(TextBox textBoxQuantity, TextBox textBoxQuantityOfItems,Label label, int priceOfItem)
        {
            textBoxQuantity.Text = (int.Parse(textBoxQuantity.Text) + 1).ToString();
            label.Text = (int.Parse(label.Text.ToString()) + priceOfItem * int.Parse(textBoxQuantityOfItems.Text.ToString())).ToString();
        }

        public void SubPrice(TextBox textBoxQuantity, TextBox textBoxQuantityOfItems, Label label, int priceOfItem)
        {
            
            if (int.Parse(textBoxQuantity.Text) > 0)
            {
                textBoxQuantity.Text = (int.Parse(textBoxQuantity.Text) - 1).ToString();
                label.Text = (int.Parse(label.Text.ToString()) - priceOfItem * int.Parse(textBoxQuantityOfItems.Text.ToString())).ToString();
            }
            
        }
    }
}
