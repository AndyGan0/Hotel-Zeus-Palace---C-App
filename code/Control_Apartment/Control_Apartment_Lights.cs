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
    public partial class Control_Apartment_Lights : Form
    {

        public Control_Apartment_Lights()
        {
            InitializeComponent();
        }

        private void bedroom_lights_button_Click(object sender, EventArgs e)
        {
            if (bedroom_lights_button.Text == "ON")
            {
                bedroom_lights_button.Text = "OFF";
                bedroom_lights_button.BackColor = Color.Red;
            }
            else
            {
                bedroom_lights_button.Text = "ON";
                bedroom_lights_button.BackColor = Color.Chartreuse;
            }

            if (bedroom_lights_button.Text == "OFF" && balcony_lights_button.Text == "OFF" && bathroom_lights_button.Text == "OFF")
            {
                pictureBox1.Image = Properties.Resources.turned_off_light;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.turned_on_light;
            }
        }

        private void balcony_lights_button_Click(object sender, EventArgs e)
        {
            if (balcony_lights_button.Text == "ON")
            {
                balcony_lights_button.Text = "OFF";
                balcony_lights_button.BackColor = Color.Red;
            }
            else
            {
                balcony_lights_button.Text = "ON";
                balcony_lights_button.BackColor = Color.Chartreuse;
            }

            if (bedroom_lights_button.Text == "OFF" && balcony_lights_button.Text == "OFF" && bathroom_lights_button.Text == "OFF")
            {
                pictureBox1.Image = Properties.Resources.turned_off_light;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.turned_on_light;
            }
        }

        private void bathroom_lights_button_Click(object sender, EventArgs e)
        {
            if (bathroom_lights_button.Text == "ON")
            {
                bathroom_lights_button.Text = "OFF";
                bathroom_lights_button.BackColor = Color.Red;
            }
            else
            {
                bathroom_lights_button.Text = "ON";
                bathroom_lights_button.BackColor = Color.Chartreuse;
            }

            if (bedroom_lights_button.Text == "OFF" && balcony_lights_button.Text == "OFF" && bathroom_lights_button.Text == "OFF")
            {
                pictureBox1.Image = Properties.Resources.turned_off_light;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.turned_on_light;
            }
        }


        public void setLanguageTo(string newlanguage)
        {
            if (newlanguage == "greek")
            {
                label1.Text = "Φώτα Μπάνιου:";
                label2.Text = "Φώτα Υπνοδωματίου:";
                label3.Text = "Φώτα Μπαλκονιού:";
            }
            else if (newlanguage == "english")
            {
                label1.Text = "Bathroom Lights:";
                label2.Text = "Bedroom Lights";
                label3.Text = "Balcony Lights";
            }

        }




    }
}
