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
    public partial class Control_Apartment : Form
    {

        
        Boolean ADMIN_control;

        Control_Apartment_Lights form_light;
        Control_Apartment_Temperature form_temperature;
        Control_Apartment_TV form_tv;
        Control_Apartment_Radio form_radio;

        public Control_Apartment(Boolean admin_control)
        {
            InitializeComponent();

            

            form_light = new Control_Apartment_Lights();
            form_temperature = new Control_Apartment_Temperature();
            form_tv = new Control_Apartment_TV();
            form_radio = new Control_Apartment_Radio();

            form_light.TopLevel = false;
            form_light.TopMost = true;
            form_light.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(form_light);

            form_temperature.TopLevel = false;
            form_temperature.TopMost = true;
            form_temperature.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(form_temperature);

            form_tv.TopLevel = false;
            form_tv.TopMost = true;
            form_tv.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(form_tv);

            form_radio.TopLevel = false;
            form_radio.TopMost = true;
            form_radio.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(form_radio);

            ADMIN_control = admin_control;


            if (ADMIN_control)
            {
                light_button.Location = new Point(light_button.Location.X, light_button.Location.Y + 120);
                temperature_button.Location = new Point(temperature_button.Location.X, temperature_button.Location.Y + 120);
                tv_button.Location = new Point(tv_button.Location.X, tv_button.Location.Y + 120);
                radio_button.Location = new Point(radio_button.Location.X, radio_button.Location.Y + 120);

                label1.Show();
                comboBox1.Show();
                label2.Show();

                light_button.Enabled = false;
                temperature_button.Enabled = false;
                tv_button.Enabled = false;
                radio_button.Enabled = false;

                light_button.BackColor = Color.Tan;
                temperature_button.BackColor = Color.Tan;
                tv_button.BackColor = Color.Tan;
                radio_button.BackColor = Color.Tan;

            }
            else
            {
                light_button_Click(null, null);
            }


            

        }

        private void light_button_Click(object sender, EventArgs e)
        {
            form_light.Show();
            form_temperature.Hide();
            form_tv.Hide();
            form_radio.Hide();

            light_button.BackColor = Color.Wheat;
            temperature_button.BackColor = Color.Beige;
            tv_button.BackColor = Color.Beige;
            radio_button.BackColor = Color.Beige;
        }

        private void temperature_button_Click(object sender, EventArgs e)
        {
            form_light.Hide();
            form_temperature.Show();
            form_tv.Hide();
            form_radio.Hide();

            light_button.BackColor = Color.Beige;
            temperature_button.BackColor = Color.Wheat;
            tv_button.BackColor = Color.Beige;
            radio_button.BackColor = Color.Beige;
        }

        private void tv_button_Click(object sender, EventArgs e)
        {
            form_light.Hide();
            form_temperature.Hide();
            form_tv.Show();
            form_radio.Hide();

            light_button.BackColor = Color.Beige;
            temperature_button.BackColor = Color.Beige;
            tv_button.BackColor = Color.Wheat;
            radio_button.BackColor = Color.Beige;
        }

        private void radio_button_Click(object sender, EventArgs e)
        {
            form_light.Hide();
            form_temperature.Hide();
            form_tv.Hide();
            form_radio.Show();

            light_button.BackColor = Color.Beige;
            temperature_button.BackColor = Color.Beige;
            tv_button.BackColor = Color.Beige;
            radio_button.BackColor = Color.Wheat;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (label2.Visible)
            {
                label2.Hide();
            }

            light_button.Enabled = true;
            temperature_button.Enabled = true;
            tv_button.Enabled = true;
            radio_button.Enabled = true;

            light_button.BackColor = Color.Beige;
            temperature_button.BackColor = Color.Beige;
            tv_button.BackColor = Color.Beige;
            radio_button.BackColor = Color.Beige;

            light_button_Click(null, null);
        }
    
    
        public void setLanguageTo(string newLanguage)
        {


            if (newLanguage == "greek")
            {
                label1.Text = "   Επιλέξτε \r\nΔιαμέρισμα:";
                light_button.Text = "Φώτα";
                temperature_button.Text = "Θερμοκρασία";
                tv_button.Text = "Τηλεόραση";
                radio_button.Text = "Ραδιόφωνο";
                label2.Text = "Επιλέξτε Διαμέρισμα";

            }
            else if (newLanguage == "english")
            {
                label1.Text = "   Choose \r\nApartment:";
                light_button.Text = "Lights";
                temperature_button.Text = "Temperature";
                tv_button.Text = "TV";
                radio_button.Text = "Radio";
                label2.Text = "Choose Apartment";

            }

            form_light.setLanguageTo(newLanguage);
            form_temperature.setLanguageTo(newLanguage);
            form_tv.setLanguageTo(newLanguage);
            form_radio.setLanguageTo(newLanguage);
        }
    
    }
}
