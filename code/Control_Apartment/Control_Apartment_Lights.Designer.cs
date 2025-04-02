namespace allhlepidrash
{
    partial class Control_Apartment_Lights
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control_Apartment_Lights));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            bedroom_lights_button = new Button();
            bathroom_lights_button = new Button();
            balcony_lights_button = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(834, 374);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(143, 25);
            label1.TabIndex = 0;
            label1.Text = "Φώτα Μπάνιου:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(834, 271);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(193, 25);
            label2.TabIndex = 1;
            label2.Text = "Φώτα Υπνοδωματίου:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(834, 489);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(172, 25);
            label3.TabIndex = 2;
            label3.Text = "Φώτα Μπαλκονιού:";
            // 
            // bedroom_lights_button
            // 
            bedroom_lights_button.BackColor = Color.Chartreuse;
            bedroom_lights_button.Cursor = Cursors.Hand;
            bedroom_lights_button.Location = new Point(732, 242);
            bedroom_lights_button.Margin = new Padding(4, 5, 4, 5);
            bedroom_lights_button.Name = "bedroom_lights_button";
            bedroom_lights_button.Size = new Size(71, 83);
            bedroom_lights_button.TabIndex = 3;
            bedroom_lights_button.Text = "ON";
            bedroom_lights_button.UseVisualStyleBackColor = false;
            bedroom_lights_button.Click += bedroom_lights_button_Click;
            // 
            // bathroom_lights_button
            // 
            bathroom_lights_button.BackColor = Color.Chartreuse;
            bathroom_lights_button.Cursor = Cursors.Hand;
            bathroom_lights_button.Location = new Point(732, 345);
            bathroom_lights_button.Margin = new Padding(4, 5, 4, 5);
            bathroom_lights_button.Name = "bathroom_lights_button";
            bathroom_lights_button.Size = new Size(71, 83);
            bathroom_lights_button.TabIndex = 4;
            bathroom_lights_button.Text = "ON";
            bathroom_lights_button.UseVisualStyleBackColor = false;
            bathroom_lights_button.Click += bathroom_lights_button_Click;
            // 
            // balcony_lights_button
            // 
            balcony_lights_button.BackColor = Color.Chartreuse;
            balcony_lights_button.Cursor = Cursors.Hand;
            balcony_lights_button.Location = new Point(732, 460);
            balcony_lights_button.Margin = new Padding(4, 5, 4, 5);
            balcony_lights_button.Name = "balcony_lights_button";
            balcony_lights_button.Size = new Size(71, 83);
            balcony_lights_button.TabIndex = 5;
            balcony_lights_button.Text = "ON";
            balcony_lights_button.UseVisualStyleBackColor = false;
            balcony_lights_button.Click += balcony_lights_button_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(270, 209);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(305, 367);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Control_Apartment_Lights
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(1499, 970);
            Controls.Add(pictureBox1);
            Controls.Add(balcony_lights_button);
            Controls.Add(bathroom_lights_button);
            Controls.Add(bedroom_lights_button);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Control_Apartment_Lights";
            Text = "lights";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button bedroom_lights_button;
        private Button bathroom_lights_button;
        private Button balcony_lights_button;
        private PictureBox pictureBox1;
    }
}