using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace allhlepidrash
{
    public partial class Control_Trojan : Form
    {

        Boolean ADMIN_PERM;

        Control_Apartment devices_form;
        Control_Trojan_GPS GPS_form;
        Control_Trojan_Door door_form = new Control_Trojan_Door();
        Control_Trojan_Lader lader_form = new Control_Trojan_Lader();

        public Control_Trojan(Boolean ADMIN_PERMISION)
        {
            InitializeComponent();


            ADMIN_PERM = ADMIN_PERMISION;

            GPS_form = new Control_Trojan_GPS(ADMIN_PERM);


            devices_form = new Control_Apartment(false);
            

            devices_form.TopLevel = false;
            devices_form.TopMost = true;
            devices_form.FormBorderStyle = FormBorderStyle.None;
            trojan_controls_panel.Controls.Add(devices_form);

            GPS_form.TopLevel = false;
            GPS_form.TopMost = true;
            GPS_form.FormBorderStyle = FormBorderStyle.None;
            trojan_controls_panel.Controls.Add(GPS_form);

            door_form.TopLevel = false;
            door_form.TopMost = true;
            door_form.FormBorderStyle = FormBorderStyle.None;
            trojan_controls_panel.Controls.Add(door_form);

            lader_form.TopLevel = false;
            lader_form.TopMost = true;
            lader_form.FormBorderStyle = FormBorderStyle.None;
            trojan_controls_panel.Controls.Add(lader_form);


            if (ADMIN_PERMISION)
            {
                device_button.Location = new Point(device_button.Location.X, device_button.Location.Y + 120);
                driving_GPS_button.Location = new Point(driving_GPS_button.Location.X, driving_GPS_button.Location.Y + 120);
                door_button.Location = new Point(door_button.Location.X, door_button.Location.Y + 120);
                stairs_button.Location = new Point(stairs_button.Location.X, stairs_button.Location.Y + 120);

                label1.Show();
                comboBox1.Show();
                label2.Show();

                device_button.Enabled = false;
                driving_GPS_button.Enabled = false;
                door_button.Enabled = false;
                stairs_button.Enabled = false;

                device_button.BackColor = Color.Tan;
                driving_GPS_button.BackColor = Color.Tan;
                door_button.BackColor = Color.Tan;
                stairs_button.BackColor = Color.Tan;

            }
            else
            {
                device_button_Click(null, null);
            }
        }

        private void device_button_Click(object sender, EventArgs e)
        {
            devices_form.Show();
            GPS_form.Hide();
            door_form.Hide();
            lader_form.Hide();

            device_button.BackColor = Color.Wheat;
            driving_GPS_button.BackColor = Color.Beige;
            door_button.BackColor = Color.Beige;
            stairs_button.BackColor = Color.Beige;

            device_button.Enabled = false;
            driving_GPS_button.Enabled = true;
            door_button.Enabled = true;
            stairs_button.Enabled = true;
        }

        private void driving_GPS_button_Click(object sender, EventArgs e)
        {
            devices_form.Hide();
            GPS_form.Show();
            door_form.Hide();
            lader_form.Hide();

            device_button.BackColor = Color.Beige;
            driving_GPS_button.BackColor = Color.Wheat;
            door_button.BackColor = Color.Beige;
            stairs_button.BackColor = Color.Beige;

            device_button.Enabled = true;
            driving_GPS_button.Enabled = false;
            door_button.Enabled = true;
            stairs_button.Enabled = true;
        }

        private void door_button_Click(object sender, EventArgs e)
        {
            devices_form.Hide();
            GPS_form.Hide();
            door_form.Show();
            lader_form.Hide();

            device_button.BackColor = Color.Beige;
            driving_GPS_button.BackColor = Color.Beige;
            door_button.BackColor = Color.Wheat;
            stairs_button.BackColor = Color.Beige;

            device_button.Enabled = true;
            driving_GPS_button.Enabled = true;
            door_button.Enabled = false;
            stairs_button.Enabled = true;
        }

        private void stairs_button_Click(object sender, EventArgs e)
        {
            devices_form.Hide();
            GPS_form.Hide();
            door_form.Hide();
            lader_form.Show();

            device_button.BackColor = Color.Beige;
            driving_GPS_button.BackColor = Color.Beige;
            door_button.BackColor = Color.Beige;
            stairs_button.BackColor = Color.Wheat;

            device_button.Enabled = true;
            driving_GPS_button.Enabled = true;
            door_button.Enabled = true;
            stairs_button.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (label2.Visible)
            {
                label2.Hide();
            }

            device_button.Enabled = true;
            driving_GPS_button.Enabled = true;
            door_button.Enabled = true;
            stairs_button.Enabled = true;


            device_button.BackColor = Color.Beige;
            driving_GPS_button.BackColor = Color.Beige;
            door_button.BackColor = Color.Beige;
            stairs_button.BackColor = Color.Beige;

            device_button_Click(null, null);
        }


        public void setLanguageTo(string newlanguage)
        {
            if (newlanguage == "greek")
            {
                label1.Text = "Επιλέξτε Δούρειο \r\n         Ίππο:";
                label2.Text = "Επιλέξτε Δούρειο Ίππο";
                device_button.Text = "Συσκευες";
                driving_GPS_button.Text = "Οδήγηση-GPS";
                door_button.Text = "Πόρτες";
                stairs_button.Text = "Σκάλα";

            }
            else if (newlanguage == "english")
            {
                label1.Text = "Choose Trojan \r\n         Horse:";
                label2.Text = "Choose Trojan Horse";
                device_button.Text = "Devices";
                driving_GPS_button.Text = "driving-GPS";
                door_button.Text = "Doors";
                stairs_button.Text = "Ladder";
            }

            devices_form.setLanguageTo(newlanguage);
            GPS_form.setLanguageTo(newlanguage);
            door_form.setLanguageTo(newlanguage);
            lader_form.setLanguageTo(newlanguage);
        }

    }
}
