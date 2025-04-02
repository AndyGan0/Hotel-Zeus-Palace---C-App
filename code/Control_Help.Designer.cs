namespace allhlepidrash
{
    partial class Control_Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control_Help));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            help_button = new Button();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            panel1 = new Panel();
            send_message_button = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(990, 21);
            label1.Name = "label1";
            label1.Size = new Size(327, 45);
            label1.TabIndex = 0;
            label1.Text = "Άμεση Επικοινωνία:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bell MT", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(33, 79);
            label2.Name = "label2";
            label2.Size = new Size(664, 124);
            label2.TabIndex = 1;
            label2.Text = "Λεωφ. Νέας Ερυθραίας 19, Νέα Ερυθραία 146 71\r\nΤηλέφωνο: +30 210 9853132 – 4, Φαξ: +30 210 9627055\r\ninfo@zeuspalace.gr – www.zeuspalace.gr\r\n\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bell MT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(201, 264);
            label3.Name = "label3";
            label3.Size = new Size(0, 38);
            label3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bell MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(33, 21);
            label4.Name = "label4";
            label4.Size = new Size(371, 41);
            label4.TabIndex = 3;
            label4.Text = "Γενικές Πληροφορίες:";
            // 
            // help_button
            // 
            help_button.BackColor = Color.Beige;
            help_button.Cursor = Cursors.Hand;
            help_button.ForeColor = Color.Blue;
            help_button.Location = new Point(33, 328);
            help_button.Name = "help_button";
            help_button.Size = new Size(561, 59);
            help_button.TabIndex = 4;
            help_button.Text = "Κάντε κλικ εδώ για να ανοίξετε τον οδηγό";
            help_button.UseVisualStyleBackColor = false;
            help_button.Click += help_button_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(145, 447);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(389, 271);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bell MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(33, 284);
            label5.Name = "label5";
            label5.Size = new Size(313, 41);
            label5.TabIndex = 3;
            label5.Text = "Οδηγός Βοήθειας:";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(724, 112);
            panel1.Name = "panel1";
            panel1.Size = new Size(857, 534);
            panel1.TabIndex = 6;
            // 
            // send_message_button
            // 
            send_message_button.Cursor = Cursors.Hand;
            send_message_button.Location = new Point(1425, 673);
            send_message_button.Name = "send_message_button";
            send_message_button.Size = new Size(146, 45);
            send_message_button.TabIndex = 8;
            send_message_button.Text = "Αποστολή";
            send_message_button.UseVisualStyleBackColor = true;
            send_message_button.Click += send_message_button_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(735, 673);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Πληκτρολογίστε κάτι";
            textBox1.Size = new Size(670, 45);
            textBox1.TabIndex = 7;
            // 
            // Control_Help
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(1593, 760);
            Controls.Add(send_message_button);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(help_button);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Control_Help";
            Text = "Help";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button help_button;
        private PictureBox pictureBox1;
        private Label label5;
        private Panel panel1;
        private Button send_message_button;
        private TextBox textBox1;
    }
}