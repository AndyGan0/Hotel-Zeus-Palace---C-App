using System.Windows.Forms;

namespace allhlepidrash
{
    public partial class Start_up_Form : Form
    {

        String Language = "greek";
        public Start_up_Form()
        {
            InitializeComponent();



            label1.BackColor = Color.Transparent;



        }

        private void Customer_button_click(object sender, EventArgs e)
        {
            this.Hide();

            Login_Form form = new Login_Form("customer", Language);
            form.ShowDialog();

            this.Close();
        }

        private void Employee_button_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login_Form form = new Login_Form("employee", Language);
            form.ShowDialog();

            this.Close();
        }



        public void setLanguageTo(string newlanguage)
        {
            Language = newlanguage;
            if (newlanguage == "greek")
            {

                label1.Text = "Το Παλάτι Του Δία";
                button1.Text = "Πελάτης";
                button2.Text = "Υπάλληλος";
            }
            else if (newlanguage == "english")
            {
                label1.Text = "Zeus' Palace";
                button1.Text = "Customer";
                button2.Text = "Employee";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            setLanguageTo("greek");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            setLanguageTo("english");
        }


    }
}