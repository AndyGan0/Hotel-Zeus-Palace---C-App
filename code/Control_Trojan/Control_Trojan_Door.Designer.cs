namespace allhlepidrash
{
    partial class Control_Trojan_Door
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control_Trojan_Door));
            trackBar1 = new TrackBar();
            label1 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // trackBar1
            // 
            trackBar1.LargeChange = 1;
            trackBar1.Location = new Point(366, 567);
            trackBar1.Margin = new Padding(4, 5, 4, 5);
            trackBar1.Maximum = 3;
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(457, 69);
            trackBar1.TabIndex = 0;
            trackBar1.TickStyle = TickStyle.Both;
            trackBar1.Value = 1;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("OCR A Extended", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(366, 537);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 1;
            label1.Text = "Κλείσιμο";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("OCR A Extended", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(769, 537);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 3;
            label3.Text = "Άνοιγμα";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(421, 122);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(345, 338);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Control_Trojan_Door
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(1690, 1078);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(trackBar1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Control_Trojan_Door";
            Text = "Form12";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar trackBar1;
        private Label label1;
        private Label label3;
        private PictureBox pictureBox1;
    }
}