namespace allhlepidrash
{
    partial class Control_Specific_Pool
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
            Water_level_button = new Button();
            Temperature_button = new Button();
            Sensor_button = new Button();
            pool_controls_panel = new FlowLayoutPanel();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // Water_level_button
            // 
            Water_level_button.BackColor = Color.Beige;
            Water_level_button.BackgroundImage = Properties.Resources.water_level_icon;
            Water_level_button.BackgroundImageLayout = ImageLayout.Zoom;
            Water_level_button.Cursor = Cursors.Hand;
            Water_level_button.FlatAppearance.BorderSize = 2;
            Water_level_button.FlatStyle = FlatStyle.Flat;
            Water_level_button.Location = new Point(-131, 40);
            Water_level_button.Name = "Water_level_button";
            Water_level_button.Size = new Size(352, 86);
            Water_level_button.TabIndex = 7;
            Water_level_button.Text = "Στάθμη Νερού";
            Water_level_button.TextAlign = ContentAlignment.MiddleRight;
            Water_level_button.UseVisualStyleBackColor = false;
            Water_level_button.Click += Water_level_button_Click;
            // 
            // Temperature_button
            // 
            Temperature_button.BackColor = Color.Beige;
            Temperature_button.BackgroundImage = Properties.Resources.temperature;
            Temperature_button.BackgroundImageLayout = ImageLayout.Zoom;
            Temperature_button.Cursor = Cursors.Hand;
            Temperature_button.FlatAppearance.BorderSize = 2;
            Temperature_button.FlatStyle = FlatStyle.Flat;
            Temperature_button.Location = new Point(-123, 162);
            Temperature_button.Name = "Temperature_button";
            Temperature_button.Size = new Size(344, 86);
            Temperature_button.TabIndex = 7;
            Temperature_button.Text = "Θερμοκρασία";
            Temperature_button.TextAlign = ContentAlignment.MiddleRight;
            Temperature_button.UseVisualStyleBackColor = false;
            Temperature_button.Click += Temperature_button_Click;
            // 
            // Sensor_button
            // 
            Sensor_button.BackColor = Color.Beige;
            Sensor_button.BackgroundImage = Properties.Resources.wireless_sensor_icon;
            Sensor_button.BackgroundImageLayout = ImageLayout.Zoom;
            Sensor_button.Cursor = Cursors.Hand;
            Sensor_button.FlatAppearance.BorderSize = 2;
            Sensor_button.FlatStyle = FlatStyle.Flat;
            Sensor_button.Location = new Point(-110, 280);
            Sensor_button.Name = "Sensor_button";
            Sensor_button.Size = new Size(331, 86);
            Sensor_button.TabIndex = 7;
            Sensor_button.Text = "Αισθητήρας";
            Sensor_button.TextAlign = ContentAlignment.MiddleRight;
            Sensor_button.UseVisualStyleBackColor = false;
            Sensor_button.Click += Sensor_button_Click;
            // 
            // pool_controls_panel
            // 
            pool_controls_panel.BorderStyle = BorderStyle.FixedSingle;
            pool_controls_panel.Location = new Point(240, 0);
            pool_controls_panel.Name = "pool_controls_panel";
            pool_controls_panel.Size = new Size(2057, 1245);
            pool_controls_panel.TabIndex = 9;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(244, 555);
            label2.Name = "label2";
            label2.Size = new Size(1138, 54);
            label2.TabIndex = 18;
            label2.Text = "Επιλέξτε Ιδιωτική Πισίνα";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Visible = false;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            comboBox1.Location = new Point(21, 108);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 19;
            comboBox1.Visible = false;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 22);
            label1.Name = "label1";
            label1.Size = new Size(233, 76);
            label1.TabIndex = 20;
            label1.Text = "Επιλέξτε Ιδιωτική\r\n         Πισίνα:";
            label1.Visible = false;
            // 
            // Control_Specific_Pool
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(1511, 947);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(Water_level_button);
            Controls.Add(pool_controls_panel);
            Controls.Add(Temperature_button);
            Controls.Add(Sensor_button);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Control_Specific_Pool";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Water_level_button;
        private Button Temperature_button;
        private Button Sensor_button;
        private FlowLayoutPanel pool_controls_panel;
        private Label label2;
        private ComboBox comboBox1;
        private Label label1;
    }
}