using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace allhlepidrash
{
    public partial class Control_Settings : Form
    {
        Main_Menu main_form;
        String Language;
        User user;

        public Control_Settings(User user, string language, Main_Menu main_form)
        {
            InitializeComponent();
            this.user = user;
            Language = language;
            this.main_form = main_form;
        }

        private void Password_change_button_Click(object sender, EventArgs e)
        {
            Change_Password form_password = new Change_Password(user, Language);
            form_password.ShowDialog();
        }

        public void setLanguageTo(string newlanguage)
        {
            Language = newlanguage;
            if (newlanguage == "greek")
            {
                Password_change_button.Text = "Αλλαγή Κωδικού";
                button2.Text = "Αλλαγή γλώσσας";

            }
            else if (newlanguage == "english")
            {
                Password_change_button.Text = "Change Password";
                button2.Text = "Change Language";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = !pictureBox1.Visible;
            pictureBox2.Visible = !pictureBox2.Visible;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            pictureBox2.Hide();
            main_form.setLanguageTo("english");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            pictureBox2.Hide();
            main_form.setLanguageTo("greek");
        }
    }
}
