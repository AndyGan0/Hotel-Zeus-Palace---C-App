namespace allhlepidrash
{
    partial class Control_Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control_Settings));
            Password_change_button = new Button();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Password_change_button
            // 
            Password_change_button.BackColor = Color.Beige;
            Password_change_button.Cursor = Cursors.Hand;
            Password_change_button.FlatAppearance.BorderSize = 2;
            Password_change_button.FlatStyle = FlatStyle.Flat;
            Password_change_button.Location = new Point(643, 211);
            Password_change_button.Margin = new Padding(4, 5, 4, 5);
            Password_change_button.Name = "Password_change_button";
            Password_change_button.Size = new Size(286, 75);
            Password_change_button.TabIndex = 1;
            Password_change_button.Text = "Αλλαγή Κωδικού";
            Password_change_button.UseVisualStyleBackColor = false;
            Password_change_button.Click += Password_change_button_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Beige;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(643, 357);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(286, 75);
            button2.TabIndex = 2;
            button2.Text = "Αλλαγή γλώσσας";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1082, 335);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(142, 114);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(936, 335);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Control_Settings
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(1560, 1005);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(Password_change_button);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Control_Settings";
            Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button Password_change_button;
        private Button button2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}