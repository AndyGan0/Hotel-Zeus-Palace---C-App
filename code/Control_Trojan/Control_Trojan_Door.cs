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
    public partial class Control_Trojan_Door : Form
    {
        public Control_Trojan_Door()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value == 1)
            {
                pictureBox1.Image = Properties.Resources.door_closed;
            }
            else if (trackBar1.Value == 2)
            {
                pictureBox1.Image = Properties.Resources.door_open;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.door_full_open;
            }
        }

        public void setLanguageTo(string newlanguage)
        {
            if (newlanguage == "greek")
            {
                label1.Text = "Κλείσιμο";
                label3.Text = "Άνοιγμα";
            }
            else if (newlanguage == "english")
            {
                label1.Text = "Close";
                label3.Text = "Open";
            }
        }


    }
}
