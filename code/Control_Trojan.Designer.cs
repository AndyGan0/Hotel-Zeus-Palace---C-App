namespace allhlepidrash
{
    partial class Control_Trojan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control_Trojan));
            driving_GPS_button = new Button();
            trojan_controls_panel = new FlowLayoutPanel();
            label2 = new Label();
            door_button = new Button();
            stairs_button = new Button();
            device_button = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // driving_GPS_button
            // 
            driving_GPS_button.BackColor = Color.Beige;
            driving_GPS_button.BackgroundImage = Properties.Resources.GPS;
            driving_GPS_button.BackgroundImageLayout = ImageLayout.Zoom;
            driving_GPS_button.Cursor = Cursors.Hand;
            driving_GPS_button.FlatAppearance.BorderSize = 2;
            driving_GPS_button.FlatStyle = FlatStyle.Flat;
            driving_GPS_button.Location = new Point(-110, 160);
            driving_GPS_button.Name = "driving_GPS_button";
            driving_GPS_button.Size = new Size(331, 86);
            driving_GPS_button.TabIndex = 11;
            driving_GPS_button.Text = "Οδήγηση-GPS";
            driving_GPS_button.TextAlign = ContentAlignment.MiddleRight;
            driving_GPS_button.UseVisualStyleBackColor = false;
            driving_GPS_button.Click += driving_GPS_button_Click;
            // 
            // trojan_controls_panel
            // 
            trojan_controls_panel.BorderStyle = BorderStyle.FixedSingle;
            trojan_controls_panel.Location = new Point(240, 0);
            trojan_controls_panel.Name = "trojan_controls_panel";
            trojan_controls_panel.Size = new Size(1795, 1206);
            trojan_controls_panel.TabIndex = 14;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(700, 540);
            label2.Name = "label2";
            label2.Size = new Size(429, 54);
            label2.TabIndex = 15;
            label2.Text = "Επιλέξτε Δούρειο Ίππο";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Visible = false;
            // 
            // door_button
            // 
            door_button.BackColor = Color.Beige;
            door_button.BackgroundImage = Properties.Resources.Door;
            door_button.BackgroundImageLayout = ImageLayout.Zoom;
            door_button.Cursor = Cursors.Hand;
            door_button.FlatAppearance.BorderSize = 2;
            door_button.FlatStyle = FlatStyle.Flat;
            door_button.Location = new Point(-110, 280);
            door_button.Name = "door_button";
            door_button.Size = new Size(331, 86);
            door_button.TabIndex = 12;
            door_button.Text = "Πόρτες";
            door_button.TextAlign = ContentAlignment.MiddleRight;
            door_button.UseVisualStyleBackColor = false;
            door_button.Click += door_button_Click;
            // 
            // stairs_button
            // 
            stairs_button.BackColor = Color.Beige;
            stairs_button.BackgroundImage = (Image)resources.GetObject("stairs_button.BackgroundImage");
            stairs_button.BackgroundImageLayout = ImageLayout.Zoom;
            stairs_button.Cursor = Cursors.Hand;
            stairs_button.FlatAppearance.BorderSize = 2;
            stairs_button.FlatStyle = FlatStyle.Flat;
            stairs_button.Location = new Point(-110, 400);
            stairs_button.Name = "stairs_button";
            stairs_button.Size = new Size(331, 86);
            stairs_button.TabIndex = 13;
            stairs_button.Text = "Σκάλα";
            stairs_button.TextAlign = ContentAlignment.MiddleRight;
            stairs_button.UseVisualStyleBackColor = false;
            stairs_button.Click += stairs_button_Click;
            // 
            // device_button
            // 
            device_button.BackColor = Color.Beige;
            device_button.BackgroundImage = (Image)resources.GetObject("device_button.BackgroundImage");
            device_button.BackgroundImageLayout = ImageLayout.Zoom;
            device_button.Cursor = Cursors.Hand;
            device_button.FlatAppearance.BorderSize = 2;
            device_button.FlatStyle = FlatStyle.Flat;
            device_button.Location = new Point(-110, 40);
            device_button.Name = "device_button";
            device_button.Size = new Size(331, 86);
            device_button.TabIndex = 13;
            device_button.Text = "Συσκευες";
            device_button.TextAlign = ContentAlignment.MiddleRight;
            device_button.UseVisualStyleBackColor = false;
            device_button.Click += device_button_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            comboBox1.Location = new Point(25, 93);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 16;
            comboBox1.Visible = false;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(4, 7);
            label1.Name = "label1";
            label1.Size = new Size(236, 76);
            label1.TabIndex = 17;
            label1.Text = "Επιλέξτε Δούρειο \r\n         Ίππο:";
            label1.Visible = false;
            // 
            // Control_Trojan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1786, 957);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(driving_GPS_button);
            Controls.Add(trojan_controls_panel);
            Controls.Add(door_button);
            Controls.Add(stairs_button);
            Controls.Add(label1);
            Controls.Add(device_button);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Control_Trojan";
            Text = "Form10";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button driving_GPS_button;
        private FlowLayoutPanel trojan_controls_panel;
        private Button door_button;
        private Button stairs_button;
        private Button device_button;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
    }
}