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
    public partial class Control_Pool_sensor : Form
    {
        public Control_Pool_sensor()
        {
            InitializeComponent();

        }

        private void sensor_button_Click(object sender, EventArgs e)
        {

            if (sensor_button.Text == "ON")
            {
                label2.Hide();
                alarm_button.Hide();

                sensor_button.Text = "OFF";
                sensor_button.BackColor = Color.Red;
            }
            else
            {
                label2.Show();
                alarm_button.Show();

                sensor_button.Text = "ON";
                sensor_button.BackColor = Color.Chartreuse;
            }


        }

        private void alarm_button_Click(object sender, EventArgs e)
        {

            if (alarm_button.Text == "ON")
            {
                alarm_button.Text = "OFF";
                alarm_button.BackColor = Color.Red;
            }
            else
            {
                alarm_button.Text = "ON";
                alarm_button.BackColor = Color.Chartreuse;
            }
        }

        public void setLanguageTo(String newlanguage)
        {
            if (newlanguage == "greek")
            {
                label1.Text = "Αισθητήρας";
                label2.Text = "Συναγερμός";

            }
            else if (newlanguage == "english")
            {
                label1.Text = "Sensor";
                label2.Text = "Alarm";
            }


        }
    }
}
