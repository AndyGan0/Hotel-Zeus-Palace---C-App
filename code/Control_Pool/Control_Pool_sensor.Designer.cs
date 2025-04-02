namespace allhlepidrash
{
    partial class Control_Pool_sensor
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
            sensor_button = new Button();
            label1 = new Label();
            label2 = new Label();
            alarm_button = new Button();
            SuspendLayout();
            // 
            // sensor_button
            // 
            sensor_button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            sensor_button.BackColor = Color.Lime;
            sensor_button.Cursor = Cursors.Hand;
            sensor_button.Location = new Point(238, 421);
            sensor_button.Margin = new Padding(4, 5, 4, 5);
            sensor_button.MaximumSize = new Size(126, 85);
            sensor_button.MinimumSize = new Size(126, 85);
            sensor_button.Name = "sensor_button";
            sensor_button.Size = new Size(126, 85);
            sensor_button.TabIndex = 0;
            sensor_button.Text = "ON";
            sensor_button.UseVisualStyleBackColor = false;
            sensor_button.Click += sensor_button_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("OCR A Extended", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(238, 207);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(166, 35);
            label1.TabIndex = 1;
            label1.Text = "Αισθητήρας";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("OCR A Extended", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(620, 207);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(170, 35);
            label2.TabIndex = 4;
            label2.Text = "Συναγερμός";
            // 
            // alarm_button
            // 
            alarm_button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            alarm_button.BackColor = Color.Lime;
            alarm_button.Cursor = Cursors.Hand;
            alarm_button.Location = new Point(648, 421);
            alarm_button.Margin = new Padding(4, 5, 4, 5);
            alarm_button.MaximumSize = new Size(126, 85);
            alarm_button.MinimumSize = new Size(126, 85);
            alarm_button.Name = "alarm_button";
            alarm_button.Size = new Size(126, 85);
            alarm_button.TabIndex = 3;
            alarm_button.Text = "ON";
            alarm_button.UseVisualStyleBackColor = false;
            alarm_button.Click += alarm_button_Click;
            // 
            // Control_Pool_sensor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(1566, 1003);
            Controls.Add(label2);
            Controls.Add(alarm_button);
            Controls.Add(label1);
            Controls.Add(sensor_button);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Control_Pool_sensor";
            Text = "Form8";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button sensor_button;
        private Label label1;
        private Label label2;
        private Button alarm_button;
    }
}