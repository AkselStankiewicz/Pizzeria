using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzeria
{
    public partial class Pizzeria : Form
    {
        public Pizzeria()
        {
            InitializeComponent();
            Console.WriteLine("Pobieram.");
            pizzaDB.PobierzMenu().ForEach(o =>
            {
                string[] pos = { o.name, o.ingrediences, (o.price / 100).ToString() };
                this.listViewTab1.Items.Add(new ListViewItem(pos));
            });
            mainDishDBHelper.PobierzMenu().ForEach(o =>
            {
                string[] pos = { o.name, (o.price / 100).ToString() };
                this.listViewTab2.Items.Add(new ListViewItem(pos));
            });
            soupDBHelper.PobierzMenu().ForEach(o =>
            {
                string[] pos = { o.name, (o.price / 100).ToString() };
                this.listViewTab3.Items.Add(new ListViewItem(pos));
            });
            drinkDBHelper.PobierzMenu().ForEach(o =>
            {
                string[] pos = { o.name, (o.price / 100).ToString() };
                this.listViewTab4.Items.Add(new ListViewItem(pos));
            });
        }

        PizzaDBHelper pizzaDB = new PizzaDBHelper();
        MainDishDBHelper mainDishDBHelper = new MainDishDBHelper();
        SoupDBHelper soupDBHelper = new SoupDBHelper();
        DrinkDBHelper drinkDBHelper = new DrinkDBHelper();
        PriceHelper priceHelper = new PriceHelper();
        string server = "SERVER=localhost;PORT=3306;DATABASE=pizzeria;UID=pizzeria;PASSWORD=pizza";

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            priceHelper.AddPrice(this.textBox2, this.textBox8, this.label16, 2);
            //this.textBox2.Text = (int.Parse(this.textBox2.Text) + 1).ToString();
            //this.label16.Text = (int.Parse(this.label16.Text.ToString())+2*int.Parse(textBox8.Text.ToString())).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            priceHelper.SubPrice(this.textBox2, this.textBox8, this.label16, 2);
            //this.textBox2.Text = (int.Parse(this.textBox2.Text) - 1).ToString();
            //if (int.Parse(this.textBox2.Text) <= 0)
            //{
            //    this.textBox2.Text = "0";
            //}
            //this.label16.Text = (int.Parse(this.label16.Text.ToString()) - 2 * int.Parse(textBox8.Text.ToString())).ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            priceHelper.AddPrice(this.textBox3, this.textBox8, this.label16, 2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            priceHelper.SubPrice(this.textBox3, this.textBox8, this.label16, 2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            priceHelper.AddPrice(this.textBox4, this.textBox8, this.label16, 2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            priceHelper.SubPrice(this.textBox4, this.textBox8, this.label16, 2);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            priceHelper.AddPrice(this.textBox5, this.textBox8, this.label16, 2);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            priceHelper.SubPrice(this.textBox5, this.textBox8, this.label16, 2);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            priceHelper.AddPrice(this.textBox6, this.textBox9, this.label19, 5);
            //this.textBox6.Text = (int.Parse(this.textBox6.Text) + 1).ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            priceHelper.SubPrice(this.textBox6, this.textBox8, this.label19, 5);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            priceHelper.AddPrice(this.textBox7, this.textBox8, this.label19, 6);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            priceHelper.SubPrice(this.textBox7, this.textBox8, this.label19, 6);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            priceHelper.UpdatePricePlus(this.textBox8, this.label16);
            //int curr = int.Parse(this.textBox8.Text.ToString());
            //this.textBox8.Text = (int.Parse(this.textBox8.Text) + 1).ToString();
            //this.label16.Text = (int.Parse(this.label16.Text.ToString())/curr*int.Parse(this.textBox8.Text.ToString())).ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            priceHelper.UpdatePriceMinus(this.textBox8, this.label16);
            //int curr = int.Parse(this.textBox8.Text.ToString());
            //this.textBox8.Text = (int.Parse(this.textBox8.Text) - 1).ToString();
            //if (int.Parse(this.textBox8.Text) <= 1)
            //{
            //    this.textBox8.Text = "1";
            //}
            //this.label16.Text = (int.Parse(this.label16.Text.ToString()) / curr * int.Parse(this.textBox8.Text.ToString())).ToString();

        }

        private void button17_Click(object sender, EventArgs e)
        {
            int curr = int.Parse(this.textBox9.Text.ToString());
            this.textBox9.Text = (int.Parse(this.textBox9.Text) + 1).ToString();
            this.label19.Text = (int.Parse(this.label19.Text.ToString()) / curr * int.Parse(this.textBox9.Text.ToString())).ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int curr = int.Parse(this.textBox9.Text.ToString());
            this.textBox9.Text = (int.Parse(this.textBox9.Text) - 1).ToString();
            if (int.Parse(this.textBox9.Text) <= 1)
            {
                this.textBox9.Text = "1";
            }
            this.label19.Text = (int.Parse(this.label19.Text.ToString()) / curr * int.Parse(this.textBox9.Text.ToString())).ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            priceHelper.UpdatePricePlus(this.textBox10, this.label22);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            priceHelper.UpdatePriceMinus(this.textBox10, this.label22);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            priceHelper.UpdatePricePlus(this.textBox11, this.label25);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            priceHelper.UpdatePriceMinus(this.textBox11, this.label25);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (this.listViewTab1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Wybierz produkt z listy.", "Błąd");
                return;
            }
            ListViewItem item = this.listViewTab1.SelectedItems[0];
            string name = item.ToString().Remove(0, 15);
            name = name.Remove(name.Length - 1);
            string quantity = this.textBox8.Text;
            string cheese;
            string adds = "";
            string price = this.label16.Text;
            int overallPrice = int.Parse(this.label29.Text);
            overallPrice += int.Parse(price);
            this.label29.Text = overallPrice.ToString();
            if (int.Parse(this.textBox2.Text.ToString()) == 0)
            {
                cheese = "";
            }
            else
            {
                cheese = "Ser: x" + this.textBox2.Text.ToString();
                adds += cheese + "\n";
            }
            string salami;
            if (int.Parse(this.textBox3.Text.ToString()) == 0)
            {
                salami = "";
            }
            else
            {
                salami = "Salami: x" + this.textBox3.Text.ToString();
                adds += salami + "\n";
            }
            string ham;
            if (int.Parse(this.textBox4.Text.ToString()) == 0)
            {
                ham = "";
            }
            else
            {
                ham = "Szynka: x" + this.textBox4.Text.ToString();
                adds += ham + "\n";
            }
            string mushrooms;
            if (int.Parse(this.textBox4.Text.ToString()) == 0)
            {
                mushrooms = "";
            }
            else
            {
                mushrooms = "Pieczarki: x" + this.textBox4.Text.ToString();
                adds += mushrooms + "\n";
            }
            Console.WriteLine("\n" + "Name: " + name + "\nQuantity: " + quantity + "\n" + adds);

            string[] dataitem = { quantity, name, adds, price };
            this.dataGridView1.Rows.Add(dataitem);
        }

        private void listViewTab1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listViewTab1.SelectedItems.Count > 0)
            {
                int price = int.Parse(listViewTab1.SelectedItems[0].SubItems[2].Text);
                int quantity = int.Parse(this.textBox8.Text);
                int total = price * quantity;
                this.label16.Text = total.ToString();
                this.textBox2.Text = "0";
                this.textBox3.Text = "0";
                this.textBox4.Text = "0";
                this.textBox5.Text = "0";
            }
        }

        private void listViewTab2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listViewTab2.SelectedItems.Count > 0)
            {
                int price = int.Parse(listViewTab2.SelectedItems[0].SubItems[1].Text);
                int quantity = int.Parse(this.textBox9.Text);
                int total = price * quantity;
                this.label19.Text = total.ToString();
                this.textBox6.Text = "0";
                this.textBox7.Text = "0";
            }
        }

        private void listViewTab3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listViewTab3.SelectedItems.Count > 0)
            {
                int price = int.Parse(listViewTab3.SelectedItems[0].SubItems[1].Text);
                int quantity = int.Parse(this.textBox10.Text);
                int total = price * quantity;
                this.label22.Text = total.ToString();
            }
        }

        private void listViewTab4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listViewTab4.SelectedItems.Count > 0)
            {
                int price = int.Parse(listViewTab4.SelectedItems[0].SubItems[1].Text);
                int quantity = int.Parse(this.textBox11.Text);
                int total = price * quantity;
                this.label25.Text = total.ToString();
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (this.listViewTab2.SelectedItems.Count == 0)
            {
                MessageBox.Show("Wybierz produkt z listy.", "Błąd");
                return;
            }
            ListViewItem item = this.listViewTab2.SelectedItems[0];
            string name = item.ToString().Remove(0, 15);
            Console.WriteLine(name);
            name = name.Remove(name.Length - 1);
            string quantity = this.textBox9.Text;
            string bar;
            string adds = "";
            if (int.Parse(this.textBox6.Text.ToString()) == 0)
            {
                bar = "";
            }
            else
            {
                bar = "Bar sałatkowy: x" + this.textBox6.Text.ToString();
                adds += bar + "\n";
            }
            string sauce;
            if (int.Parse(this.textBox7.Text.ToString()) == 0)
            {
                sauce = "";
            }
            else
            {
                sauce = "Zestaw sosów: x" + this.textBox7.Text.ToString();
                adds += sauce + "\n";
            }
            Console.WriteLine("\n" + "Name: " + name + "\nQuantity: " + quantity + "\n" + adds);

            string[] dataitem = { quantity, name, adds };
            this.dataGridView1.Rows.Add(dataitem);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (this.listViewTab4.SelectedItems.Count == 0)
            {
                MessageBox.Show("Wybierz produkt z listy.", "Błąd");
                return;
            }
            ListViewItem item = this.listViewTab4.SelectedItems[0];
            string name = item.ToString().Remove(0, 15);
            Console.WriteLine(name);
            name = name.Remove(name.Length - 1);
            string quantity = this.textBox11.Text;

            string[] dataitem = { quantity, name };
            this.dataGridView1.Rows.Add(dataitem);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (this.listViewTab3.SelectedItems.Count == 0)
            {
                MessageBox.Show("Wybierz produkt z listy.", "Błąd");
                return;
            }
            ListViewItem item = this.listViewTab3.SelectedItems[0];
            string name = item.ToString().Remove(0, 15);
            Console.WriteLine(name);
            name = name.Remove(name.Length - 1);
            string quantity = this.textBox10.Text;

            string[] dataitem = { quantity, name };
            this.dataGridView1.Rows.Add(dataitem);
        }
    }
}
