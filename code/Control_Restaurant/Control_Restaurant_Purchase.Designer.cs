namespace allhlepidrash
{
    partial class Control_Restaurant_Purchase
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control_Restaurant_Purchase));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            timer_show_security = new System.Windows.Forms.Timer(components);
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            complete_button = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            timer_close = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(238, 726);
            label1.Name = "label1";
            label1.Size = new Size(318, 45);
            label1.TabIndex = 1;
            label1.Text = "Ασφαλής Συναλλαγή";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(175, 222);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(447, 410);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // timer_show_security
            // 
            timer_show_security.Enabled = true;
            timer_show_security.Interval = 3000;
            timer_show_security.Tick += timer_show_secuirity_method;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(131, 302);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "1234 5678 9012 3456";
            textBox1.Size = new Size(542, 50);
            textBox1.TabIndex = 5;
            textBox1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(131, 254);
            label2.Name = "label2";
            label2.Size = new Size(190, 32);
            label2.TabIndex = 6;
            label2.Text = "Αριθμός Κάρτας";
            label2.Visible = false;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(131, 450);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "MM/EE";
            textBox2.Size = new Size(239, 50);
            textBox2.TabIndex = 5;
            textBox2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(131, 402);
            label3.Name = "label3";
            label3.Size = new Size(218, 32);
            label3.TabIndex = 6;
            label3.Text = "Ημερομηνία Λήξης";
            label3.Visible = false;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(432, 450);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "3 ψηφία";
            textBox3.Size = new Size(241, 50);
            textBox3.TabIndex = 5;
            textBox3.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(432, 402);
            label4.Name = "label4";
            label4.Size = new Size(112, 32);
            label4.TabIndex = 6;
            label4.Text = "CVC/CVV";
            label4.Visible = false;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(131, 603);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Ον/μο";
            textBox4.Size = new Size(542, 50);
            textBox4.TabIndex = 5;
            textBox4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(131, 555);
            label5.Name = "label5";
            label5.Size = new Size(336, 32);
            label5.TabIndex = 6;
            label5.Text = "Όνοματεπώνυμο στην κάρτα";
            label5.Visible = false;
            // 
            // complete_button
            // 
            complete_button.BackColor = Color.FromArgb(123, 223, 201);
            complete_button.Cursor = Cursors.Hand;
            complete_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            complete_button.Location = new Point(284, 863);
            complete_button.Name = "complete_button";
            complete_button.Size = new Size(195, 62);
            complete_button.TabIndex = 7;
            complete_button.Text = "Συνέχεια";
            complete_button.UseVisualStyleBackColor = false;
            complete_button.Visible = false;
            complete_button.Click += complete_button_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(131, 98);
            label6.Name = "label6";
            label6.Size = new Size(543, 45);
            label6.TabIndex = 1;
            label6.Text = "Συπληρώσε τα στοιχεία της κάρτας:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(131, 747);
            label7.Name = "label7";
            label7.Size = new Size(133, 45);
            label7.TabIndex = 8;
            label7.Text = "Ποσό:   ";
            label7.Visible = false;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(128, 840);
            label8.Name = "label8";
            label8.Size = new Size(512, 45);
            label8.TabIndex = 1;
            label8.Text = "Ευχαριστούμε για την αγορά σας!";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            label8.Visible = false;
            // 
            // timer_close
            // 
            timer_close.Interval = 2000;
            timer_close.Tick += timer_close_Tick;
            // 
            // Control_Restaurant_Purchase
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 1008);
            Controls.Add(label7);
            Controls.Add(complete_button);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox4);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(label1);
            Name = "Control_Restaurant_Purchase";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Control_Restaurant_Purchase";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer_show_security;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private Button complete_button;
        private Label label6;
        private Label label7;
        private Label label8;
        private System.Windows.Forms.Timer timer_close;
    }
}