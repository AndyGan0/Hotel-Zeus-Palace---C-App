using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace allhlepidrash
{
    public partial class Control_Restaurant : Form
    {
        Boolean isMorning;
        String Language;

        /*
         * order is list with items
         * each iten is represented by a list
         * example : [tea,5]
         * 5 is the price and tea is the item
         */

        List<List<String>> order = new List<List<String>>();
        float price = 0;

        List<PictureBox> buttons_for_delete = new List<PictureBox>();

        public Control_Restaurant(Boolean isMorning, string language)
        {
            InitializeComponent();
            this.isMorning = isMorning;
            Language = language;

            if (!isMorning)
            {
                Brunch_menu_panel.Hide();
            }

            refresh_basket();

        }

        private void buttons_enter_hover(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.Wheat;
        }

        private void buttons_leave_hover(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.Beige;
        }

        private void add_item_to_order(object sender, EventArgs e)
        {
            String choice = ((Label)sender).Text; // choice might have 2nd line

            int positionOfNewLine = choice.IndexOf("\r\n");

            if (positionOfNewLine >= 0)
            {
                choice = choice.Substring(0, positionOfNewLine);
            }

            List<String> item_added = new List<String>();

            /*
             Find price first
             */
            int right = choice.Length - 1;
            int left = choice.Length - 1;

            while (choice[right] == ' ')
            {
                right--;
            }
            left = right - 1;

            while (choice[left - 1] != ' ')
            {
                left--;
            }

            String item_price = choice.Substring(left, right - left + 1);

            /*
             Find item name
             */
            right = left - 1;
            left = 0;


            while (choice[right] == ' ')
            {
                right--;
            }
            String item_name = choice.Substring(left, right - left + 1);

            item_added.Add(item_name);
            item_added.Add(item_price);


            order.Add(item_added);

            refresh_basket();
        }

        private void basket_button_Click(object sender, EventArgs e)
        {
            if (basket.Visible)
            {
                basket.Hide();
            }
            else
            {
                basket.Show();
            }


        }


        private void remove_item(object sender, EventArgs e)
        {
            int item_index_in_order = Int16.Parse(((PictureBox)sender).Name);
            order.RemoveAt(item_index_in_order);
            refresh_basket();
        }

        private void refresh_basket()
        {
            /*
             * Remove existing buttons and reset panel
             */

            foreach (PictureBox p in buttons_for_delete)
            {
                if (basket.Contains(p))
                {
                    basket.Controls.Remove(p);
                }
            }
            buttons_for_delete.Clear();

            if (Language == "greek")
            {
                label50.Text = "Παραγγελία\r\n\r\n";
                label49.Text = "Τιμή\r\n\r\n";
            }
            else
            {
                label50.Text = "Order\r\n\r\n";
                label49.Text = "Price\r\n\r\n";
            }




            /*
             * Add items
             */

            int i = 0;
            float sum = 0;
            int x = 10;
            int y = 220;

            foreach (List<String> item in order)
            {
                String item_name = item[0];
                float price = float.Parse(item[1]);
                sum += price;

                label50.Text += item_name + Environment.NewLine;
                label49.Text += price + "€" + Environment.NewLine;

                PictureBox deleteItem = new PictureBox();
                deleteItem.SizeMode = PictureBoxSizeMode.Zoom;
                deleteItem.Size = new Size(25, 25);
                deleteItem.Image = Properties.Resources.delete;
                deleteItem.Cursor = Cursors.Hand;
                deleteItem.Location = new Point(x, y);
                deleteItem.BackColor = Color.Transparent;
                deleteItem.Name = i.ToString();
                deleteItem.Click += remove_item;
                basket.Controls.Add(deleteItem);
                y += 35;
                i++;
                buttons_for_delete.Add(deleteItem);

            }

            label50.Text += Environment.NewLine + Environment.NewLine;
            label49.Text += Environment.NewLine + Environment.NewLine;

            if (Language == "greek")
            {
                label50.Text += "Σύνολο:";
            }
            else
            {
                label50.Text += "Total:\r\n\r\n";
            }
            label49.Text += sum + "€";


            price = sum;
        }

        private void complete_button_Click(object sender, EventArgs e)
        {
            if (price != 0)
            {
                Control_Restaurant_Purchase form_card = new Control_Restaurant_Purchase(price, Language);
                form_card.ShowDialog();
            }
            else
            {
                if (Language == "greek")
                {
                    MessageBox.Show("Το καλάθι σας είναι άδειο");
                }
                else
                {
                    MessageBox.Show("Your Basket is Full");
                }

            }

        }



        public void setLanguageTo(string newlanguage)
        {
            Language = newlanguage;

            order.Clear();
            price = 0;

            foreach (PictureBox b in buttons_for_delete)
            {

            }



            if (newlanguage == "greek")
            {
                label23.Text = "Πρωινό Μενού";
                label46.Text = "Σερβίρεται 9:00-16:00";
                label47.Text = "Πρωινό";
                label40.Text = "Ροφήματα";
                label48.Text = "Καλάθι";
                label21.Text = "Μενού  του Ολύμπου";
                label50.Text = "Παραγγελία\r\n\r\n";
                label49.Text = "Τιμή\r\n\r\n";
                complete_button.Text = "Ολοκλήρωση Παραγγελίας";

                label1.Text = "Ορεκτικά";
                label15.Text = "Κυρίως πιάτα";
                label26.Text = "Ποτά";
                label10.Text = "Σαλάτες";
                label24.Text = "Επιδόρπια";


            }
            else if (newlanguage == "english")
            {
                label23.Text = "Morning Menu";
                label46.Text = "Available 9:00-16:00";
                label47.Text = "Breakfast";
                label40.Text = "Drinks";
                label48.Text = "Basket";
                label21.Text = "Menu of Olympus";
                label50.Text = "Order\r\n\r\n";
                label49.Text = "Price\r\n\r\n";
                complete_button.Text = "Complete Purchase";

                label1.Text = "Appetizers";
                label15.Text = "Main Dishes";
                label25.Text = "Drinks";
                label10.Text = "Salads";
                label24.Text = "Desserts";
            }


            refresh_basket();
        }

    }
}
