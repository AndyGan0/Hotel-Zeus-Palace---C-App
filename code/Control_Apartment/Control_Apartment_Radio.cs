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
    public partial class Control_Apartment_Radio : Form
    {
        public Control_Apartment_Radio()
        {
            InitializeComponent();            

            ON_button_Click(null, null);
        }

        private void ON_button_Click(object sender, EventArgs e)
        {
            ON_button.BackColor = Color.Chartreuse;
            OFF_button.BackColor = DefaultBackColor;

            label1.Show();
            trackBar1.Show();

            ON_button.BackColor = Color.Chartreuse;
            OFF_button.BackColor = DefaultBackColor;

            OFF_button.Enabled = true;
            ON_button.Enabled = false;
        }

        private void OFF_button_Click(object sender, EventArgs e)
        {
            ON_button.BackColor = DefaultBackColor;
            OFF_button.BackColor = Color.Red;

            label1.Hide();
            trackBar1.Hide();

            ON_button.BackColor = DefaultBackColor;
            OFF_button.BackColor = Color.Red;

            OFF_button.Enabled = false;
            ON_button.Enabled = true;
        }

        public void setLanguageTo(string newlanguage)
        {
            if (newlanguage == "greek")
            {
                label1.Text = "Επιλέξτε Σταθμό:";

            }
            else if (newlanguage == "english")
            {
                label1.Text = "Choose station:";
            }
        }
    }
}
