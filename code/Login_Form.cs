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
    public partial class Login_Form : Form
    {
        String Language;
        private String User_Type;
        public Login_Form(string user_type, String Language)
        {
            InitializeComponent();
            User_Type = user_type;
            if (User_Type == "customer")
            {
                label2.Visible = true;
            }
            this.Language = Language;

            if (Language == "english")
            {
                setLanguageTo(Language);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            User user = new User(User_Type);

            Main_Menu form = new Main_Menu(user, Language);
            form.ShowDialog();

            this.Close();
        }


        public void setLanguageTo(string newlanguage)
        {
            if (newlanguage == "greek")
            {
                label1.Text = "Καλώς Ορίσατε!";
                label2.Text = "Απολαύστε την διαμονή σας στο παλάτι του Δία!";
                button1.Text = "Σύνδεση";

            }
            else if (newlanguage == "english")
            {
                label1.Text = "Welcome!";
                label2.Text = "Enjoy your stay at Zeus' Palace!";
                button1.Text = "Log in";
            }
        }

    }
}
