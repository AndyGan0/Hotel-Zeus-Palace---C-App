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
    public partial class Change_Password : Form
    {
        String Language;
        public Change_Password(User user, String Language)
        {
            InitializeComponent();

            this.Language = Language;
            if (user.isEmployee)
            {
                label5.Hide();
                this.Size = new System.Drawing.Size(690, 850);


            }


            if (Language == "english")
            {
                setLanguageTo(Language);
            }
        }

        private void password_change_button_Click(object sender, EventArgs e)
        {
            if (Language == "greek")
            {
                MessageBox.Show("Ο κωδικός σας άλλαξε με επιτυχία!");
            }
            else
            {
                MessageBox.Show("Your password was changed successfully!");
            }

            this.Close();
        }

        public void setLanguageTo(string newlanguage)
        {
            if (newlanguage == "greek")
            {
                label1.Text = "Αλλαγή Κωδικού";
                label2.Text = "Τωρινός Κωδικός:";
                label3.Text = "Νέος Κωδικός:";
                label4.Text = "Επιβεβαίωση:";
                password_change_button.Text = "Αλλαγή";
                label5.Text = "*Σε περίπτωση αλλαγής κωδικού, κατά την αναχώρηση σας είναι\r\n απαραίτητο να ενημερώσετε την ρεσεψιον για τον νέο κωδικό.\r\n";

            }
            else if (newlanguage == "english")
            {
                label1.Text = "Change Password";
                label2.Text = "Current Password:";
                label3.Text = "New Password";
                label4.Text = "Confirm:";
                password_change_button.Text = "Change";
                label5.Text = "*After changing your passsword,\r\n before you check out make sure to notify the reception.\r\n";
            }
        }

    }
}
