namespace allhlepidrash
{
    partial class Login_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(613, 278);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.MaximumSize = new Size(190, 23);
            textBox1.MinimumSize = new Size(190, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(190, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(613, 392);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.MaximumSize = new Size(190, 23);
            textBox2.MinimumSize = new Size(190, 23);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(190, 23);
            textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button1.BackColor = Color.DarkKhaki;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(649, 553);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.MaximumSize = new Size(133, 65);
            button1.MinimumSize = new Size(133, 65);
            button1.Name = "button1";
            button1.Size = new Size(133, 65);
            button1.TabIndex = 2;
            button1.Text = "Σύνδεση";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.BackColor = Color.Beige;
            label1.Font = new Font("OCR A Extended", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(578, 124);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(255, 35);
            label1.TabIndex = 3;
            label1.Text = "Καλώς Ορίσατε!";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1150, 553);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.MaximumSize = new Size(430, 412);
            pictureBox1.MinimumSize = new Size(430, 412);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(430, 412);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("OCR A Extended", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(17, 895);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(647, 30);
            label2.TabIndex = 5;
            label2.Text = "Απολαύστε την διαμονή σας στο παλάτι του Δία!";
            label2.Visible = false;
            // 
            // Login_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(1663, 992);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Login_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
    }
}