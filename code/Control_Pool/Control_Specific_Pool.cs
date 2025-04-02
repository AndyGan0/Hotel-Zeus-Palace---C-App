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
    public partial class Control_Specific_Pool : Form
    {

        String Language;

        Control_Pool_water_level water_level_form;
        Control_Pool_temperature temperature_form;
        Control_Pool_sensor sensor_form;

        public Control_Specific_Pool(User user, String pool_type, String language)
        {
            InitializeComponent();

            Language = language;
            water_level_form = new Control_Pool_water_level();
            temperature_form = new Control_Pool_temperature();
            sensor_form = new Control_Pool_sensor();
                        

            water_level_form.TopLevel = false;
            water_level_form.TopMost = true;
            water_level_form.FormBorderStyle = FormBorderStyle.None;
            pool_controls_panel.Controls.Add(water_level_form);

            temperature_form.TopLevel = false;
            temperature_form.TopMost = true;
            temperature_form.FormBorderStyle = FormBorderStyle.None;
            pool_controls_panel.Controls.Add(temperature_form);

            sensor_form.TopLevel = false;
            sensor_form.TopMost = true;
            sensor_form.FormBorderStyle = FormBorderStyle.None;
            pool_controls_panel.Controls.Add(sensor_form);


            if (!user.isEmployee && pool_type == "public")
            {
                Sensor_button.Hide();
            }


            if (user.isEmployee && pool_type == "private")
            {
                Water_level_button.Location = new Point(Water_level_button.Location.X, Water_level_button.Location.Y + 120);
                Temperature_button.Location = new Point(Temperature_button.Location.X, Temperature_button.Location.Y + 120);
                Sensor_button.Location = new Point(Sensor_button.Location.X, Sensor_button.Location.Y + 120);

                label1.Show();
                comboBox1.Show();
                label2.Show();

                Water_level_button.Enabled = false;
                Temperature_button.Enabled = false;
                Sensor_button.Enabled = false;

                Water_level_button.BackColor = Color.Tan;
                Temperature_button.BackColor = Color.Tan;
                Sensor_button.BackColor = Color.Tan;
            }
            else
            {
                Water_level_button_Click(null, null);
            }



        }



        private void Water_level_button_Click(object sender, EventArgs e)
        {
            water_level_form.Show();
            temperature_form.Hide();
            sensor_form.Hide();

            Water_level_button.BackColor = Color.Wheat;
            Temperature_button.BackColor = Color.Beige;
            Sensor_button.BackColor = Color.Beige;
        }

        private void Temperature_button_Click(object sender, EventArgs e)
        {
            water_level_form.Hide();
            temperature_form.Show();
            sensor_form.Hide();

            Water_level_button.BackColor = Color.Beige;
            Temperature_button.BackColor = Color.Wheat;
            Sensor_button.BackColor = Color.Beige;
        }

        private void Sensor_button_Click(object sender, EventArgs e)
        {
            water_level_form.Hide();
            temperature_form.Hide();
            sensor_form.Show();

            Water_level_button.BackColor = Color.Beige;
            Temperature_button.BackColor = Color.Beige;
            Sensor_button.BackColor = Color.Wheat;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (label2.Visible)
            {
                label2.Hide();
            }

            Water_level_button.Enabled = true;
            Temperature_button.Enabled = true;
            Sensor_button.Enabled = true;


            Water_level_button.BackColor = Color.Beige;
            Temperature_button.BackColor = Color.Beige;
            Sensor_button.BackColor = Color.Beige;

            Water_level_button_Click(null, null);
        }

        public void setLanguageTo(string newlanguage)
        {
            Language = newlanguage;

            if (newlanguage == "greek")
            {
                label1.Text = "Επιλέξτε Ιδιωτική\r\n         Πισίνα:";
                label2.Text = "Επιλέξτε Ιδιωτική Πισίνα";
                Water_level_button.Text = "Στάθμη Νερού";
                Temperature_button.Text = "Θερμοκρασία";
                Sensor_button.Text = "Αισθητήρας";
            }
            else if (newlanguage == "english")
            {
                label1.Text = "Choose Private\r\n         Pool:";
                label2.Text = "Choose Private Pool";
                Water_level_button.Text = "Water Level";
                Temperature_button.Text = "Temperature";
                Sensor_button.Text = "Sensor";
            }

            water_level_form.setLanguageTo(Language);
            temperature_form.setLanguageTo(Language);
            sensor_form.setLanguageTo(Language);
        }



    }
}
