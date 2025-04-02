using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace allhlepidrash
{
    public partial class Control_Pool_temperature : Form
    {
        public Control_Pool_temperature()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void setLanguageTo(String newlanguage)
        {
            if (newlanguage == "greek")
            {
                label1.Text = "Τρέχουσα Θερμοκρασια:";

            }
            else if (newlanguage == "english")
            {
                label1.Text = "Current Temperature:";
            }
        }
    }
}
