using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace allhlepidrash
{
    public partial class Control_Apartment_TV : Form
    {
        public Control_Apartment_TV()
        {
            InitializeComponent();

            ON_button_Click(null, null);

            button3.PerformClick();
        }



        private void OFF_button_Click(object sender, EventArgs e)
        {
            label1.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();
            button7.Hide();
            button8.Hide();
            button9.Hide();
            button10.Hide();
            button11.Hide();

            label2.Hide();
            label3.Hide();
            button13.Hide();
            button14.Hide();
            button15.Hide();
            button16.Hide();
            button17.Hide();

            pictureBox1.Hide();

            ON_button.BackColor = DefaultBackColor;
            OFF_button.BackColor = Color.Red;

            OFF_button.Enabled = false;
            ON_button.Enabled = true;
        }

        private void ON_button_Click(object sender, EventArgs e)
        {
            label1.Show();
            button3.Show();
            button4.Show();
            button5.Show();
            button6.Show();
            button7.Show();
            button8.Show();
            button9.Show();
            button10.Show();
            button11.Show();

            label2.Show();
            label3.Show();
            button13.Show();
            button14.Show();
            button15.Show();
            button16.Show();
            button17.Show();

            pictureBox1.Show();

            ON_button.BackColor = Color.Chartreuse;
            OFF_button.BackColor = DefaultBackColor;

            OFF_button.Enabled = true;
            ON_button.Enabled = false;


            button3.PerformClick();

        }

        private void setChannel(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(((Button)sender).BackgroundImage);

            pictureBox1.BackgroundImage = img;

        }

        public void setLanguageTo(string newlanguage)
        {
            if (newlanguage == "greek")
            {
                label1.Text = "Τοπικά Κανάλια:";
                label2.Text = "Διεθνή Κανάλια:";
                label3.Text = "Παίζεται αυτή την στιγμή:";

            }
            else if (newlanguage == "english")
            {
                label1.Text = "Global Channels:";
                label2.Text = "Local Channels:";
                label3.Text = "Currently Playing:";
            }
        }



    }
}
