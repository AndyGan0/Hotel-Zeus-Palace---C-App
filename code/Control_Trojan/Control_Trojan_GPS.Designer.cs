namespace allhlepidrash
{
    partial class Control_Trojan_GPS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control_Trojan_GPS));
            up_button = new Button();
            left_button = new Button();
            right_button = new Button();
            down_button = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            up_timer = new System.Windows.Forms.Timer(components);
            right_timer = new System.Windows.Forms.Timer(components);
            down_timer = new System.Windows.Forms.Timer(components);
            left_timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // up_button
            // 
            up_button.Cursor = Cursors.Hand;
            up_button.Location = new Point(599, 435);
            up_button.Margin = new Padding(4, 5, 4, 5);
            up_button.Name = "up_button";
            up_button.Size = new Size(105, 105);
            up_button.TabIndex = 0;
            up_button.Text = "ΜΠΡΟΣΤΑ";
            up_button.UseVisualStyleBackColor = true;
            up_button.MouseDown += up_button_MouseDown;
            up_button.MouseUp += up_button_MouseUp;
            // 
            // left_button
            // 
            left_button.Cursor = Cursors.Hand;
            left_button.Location = new Point(494, 538);
            left_button.Margin = new Padding(4, 5, 4, 5);
            left_button.Name = "left_button";
            left_button.Size = new Size(105, 105);
            left_button.TabIndex = 1;
            left_button.Text = "ΑΡΙΣΤΕΡΑ";
            left_button.UseVisualStyleBackColor = true;
            left_button.MouseDown += left_button_MouseDown;
            left_button.MouseUp += left_button_MouseUp;
            // 
            // right_button
            // 
            right_button.Cursor = Cursors.Hand;
            right_button.Location = new Point(702, 538);
            right_button.Margin = new Padding(4, 5, 4, 5);
            right_button.Name = "right_button";
            right_button.Size = new Size(105, 105);
            right_button.TabIndex = 2;
            right_button.Text = "ΔΕΞΙΑ";
            right_button.UseVisualStyleBackColor = true;
            right_button.MouseDown += right_button_MouseDown;
            right_button.MouseUp += right_button_MouseUp;
            // 
            // down_button
            // 
            down_button.Cursor = Cursors.Hand;
            down_button.Location = new Point(599, 641);
            down_button.Margin = new Padding(4, 5, 4, 5);
            down_button.Name = "down_button";
            down_button.Size = new Size(105, 105);
            down_button.TabIndex = 3;
            down_button.Text = "ΠΙΣΩ";
            down_button.UseVisualStyleBackColor = true;
            down_button.MouseDown += down_button_MouseDown;
            down_button.MouseUp += down_button_MouseUp;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1294, 404);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(205, 239);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // up_timer
            // 
            up_timer.Tick += up_timer_Tick;
            // 
            // right_timer
            // 
            right_timer.Tick += right_timer_Tick;
            // 
            // down_timer
            // 
            down_timer.Tick += down_timer_Tick;
            // 
            // left_timer
            // 
            left_timer.Tick += left_timer_Tick;
            // 
            // Control_Trojan_GPS
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1318, 764);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(down_button);
            Controls.Add(right_button);
            Controls.Add(left_button);
            Controls.Add(up_button);
            DoubleBuffered = true;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Control_Trojan_GPS";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button up_button;
        private Button left_button;
        private Button right_button;
        private Button down_button;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer up_timer;
        private System.Windows.Forms.Timer right_timer;
        private System.Windows.Forms.Timer down_timer;
        private System.Windows.Forms.Timer left_timer;
    }
}