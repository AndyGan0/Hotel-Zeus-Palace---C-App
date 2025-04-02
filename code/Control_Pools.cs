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
    public partial class Control_Pools : Form
    {
        User user;
        String Language;

        Control_Specific_Pool form_public_pool;
        Control_Specific_Pool form_private_pool;


        public Control_Pools(User user, String language)
        {
            InitializeComponent();

            this.user = user;
            Language = language;

            form_private_pool = new Control_Specific_Pool(user, "private", Language);
            form_public_pool = new Control_Specific_Pool(user, "public", Language);

            


            form_private_pool.TopLevel = false;
            form_private_pool.TopMost = true;
            form_private_pool.FormBorderStyle = FormBorderStyle.None;
            pool_controls_panel.Controls.Add(form_private_pool);

            form_public_pool.TopLevel = false;
            form_public_pool.TopMost = true;
            form_public_pool.FormBorderStyle = FormBorderStyle.None;
            pool_controls_panel.Controls.Add(form_public_pool);



        }


        private void Private_Pool_Button_Click(object sender, EventArgs e)
        {
            form_private_pool.Show();
            form_public_pool.Hide();

            Private_Pool_Button.BackColor = Color.Wheat;
            Public_Pool_button.BackColor = Color.Beige;

            Private_Pool_Button.Enabled = false;
            Public_Pool_button.Enabled = true;
        }


        private void Public_Pool_button_Click(object sender, EventArgs e)
        {
            form_private_pool.Hide();
            form_public_pool.Show();

            Private_Pool_Button.BackColor = Color.Beige;
            Public_Pool_button.BackColor = Color.Wheat;

            Private_Pool_Button.Enabled = true;
            Public_Pool_button.Enabled = false;
        }


        public void setLanguageTo(string newlanguage)
        {
            Language = newlanguage;

            if (newlanguage == "greek")
            {
                label2.Text = "Επιλέξτε Ιδιωτική ή Κεντρική Πισίνα";
                Private_Pool_Button.Text = "Ιδιωτική\r\nΠισίνα";
                Public_Pool_button.Text = "Κεντρική\r\nΠισίνα";
            }
            else if (newlanguage == "english")
            {
                label2.Text = "Choose either Private or Public Pool";
                Private_Pool_Button.Text = "Private\r\nPool";
                Public_Pool_button.Text = "Public\r\nPool";
            }

            form_public_pool.setLanguageTo(Language);
            form_private_pool.setLanguageTo(Language);

        }

    }
}
