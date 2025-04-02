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
    public partial class Control_Apartment_Temperature : Form
    {
        public Control_Apartment_Temperature()
        {
            InitializeComponent();

            
        }

        public void setLanguageTo(string newlanguage)
        {
            if (newlanguage == "greek")
            {
                label1.Text = "Θερμοκρασία Δωματίου:";

            }
            else if (newlanguage == "english")
            {
                label1.Text = "Room Temperature:";
            }
        }
    }
}
