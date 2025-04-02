using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace allhlepidrash
{
    public partial class Main_Menu : Form
    {

        User user;

        String Language;

        Control_Apartment form_apartment;
        Control_Pools form_pool;
        Control_Trojan form_trojan;
        Control_Restaurant form_restaurant;
        Control_Orders_employee form_employee_chat;
        Control_Settings form_settings;
        Control_Help form_help;



        Font menuFont = new Font("Bodoni MT Condensed", 50);
        Font controlMenuFont = new Font("OCR A Extended", 20, FontStyle.Bold);

        Form Backtrack_Form;



        public Main_Menu(User user, String language)
        {
            InitializeComponent();

            this.user = user;
            Language = language;



            form_settings = new Control_Settings(user, Language, this);
            form_help = new Control_Help(user);
            form_pool = new Control_Pools(user, Language);
            form_restaurant = new Control_Restaurant(false, Language);

            if (user.isEmployee)
            {
                form_apartment = new Control_Apartment(true);
                form_trojan = new Control_Trojan(true);


                if (Language == "greek")
                {
                    Restaurant_button.Text = "Εξυπηρέτηση πελατών";
                }
                else
                {
                    Restaurant_button.Text = "Customer Support";
                }
                form_employee_chat = new Control_Orders_employee(user);

                form_employee_chat.TopLevel = false;
                form_employee_chat.TopMost = true;
                form_employee_chat.FormBorderStyle = FormBorderStyle.None;
                Form_panel.Controls.Add(form_employee_chat);
            }
            else
            {
                form_apartment = new Control_Apartment(false);
                form_trojan = new Control_Trojan(false);

                form_restaurant.TopLevel = false;
                form_restaurant.TopMost = true;
                form_restaurant.FormBorderStyle = FormBorderStyle.None;
                Form_panel.Controls.Add(form_restaurant);
            }

            form_pool.TopLevel = false;
            form_pool.TopMost = true;
            form_pool.FormBorderStyle = FormBorderStyle.None;
            Form_panel.Controls.Add(form_pool);

            form_trojan.TopLevel = false;
            form_trojan.TopMost = true;
            form_trojan.FormBorderStyle = FormBorderStyle.None;
            Form_panel.Controls.Add(form_trojan);

            form_apartment.TopLevel = false;
            form_apartment.TopMost = true;
            form_apartment.FormBorderStyle = FormBorderStyle.None;
            Form_panel.Controls.Add(form_apartment);



            form_settings.TopLevel = false;
            form_settings.TopMost = true;
            form_settings.FormBorderStyle = FormBorderStyle.None;
            Form_panel.Controls.Add(form_settings);

            form_help.TopLevel = false;
            form_help.TopMost = true;
            form_help.FormBorderStyle = FormBorderStyle.None;
            Form_panel.Controls.Add(form_help);

            Backtrack_Form = null;

            if (Language == "english")
            {
                setLanguageTo(Language);
            }
        }

        private void Apartment_Button_Click(object sender, EventArgs e)
        {

            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox5.Hide();
            pictureBox6.Hide();
            pictureBox7.Hide();
            pictureBox8.Hide();
            pictureBox9.Hide();
            pictureBox10.Hide();
            pictureBox11.Hide();
            pictureBox12.Hide();
            pictureBox13.Hide();

            label1.Font = controlMenuFont;

            if (Language == "greek")
            {
                label1.Text = "Διαχείριση Συσκευών Διαμερίσματος";
            }
            else
            {
                label1.Text = "Apartment Device Management";
            }

            Form_panel.Show();

            Apartment_Button.Hide();
            Pool_Button.Hide();
            Trojan_Horse_Button.Hide();
            Restaurant_button.Hide();
            Settings_button.Hide();
            Home_Button.Show();

            form_apartment.Show();
        }

        private void Pool_Button_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox5.Hide();
            pictureBox6.Hide();
            pictureBox7.Hide();
            pictureBox8.Hide();
            pictureBox9.Hide();
            pictureBox10.Hide();
            pictureBox11.Hide();
            pictureBox12.Hide();
            pictureBox13.Hide();


            label1.Font = controlMenuFont;

            if (Language == "greek")
            {
                label1.Text = "Διαχείριση Πισίνας";
            }
            else
            {
                label1.Text = "Pool Management";
            }

            Form_panel.Show();

            Apartment_Button.Hide();
            Pool_Button.Hide();
            Trojan_Horse_Button.Hide();
            Restaurant_button.Hide();
            Settings_button.Hide();
            Home_Button.Show();

            form_pool.Show();

        }

        private void Trojan_Horse_Button_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox5.Hide();
            pictureBox6.Hide();
            pictureBox7.Hide();
            pictureBox8.Hide();
            pictureBox9.Hide();
            pictureBox10.Hide();
            pictureBox11.Hide();
            pictureBox12.Hide();
            pictureBox13.Hide();

            label1.Font = controlMenuFont;

            if (Language == "greek")
            {
                label1.Text = "Διαχείριση Δούρειου Ίππου";
            }
            else
            {
                label1.Text = "Trojan Horse Management";
            }

            Form_panel.Show();

            Apartment_Button.Hide();
            Pool_Button.Hide();
            Trojan_Horse_Button.Hide();
            Restaurant_button.Hide();
            Settings_button.Hide();
            Home_Button.Show();

            form_trojan.Show();
        }

        private void Restaurant_button_click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox5.Hide();
            pictureBox6.Hide();
            pictureBox7.Hide();
            pictureBox8.Hide();
            pictureBox9.Hide();
            pictureBox10.Hide();
            pictureBox11.Hide();
            pictureBox12.Hide();
            pictureBox13.Hide();

            label1.Font = controlMenuFont;


            Form_panel.Show();

            Apartment_Button.Hide();
            Pool_Button.Hide();
            Trojan_Horse_Button.Hide();
            Restaurant_button.Hide();
            Settings_button.Hide();
            Home_Button.Show();

            if (user.isEmployee)
            {
                if (Language == "greek")
                {
                    label1.Text = "Εξυπηρέτηση πελατών";
                }
                else
                {
                    label1.Text = "Customer Support";
                }

                form_employee_chat.Show();
            }
            else
            {
                if (Language == "greek")
                {
                    label1.Text = "Εστιατόριο";
                }
                else
                {
                    label1.Text = "Restaurant";
                }

                form_restaurant.Show();
            }
        }

        private void Settings_button_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox5.Hide();
            pictureBox6.Hide();
            pictureBox7.Hide();
            pictureBox8.Hide();
            pictureBox9.Hide();
            pictureBox10.Hide();
            pictureBox11.Hide();
            pictureBox12.Hide();
            pictureBox13.Hide();

            label1.Font = controlMenuFont;

            if (Language == "greek")
            {
                label1.Text = "Ρυθμίσεις";
            }
            else
            {
                label1.Text = "Settings";
            }

            Form_panel.Show();

            Apartment_Button.Hide();
            Pool_Button.Hide();
            Trojan_Horse_Button.Hide();
            Restaurant_button.Hide();
            Settings_button.Hide();
            Home_Button.Show();

            form_settings.Show();
        }

        private void Home_Button_Click(object sender, EventArgs e)
        {
            pictureBox1.Show();
            pictureBox2.Show();
            pictureBox3.Show();
            pictureBox4.Show();
            pictureBox5.Show();
            pictureBox6.Show();
            pictureBox7.Show();
            pictureBox8.Show();
            pictureBox9.Show();
            pictureBox10.Show();
            pictureBox11.Show();
            pictureBox12.Show();
            pictureBox13.Show();


            label1.Font = menuFont;
            if (Language == "greek")
            {
                label1.Text = "ΠΑΛΑΤΙ ΤΟΥ ΔΙΑ";
            }
            else
            {
                label1.Text = "ZEUS' PALACE";
            }



            Form_panel.Hide();

            Apartment_Button.Show();
            Pool_Button.Show();
            Trojan_Horse_Button.Show();
            Restaurant_button.Show();
            Settings_button.Show();
            Home_Button.Hide();

            form_apartment.Hide();
            form_pool.Hide();
            form_trojan.Hide();
            if (user.isEmployee)
            {
                form_employee_chat.Hide();
            }
            else
            {
                form_restaurant.Hide();
            }
            form_settings.Hide();
            form_help.Hide();

        }

        private void Help_Button_Click(object sender, EventArgs e)
        {
            /* If user presses help button 2nd time to hide help screen */
            if (form_help.Visible)
            {

                if (Backtrack_Form != null)
                {
                    // previous screen was Backtrack_Form
                    Backtrack_Form.Show();
                    form_help.Hide();

                    label1.Font = controlMenuFont;
                    if (Backtrack_Form == form_apartment)
                    {
                        label1.Text = "Διαχείριση Συσκευών Διαμερίσματος";
                    }
                    else if (Backtrack_Form == form_pool)
                    {
                        label1.Text = "Διαχείριση Πισίνας";
                    }
                    else if (Backtrack_Form == form_trojan)
                    {
                        label1.Text = "Διαχείριση Δούρειου Ίππου";
                    }

                    else if (Backtrack_Form == form_restaurant)
                    {
                        label1.Text = "Εστιατόριο";
                    }
                    else if (Backtrack_Form == form_employee_chat)
                    {
                        label1.Text = "Εξυπηρέτηση πελατών";
                    }
                    else if (Backtrack_Form == form_settings)
                    {
                        label1.Text = "Ρυθμίσεις";
                    }

                }
                else
                {
                    // previous screen was menu. We need to show Main menu
                    Home_Button_Click(null, null);
                }

                form_help.Hide();
                Backtrack_Form = null;
                return;


            }


            /* If user presses help button first time to show help */
            if (form_apartment.Visible)
            {
                Backtrack_Form = form_apartment;
                form_help.setHelpForm("apartment");
            }
            else if (form_pool.Visible)
            {
                Backtrack_Form = form_pool;
                form_help.setHelpForm("pool");
            }
            else if (form_trojan.Visible)
            {
                Backtrack_Form = form_trojan;
                form_help.setHelpForm("trojan");
            }
            else if (form_restaurant.Visible)
            {
                Backtrack_Form = form_restaurant;
                form_help.setHelpForm("restaurant");
            }
            else if (user.isEmployee && form_employee_chat.Visible)
            {
                Backtrack_Form = form_employee_chat;
                form_help.setHelpForm("chat");
            }
            else if (form_settings.Visible)
            {
                Backtrack_Form = form_settings;
                form_help.setHelpForm("settings");
            }
            else
            {
                Backtrack_Form = null;
                form_help.setHelpForm(null);

                pictureBox1.Hide();
                pictureBox2.Hide();
                pictureBox3.Hide();
                pictureBox4.Hide();
                pictureBox5.Hide();
                pictureBox6.Hide();
                pictureBox7.Hide();
                pictureBox8.Hide();
                pictureBox9.Hide();
                pictureBox10.Hide();
                pictureBox11.Hide();
                pictureBox12.Hide();
                pictureBox13.Hide();

                Form_panel.Show();

                Pool_Button.Hide();
                Trojan_Horse_Button.Hide();
                Apartment_Button.Hide();
                Restaurant_button.Hide();
                Settings_button.Hide();
                Home_Button.Show();
            }



            form_help.Show();
            if (Backtrack_Form != null)
            {
                Backtrack_Form.Hide();
                if (Language == "greek")
                {
                    label1.Text += " Βοήθεια";
                }
                else
                {
                    label1.Text += " Help";
                }

            }


        }

        public void setLanguageTo(string newlanguage)
        {
            if (Form_panel.Visible)
            {
                Home_Button_Click(null, null);
            }

            Language = newlanguage;

            if (newlanguage == "greek")
            {
                Home_Button.Text = "Επιστροφη";
                label1.Text = "ΠΑΛΑΤΙ ΤΟΥ ΔΙΑ";
                Apartment_Button.Text = "Διαμέρισμα";
                Pool_Button.Text = "Πισίνα";
                Trojan_Horse_Button.Text = "Δούρειος Ίππος";
                if (user.isEmployee)
                {
                    Restaurant_button.Text = "Εξυπηρέτηση πελατών";
                }
                else
                {

                    Restaurant_button.Text = "Φαγητό";
                }
                Settings_button.Text = "Ρυθμίσεις";
                Help_Button.Text = "Βοήθεια";

            }
            else if (newlanguage == "english")
            {
                Home_Button.Text = "Return";
                label1.Text = "ZEUS' PALACE";
                Apartment_Button.Text = "Apartment";
                Pool_Button.Text = "Pool";
                Trojan_Horse_Button.Text = "Trojan Horse";
                if (user.isEmployee)
                {
                    Restaurant_button.Text = "Customer Support";
                }
                else
                {

                    Restaurant_button.Text = "Restaurant";
                }
                Settings_button.Text = "Settings";
                Help_Button.Text = "Help";
            }

            form_apartment.setLanguageTo(Language);
            form_pool.setLanguageTo(Language);
            form_trojan.setLanguageTo(Language);
            form_settings.setLanguageTo(newlanguage);
            form_restaurant.setLanguageTo(newlanguage);
            form_help.setLanguageTo(newlanguage);
            if (user.isEmployee)
            {
                form_employee_chat.setLanguageTo(newlanguage);
            }


        }



        private void Apartment_Button_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources._4;
            ((Button)sender).Text = "";
        }
        private void Apartment_Button_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = null;
            if (Language == "english")
            {
                ((Button)sender).Text = "Apartment";
            }
            else
            {
                ((Button)sender).Text = "Διαμέρισμα";
            }
        }

        private void Pool_Button_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources._3;
            ((Button)sender).Text = "";
        }

        private void Pool_Button_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = null;
            if (Language == "english")
            {
                ((Button)sender).Text = "Pool";
            }
            else
            {
                ((Button)sender).Text = "Πισίνα";
            }
        }

        private void Trojan_Horse_Button_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources._1;
            ((Button)sender).Text = "";
        }

        private void Trojan_Horse_Button_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = null;
            if (Language == "english")
            {
                ((Button)sender).Text = "Trojan Horse";
            }
            else
            {
                ((Button)sender).Text = "Δούρειος Ίππος";
            }
        }

        private void Restaurant_button_MouseEnter(object sender, EventArgs e)
        {

            if (user.isEmployee)
            {
                ((Button)sender).BackgroundImage = Properties.Resources._5;
                ((Button)sender).Text = "";
            } 
            else
            {
                ((Button)sender).BackgroundImage = Properties.Resources._2;
                ((Button)sender).Text = "";
            }
            
        }        

        private void Restaurant_button_MouseLeave(object sender, EventArgs e)
        {
            if (user.isEmployee)
            {


                ((Button)sender).BackgroundImage = null;
                if (Language == "english")
                {
                    ((Button)sender).Text = "Customer Support";
                }
                else
                {
                    ((Button)sender).Text = "Εξυπηρέτηση πελατών";
                }


            }
            else
            {

                ((Button)sender).BackgroundImage = null;
                if (Language == "english")
                {
                    ((Button)sender).Text = "Restaurant";
                }
                else
                {
                    ((Button)sender).Text = "Φαγητό";
                }



            }
        }
    }
}
