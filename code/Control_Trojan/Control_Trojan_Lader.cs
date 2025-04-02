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
    public partial class Control_Trojan_Lader : Form
    {
        public Control_Trojan_Lader()
        {
            InitializeComponent();
        }

        public void setLanguageTo(string newlanguage)
        {
            if (newlanguage == "greek")
            {
                label1.Text = "Ανεβασμένη";
                label3.Text = "Κατεβασμένη";

            }
            else if (newlanguage == "english")
            {
                label1.Text = "UP";
                label3.Text = "DOWN";
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value == 1)
            {
                pictureBox1.Show();
                pictureBox2.Hide();
                pictureBox3.Hide();
            }
            else if (trackBar1.Value == 2)
            {
                pictureBox1.Show();
                pictureBox2.Show();
                pictureBox3.Hide();
            }
            else
            {
                pictureBox1.Show();
                pictureBox2.Show();
                pictureBox3.Show();
            }
        }
    }
}
