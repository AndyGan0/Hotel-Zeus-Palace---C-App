namespace allhlepidrash
{
    partial class Control_Apartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control_Apartment));
            light_button = new Button();
            temperature_button = new Button();
            tv_button = new Button();
            radio_button = new Button();
            panel1 = new Panel();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // light_button
            // 
            light_button.BackColor = Color.Beige;
            light_button.BackgroundImage = (Image)resources.GetObject("light_button.BackgroundImage");
            light_button.BackgroundImageLayout = ImageLayout.Zoom;
            light_button.Cursor = Cursors.Hand;
            light_button.FlatAppearance.BorderSize = 2;
            light_button.FlatStyle = FlatStyle.Flat;
            light_button.Location = new Point(-110, 40);
            light_button.Name = "light_button";
            light_button.Size = new Size(331, 86);
            light_button.TabIndex = 0;
            light_button.Text = "Φώτα";
            light_button.TextAlign = ContentAlignment.MiddleRight;
            light_button.UseVisualStyleBackColor = false;
            light_button.Click += light_button_Click;
            // 
            // temperature_button
            // 
            temperature_button.BackColor = Color.Beige;
            temperature_button.BackgroundImage = (Image)resources.GetObject("temperature_button.BackgroundImage");
            temperature_button.BackgroundImageLayout = ImageLayout.Zoom;
            temperature_button.Cursor = Cursors.Hand;
            temperature_button.FlatAppearance.BorderSize = 2;
            temperature_button.FlatStyle = FlatStyle.Flat;
            temperature_button.Location = new Point(-123, 160);
            temperature_button.Name = "temperature_button";
            temperature_button.Size = new Size(344, 86);
            temperature_button.TabIndex = 1;
            temperature_button.Text = "Θερμοκρασία";
            temperature_button.TextAlign = ContentAlignment.MiddleRight;
            temperature_button.UseVisualStyleBackColor = false;
            temperature_button.Click += temperature_button_Click;
            // 
            // tv_button
            // 
            tv_button.BackColor = Color.Beige;
            tv_button.BackgroundImage = (Image)resources.GetObject("tv_button.BackgroundImage");
            tv_button.BackgroundImageLayout = ImageLayout.Zoom;
            tv_button.Cursor = Cursors.Hand;
            tv_button.FlatAppearance.BorderSize = 2;
            tv_button.FlatStyle = FlatStyle.Flat;
            tv_button.Location = new Point(-110, 280);
            tv_button.Name = "tv_button";
            tv_button.Size = new Size(331, 86);
            tv_button.TabIndex = 2;
            tv_button.Text = "Τηλεόραση";
            tv_button.TextAlign = ContentAlignment.MiddleRight;
            tv_button.UseVisualStyleBackColor = false;
            tv_button.Click += tv_button_Click;
            // 
            // radio_button
            // 
            radio_button.BackColor = Color.Beige;
            radio_button.BackgroundImage = (Image)resources.GetObject("radio_button.BackgroundImage");
            radio_button.BackgroundImageLayout = ImageLayout.Zoom;
            radio_button.Cursor = Cursors.Hand;
            radio_button.FlatAppearance.BorderSize = 2;
            radio_button.FlatStyle = FlatStyle.Flat;
            radio_button.Location = new Point(-110, 400);
            radio_button.Name = "radio_button";
            radio_button.Size = new Size(331, 86);
            radio_button.TabIndex = 3;
            radio_button.Text = "Ραδιόφωνο";
            radio_button.TextAlign = ContentAlignment.MiddleRight;
            radio_button.UseVisualStyleBackColor = false;
            radio_button.Click += radio_button_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(240, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1730, 1243);
            panel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(500, 537);
            label2.Name = "label2";
            label2.Size = new Size(392, 54);
            label2.TabIndex = 0;
            label2.Text = "Επιλέξτε Διαμέρισμα";
            label2.Visible = false;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "200", "201", "202", "203", "204", "205", "206", "207", "208", "209" });
            comboBox1.Location = new Point(39, 93);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 5;
            comboBox1.Visible = false;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(39, 9);
            label1.Name = "label1";
            label1.Size = new Size(165, 76);
            label1.TabIndex = 6;
            label1.Text = "   Επιλέξτε \r\nΔιαμέρισμα:";
            label1.Visible = false;
            // 
            // Control_Apartment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1644, 1168);
            Controls.Add(comboBox1);
            Controls.Add(panel1);
            Controls.Add(radio_button);
            Controls.Add(tv_button);
            Controls.Add(temperature_button);
            Controls.Add(label1);
            Controls.Add(light_button);
            Name = "Control_Apartment";
            Text = "Control_Devices";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button light_button;
        private Button temperature_button;
        private Button tv_button;
        private Button radio_button;
        private Panel panel1;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
    }
}