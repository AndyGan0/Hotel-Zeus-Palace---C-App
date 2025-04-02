using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace allhlepidrash
{
    public partial class Control_Orders_employee : Form
    {


        User user;

        List<Button> Conversations = new List<Button>();
        List<Label> messages = new List<Label>();
        List<PictureBox> icons = new List<PictureBox>();

        int NextMessageY;

        public Control_Orders_employee(User user)
        {
            InitializeComponent();

            this.user = user;

            List<String> conversations = user.employee_get_new_messages();

            int y = 5;

            foreach (String s in conversations)
            {
                Button temp = new Button();
                temp.Size = new Size(300, 55);
                temp.Cursor = Cursors.Hand;
                temp.Text = s.ToString();
                temp.Click += make_conversation;
                temp.TabStop = false;

                panel1.Controls.Add(temp);
                temp.Location = new Point(0, y);

                Conversations.Add(temp);

                y += 55;
            }

            make_conversation(Conversations[0], null);
        }


        private void make_conversation(object sender, EventArgs e)
        {
            /*
             Clear already existing ones
             */
            foreach (Label l in messages)
            {
                panel2.Controls.Remove(l);
            }
            foreach (PictureBox p in icons)
            {
                panel2.Controls.Remove(p);
            }
            messages.Clear();
            icons.Clear();


            /*
             *  Add new ones
             */





            List<List<String>> conversation = user.get_conversations(((Button)sender).Text);


            int y = 50;

            foreach (List<String> message in conversation)
            {

                String person_sender = message[0];
                String text_message = message[1];



                Label temp = new Label();
                temp.Text = text_message;



                temp.AutoSize = true;



                temp.MaximumSize = new Size(720, 2000);
                temp.BackColor = Color.PaleTurquoise;
                temp.Font = new Font("Segoe UI", 12);
                temp.BorderStyle = BorderStyle.FixedSingle;


                if (person_sender == "customer")
                {
                    temp.Location = new Point(140, y);
                }
                else if (person_sender == "employee")
                {
                    temp.TextAlign = ContentAlignment.TopRight;
                    temp.Location = new Point(30, y);

                    if (temp.Size.Width < 720)
                    {
                        Size Size_of_temp = temp.GetPreferredSize(new Size(720, 100));
                        int x = 750 - Size_of_temp.Width;

                        temp.Location = new Point(x, y);

                    }




                }

                panel2.Controls.Add(temp);

                PictureBox icon = new PictureBox();
                icon.SizeMode = PictureBoxSizeMode.Zoom;
                icon.Size = new Size(80, 80);

                if (person_sender == "customer")
                {
                    icon.Location = new Point(30, y);

                    icon.Image = Properties.Resources.customer;
                }
                else if (person_sender == "employee")
                {
                    icon.Location = new Point(770, y);
                    if (user.gender == "male")
                    {
                        icon.Image = Properties.Resources.ancient_god_male;
                    }
                    else
                    {
                        icon.Image = Properties.Resources.ancient_god_female;
                    }
                    
                }


                icon.BackColor = Color.Transparent;
                panel2.Controls.Add(icon);


                if (temp.Size.Height + 30 < 100)
                {
                    y += 100;
                }
                else
                {
                    y += temp.Size.Height + 30;
                }

                NextMessageY = y;

                messages.Add(temp);
                icons.Add(icon);


            }


        }

        private void send_message_button_Click(object sender, EventArgs e)
        {
            String message = textBox1.Text;
            if (message == "") { return; }


            Label temp = new Label();
            temp.Text = message;
            temp.AutoSize = true;
            temp.MaximumSize = new Size(720, 2000);
            temp.BackColor = Color.PaleTurquoise;
            temp.Font = new Font("Segoe UI", 12);
            temp.BorderStyle = BorderStyle.FixedSingle;


            temp.TextAlign = ContentAlignment.TopRight;
            temp.Location = new Point(30, NextMessageY);

            Size Size_of_temp = temp.GetPreferredSize(new Size(720, 100));

            if (temp.Size.Width < 720)
            {
                int x = 750 - Size_of_temp.Width;

                temp.Location = new Point(x, NextMessageY);

            }


            panel2.Controls.Add(temp);

            PictureBox icon = new PictureBox();
            icon.SizeMode = PictureBoxSizeMode.Zoom;
            icon.Size = new Size(80, 80);
            if (user.gender == "male")
            {
                icon.Image = Properties.Resources.ancient_god_male;
            }
            else
            {
                icon.Image = Properties.Resources.ancient_god_female;
            }

            icon.Location = new Point(770, NextMessageY);



            icon.BackColor = Color.Transparent;
            panel2.Controls.Add(icon);


            if (Size_of_temp.Height + 30 < 100)
            {
                NextMessageY += 100;
            }
            else
            {
                NextMessageY += temp.Size.Height + 30;
            }


            messages.Add(temp);
            icons.Add(icon);
        }
    
    
    
        public void setLanguageTo(string newlanguage)
        {
            if (newlanguage == "greek")
            {
                label1.Text = "Πελάτες";
                label2.Text = "Συνομιλία";
                textBox1.PlaceholderText = "Πληκτρολογίστε κάτι";
                send_message_button.Text = "Αποστολή";


            }
            else if (newlanguage == "english")
            {
                label1.Text = "Customers";
                label2.Text = "Conversations";
                textBox1.PlaceholderText = "Type Here";
                send_message_button.Text = "Send";
            }
        }
    
    
    
    
    
    
    
    
    
    
    
    }
}
