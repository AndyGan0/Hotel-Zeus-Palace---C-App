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
    public partial class Control_Trojan_GPS : Form
    {
        public Control_Trojan_GPS(Boolean ADMIN_PERMS)
        {
            InitializeComponent();

            if (ADMIN_PERMS)
            {
                up_button.Hide();
                left_button.Hide();
                right_button.Hide();
                down_button.Hide();
            }
        }




        private void up_timer_Tick(object sender, EventArgs e)
        {
            if (pictureBox2.Location.Y <= 23)
            {
                return;
            }

            if ((pictureBox2.Location.X > 350) && (pictureBox2.Location.X < 900) && (pictureBox2.Location.Y <= 220))
            {
                return;
            }

            if ((pictureBox2.Location.X > 495) && (pictureBox2.Location.X < 780) && (pictureBox2.Location.Y <= 325))
            {
                return;
            }

            pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y - 20);
        }

        private void down_timer_Tick(object sender, EventArgs e)
        {
            if (pictureBox2.Location.Y > 380)
            {
                return;
            }

            pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y + 20);
        }

        private void right_timer_Tick(object sender, EventArgs e)
        {
            if (pictureBox2.Location.X >= 1070)
            {
                return;
            }

            if (pictureBox2.Location.Y < 210 && pictureBox2.Location.X >= 345 && pictureBox2.Location.X < 600)
            {
                return;
            }

            if (pictureBox2.Location.Y < 300 && pictureBox2.Location.X >= 485 && pictureBox2.Location.X < 600)
            {
                return;
            }
            pictureBox2.Location = new Point(pictureBox2.Location.X + 20, pictureBox2.Location.Y);
        }

        private void left_timer_Tick(object sender, EventArgs e)
        {
            if (pictureBox2.Location.X <= 200)
            {
                return;
            }

            if (pictureBox2.Location.Y < 210 && pictureBox2.Location.X <= 940 && pictureBox2.Location.X > 600)
            {
                return;
            }

            if (pictureBox2.Location.Y < 300 && pictureBox2.Location.X <= 800 && pictureBox2.Location.X > 600)
            {
                return;
            }
            pictureBox2.Location = new Point(pictureBox2.Location.X - 20, pictureBox2.Location.Y);
        }









        private void up_button_MouseDown(object sender, MouseEventArgs e)
        {
            up_timer.Start();
        }

        private void up_button_MouseUp(object sender, MouseEventArgs e)
        {
            up_timer.Stop();
        }

        private void right_button_MouseDown(object sender, MouseEventArgs e)
        {
            right_timer.Start();
        }

        private void right_button_MouseUp(object sender, MouseEventArgs e)
        {
            right_timer.Stop();
        }

        private void down_button_MouseDown(object sender, MouseEventArgs e)
        {
            down_timer.Start();
        }

        private void down_button_MouseUp(object sender, MouseEventArgs e)
        {
            down_timer.Stop();
        }

        private void left_button_MouseDown(object sender, MouseEventArgs e)
        {
            left_timer.Start();
        }

        private void left_button_MouseUp(object sender, MouseEventArgs e)
        {
            left_timer.Stop();
        }




        public void setLanguageTo(string newlanguage)
        {
            if (newlanguage == "greek")
            {
                up_button.Text = "ΜΠΡΟΣΤΑ";
                right_button.Text = "ΔΕΞΙΑ";
                left_button.Text = "ΑΡΙΣΤΕΡΑ";
                down_button.Text = "ΠΙΣΩ";

            }
            else if (newlanguage == "english")
            {
                up_button.Text = "UP";
                right_button.Text = "RIGHT";
                left_button.Text = "LEFT";
                down_button.Text = "DOWN";
            }
        }


    }
}
