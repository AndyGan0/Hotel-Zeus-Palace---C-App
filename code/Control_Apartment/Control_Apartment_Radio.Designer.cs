namespace allhlepidrash
{
    partial class Control_Apartment_Radio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control_Apartment_Radio));
            OFF_button = new Button();
            ON_button = new Button();
            label1 = new Label();
            trackBar1 = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // OFF_button
            // 
            OFF_button.Cursor = Cursors.Hand;
            OFF_button.Location = new Point(683, 75);
            OFF_button.Margin = new Padding(4, 5, 4, 5);
            OFF_button.Name = "OFF_button";
            OFF_button.Size = new Size(100, 83);
            OFF_button.TabIndex = 3;
            OFF_button.Text = "OFF";
            OFF_button.UseVisualStyleBackColor = true;
            OFF_button.Click += OFF_button_Click;
            // 
            // ON_button
            // 
            ON_button.BackColor = Color.Chartreuse;
            ON_button.Cursor = Cursors.Hand;
            ON_button.Location = new Point(491, 75);
            ON_button.Margin = new Padding(4, 5, 4, 5);
            ON_button.Name = "ON_button";
            ON_button.Size = new Size(100, 83);
            ON_button.TabIndex = 2;
            ON_button.Text = "ON";
            ON_button.UseVisualStyleBackColor = false;
            ON_button.Click += ON_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.RosyBrown;
            label1.Location = new Point(87, 355);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(244, 40);
            label1.TabIndex = 4;
            label1.Text = "Επιλέξτε Σταθμό:";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(364, 355);
            trackBar1.Margin = new Padding(4, 5, 4, 5);
            trackBar1.Maximum = 100;
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(331, 69);
            trackBar1.TabIndex = 5;
            trackBar1.Value = 1;
            // 
            // Control_Apartment_Radio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1421, 937);
            Controls.Add(trackBar1);
            Controls.Add(label1);
            Controls.Add(OFF_button);
            Controls.Add(ON_button);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Control_Apartment_Radio";
            Text = "radio";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OFF_button;
        private Button ON_button;
        private Label label1;
        private TrackBar trackBar1;
    }
}