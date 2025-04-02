using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace allhlepidrash
{
    public partial class Control_Restaurant_Purchase : Form
    {
        float Price;


        public Control_Restaurant_Purchase(float price, String language)
        {
            InitializeComponent();

            Price = price;

            if (language == "english")
            {
                setLanguageTo(language);
            }

            label7.Text += Price.ToString() + "€";
        }




        private void timer_show_secuirity_method(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            label1.Hide();




            timer_show_security.Stop();

            label6.Show();
            label2.Show();
            label3.Show();
            label3.Show();
            label4.Show();
            label5.Show();
            label7.Show();
            textBox1.Show();
            textBox2.Show();
            textBox3.Show();
            textBox4.Show();
            complete_button.Show();

        }

        private void complete_button_Click(object sender, EventArgs e)
        {
            label6.Hide();
            label2.Hide();
            label3.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label7.Hide();
            textBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            complete_button.Hide();

            pictureBox1.Show();
            pictureBox1.Image = Properties.Resources.Purchase_complete;
            label8.Show();

            SoundPlayer sound = new SoundPlayer("Pay_Success.wav");
            sound.Play();

            timer_close.Start();

        }

        private void timer_close_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setLanguageTo(string newlanguage)
        {
            if (newlanguage == "greek")
            {
                label6.Text = "Συπληρώσε τα στοιχεία της κάρτας:";
                label2.Text = "Αριθμός Κάρτας";
                label3.Text = "Ημερομηνία Λήξης";
                label4.Text = "CVC/CVV";
                label5.Text = "Όνοματεπώνυμο στην κάρτα";
                label1.Text = "Ασφαλής Συναλλαγή";
                label7.Text = "Ποσό:   ";
                label8.Text = "Ευχαριστούμε για την αγορά σας!";
                complete_button.Text = "Συνέχεια";

                textBox2.PlaceholderText = "MM/EE";
                textBox3.PlaceholderText = "3 ψηφία";
                textBox4.PlaceholderText = "Ον/μο";

            }
            else if (newlanguage == "english")
            {
                label6.Text = "Fill your card information:";
                label2.Text = "Card Number";
                label3.Text = "Date";
                label4.Text = "CVC/CVV";
                label5.Text = "Card Holder Name";
                label1.Text = "Secure Transaction";
                label7.Text = "Amount:   ";
                label8.Text = "Thank you for your purchase!";
                complete_button.Text = "Finish";

                textBox2.PlaceholderText = "MM/YY";
                textBox3.PlaceholderText = "3 digits";
                textBox4.PlaceholderText = "Name";

                label6.Location = new Point(196, 99);
                label1.Location = new Point(260, 725);
                label8.Location = new Point(175, 835);
            }
        }

    }
}
