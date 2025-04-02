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
    public partial class Control_Pool_water_level : Form
    {
        public Control_Pool_water_level()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button6.Enabled = true;

            button1.BackColor = Color.Beige;
            button2.BackColor = Color.Beige;
            button3.BackColor = Color.Beige;
            button4.BackColor = Color.Beige;
            button6.BackColor = Color.Beige;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = true;
            button6.Enabled = true;

            button1.BackColor = Color.Cyan;
            button2.BackColor = Color.Cyan;
            button3.BackColor = Color.Beige;
            button4.BackColor = Color.Beige;
            button6.BackColor = Color.Beige;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = true;
            button6.Enabled = true;

            button1.BackColor = Color.Cyan;
            button2.BackColor = Color.Cyan;
            button3.BackColor = Color.Cyan;
            button4.BackColor = Color.Beige;
            button6.BackColor = Color.Beige;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = false;
            button6.Enabled = true;

            button1.BackColor = Color.Cyan;
            button2.BackColor = Color.Cyan;
            button3.BackColor = Color.Cyan;
            button4.BackColor = Color.Cyan;
            button6.BackColor = Color.Beige;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button6.Enabled = false;

            button1.BackColor = Color.Cyan;
            button2.BackColor = Color.Cyan;
            button3.BackColor = Color.Cyan;
            button4.BackColor = Color.Cyan;
            button6.BackColor = Color.Cyan;
        }

        public void setLanguageTo(string newlanguage)
        {
            if (newlanguage == "greek")
            {
                label1.Text = "Επιλέξτε το επίπεδο νερού που θέλετε:";

            }
            else if (newlanguage == "english")
            {
                label1.Text = "Choose  the ideal water level:";
            }
        }


    }
}
