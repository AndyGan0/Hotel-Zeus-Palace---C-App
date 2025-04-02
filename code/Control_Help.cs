using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace allhlepidrash
{
    public partial class Control_Help : Form
    {
        User user;

        String PreviousForm;

        int NextMessageY;

        public Control_Help(User user)
        {
            InitializeComponent();
            this.user = user;

            NextMessageY = 40;

            if (user.isEmployee)
            {
                label1.Hide();
                panel1.Hide();
                textBox1.Hide();
                send_message_button.Hide();
            }
        }

        public void setHelpForm(string form)
        {
            PreviousForm = form;
        }

        private void send_message_button_Click(object sender, EventArgs e)
        {
            String message = textBox1.Text;


            Label temp = new Label();
            temp.Text = message;
            temp.AutoSize = true;
            temp.MaximumSize = new Size(680, 2000);
            temp.BackColor = Color.PaleTurquoise;
            temp.Font = new Font("Segoe UI", 12);
            temp.BorderStyle = BorderStyle.FixedSingle;


            temp.TextAlign = ContentAlignment.TopRight;
            temp.Location = new Point(30, NextMessageY);

            Size Size_of_temp = temp.GetPreferredSize(new Size(680, 100));

            if (temp.Size.Width < 680)
            {
                int x = 710 - Size_of_temp.Width;

                temp.Location = new Point(x, NextMessageY);

            }


            panel1.Controls.Add(temp);

            PictureBox icon = new PictureBox();
            icon.SizeMode = PictureBoxSizeMode.Zoom;
            icon.Size = new Size(80, 80);

            icon.Image = Properties.Resources.customer;

            icon.Location = new Point(730, NextMessageY);



            icon.BackColor = Color.Transparent;
            panel1.Controls.Add(icon);


            if (Size_of_temp.Height + 30 < 100)
            {
                NextMessageY += 100;
            }
            else
            {
                NextMessageY += temp.Size.Height + 30;
            }





            receive_message("thx for staying in our hotel", "female");

        }


        private void receive_message(String message, String sender_gender)
        {


            Label temp = new Label();
            temp.Text = message;
            temp.AutoSize = true;
            temp.MaximumSize = new Size(680, 2000);
            temp.BackColor = Color.PaleTurquoise;
            temp.Font = new Font("Segoe UI", 12);
            temp.BorderStyle = BorderStyle.FixedSingle;
            temp.Location = new Point(140, NextMessageY);

            panel1.Controls.Add(temp);




            PictureBox icon = new PictureBox();
            icon.SizeMode = PictureBoxSizeMode.Zoom;
            icon.Size = new Size(80, 80);
            icon.Location = new Point(30, NextMessageY);
            if (sender_gender == "male")
            {
                icon.Image = Properties.Resources.ancient_god_male;
            }
            else
            {
                icon.Image = Properties.Resources.ancient_god_female;
            }
            icon.BackColor = Color.Transparent;

            panel1.Controls.Add(icon);




            if (temp.Size.Height + 30 < 100)
            {
                NextMessageY += 100;
            }
            else
            {
                NextMessageY += temp.Size.Height + 30;
            }

        }

        private void help_button_Click(object sender, EventArgs e)
        {

            if (user.isEmployee)
            {



                if (PreviousForm == "apartment")
                {
                    Help.ShowHelp(this, "help_employee.chm", HelpNavigator.TopicId, "30");
                }
                else if (PreviousForm == "pool")
                {
                    Help.ShowHelp(this, "help_employee.chm", HelpNavigator.TopicId, "40");
                }
                else if (PreviousForm == "trojan")
                {
                    Help.ShowHelp(this, "help_employee.chm", HelpNavigator.TopicId, "50");
                }
                else if (PreviousForm == "chat")
                {
                    Help.ShowHelp(this, "help_employee.chm", HelpNavigator.TopicId, "60");
                }
                else if (PreviousForm == "settings")
                {
                    Help.ShowHelp(this, "help_employee.chm", HelpNavigator.TopicId, "25");
                }
                else
                {
                    Help.ShowHelp(this, "help_employee.chm");
                }





            }
            else if (!user.isEmployee)
            {

                if (PreviousForm == "apartment")
                {
                    Help.ShowHelp(this, "help_customer.chm", HelpNavigator.TopicId, "30");
                }
                else if (PreviousForm == "pool")
                {
                    Help.ShowHelp(this, "help_customer.chm", HelpNavigator.TopicId, "40");
                }
                else if (PreviousForm == "trojan")
                {
                    Help.ShowHelp(this, "help_customer.chm", HelpNavigator.TopicId, "50");
                }
                else if (PreviousForm == "restaurant")
                {
                    Help.ShowHelp(this, "help_customer.chm", HelpNavigator.TopicId, "60");
                }
                else if (PreviousForm == "settings")
                {
                    Help.ShowHelp(this, "help_customer.chm", HelpNavigator.TopicId, "25");
                }
                else
                {
                    Help.ShowHelp(this, "help_customer.chm");
                }
            }


        }



        public void setLanguageTo(string newlanguage)
        {
            if (newlanguage == "greek")
            {
                label2.Text = "Λεωφ. Νέας Ερυθραίας 19, Νέα Ερυθραία 146 71\r\nΤηλέφωνο: +30 210 9853132 – 4, Φαξ: +30 210 9627055\r\ninfo@zeuspalace.gr – www.zeuspalace.gr\r\n\r\n";
                label5.Text = "Οδηγός Βοήθειας:";
                label4.Text = "Γενικές Πληροφορίες:";
                help_button.Text = "Κάντε κλικ εδώ για να ανοίξετε τον οδηγό";
                label1.Text = "Άμεση Επικοινωνία:";
                send_message_button.Text = "Αποστολή";
                textBox1.PlaceholderText = "Πληκτρολογίστε κάτι";

            }
            else if (newlanguage == "english")
            {
                label2.Text = "Λεωφ. Νέας Ερυθραίας 19, Νέα Ερυθραία 146 71\r\nPhone: +30 210 9853132 – 4, Fax: +30 210 9627055\r\ninfo@zeuspalace.gr – www.zeuspalace.gr\r\n\r\n";
                label5.Text = "Help Guide:";
                label4.Text = "General Information:";
                help_button.Text = "Click Here to Open the Guide";
                label1.Text = "Contact:";
                send_message_button.Text = "send";
                textBox1.PlaceholderText = "Type Something:";
            }
        }






    }
}