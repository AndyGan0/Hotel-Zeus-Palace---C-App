namespace allhlepidrash
{
    partial class Control_Pools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control_Pools));
            pool_controls_panel = new FlowLayoutPanel();
            label2 = new Label();
            Private_Pool_Button = new Button();
            Public_Pool_button = new Button();
            SuspendLayout();
            // 
            // pool_controls_panel
            // 
            pool_controls_panel.BorderStyle = BorderStyle.FixedSingle;
            pool_controls_panel.Location = new Point(251, 0);
            pool_controls_panel.Name = "pool_controls_panel";
            pool_controls_panel.Size = new Size(1795, 1206);
            pool_controls_panel.TabIndex = 14;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(263, 416);
            label2.Name = "label2";
            label2.Size = new Size(1303, 54);
            label2.TabIndex = 15;
            label2.Text = "Επιλέξτε Ιδιωτική ή Κεντρική Πισίνα";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Visible = false;
            // 
            // Private_Pool_Button
            // 
            Private_Pool_Button.BackColor = Color.Beige;
            Private_Pool_Button.BackgroundImage = (Image)resources.GetObject("Private_Pool_Button.BackgroundImage");
            Private_Pool_Button.BackgroundImageLayout = ImageLayout.Zoom;
            Private_Pool_Button.Cursor = Cursors.Hand;
            Private_Pool_Button.FlatAppearance.BorderSize = 2;
            Private_Pool_Button.FlatStyle = FlatStyle.Flat;
            Private_Pool_Button.Location = new Point(-99, 40);
            Private_Pool_Button.Name = "Private_Pool_Button";
            Private_Pool_Button.Size = new Size(331, 86);
            Private_Pool_Button.TabIndex = 12;
            Private_Pool_Button.Text = "Ιδιωτική\r\nΠισίνα";
            Private_Pool_Button.TextAlign = ContentAlignment.MiddleRight;
            Private_Pool_Button.UseVisualStyleBackColor = false;
            Private_Pool_Button.Click += Private_Pool_Button_Click;
            // 
            // Public_Pool_button
            // 
            Public_Pool_button.BackColor = Color.Beige;
            Public_Pool_button.BackgroundImage = (Image)resources.GetObject("Public_Pool_button.BackgroundImage");
            Public_Pool_button.BackgroundImageLayout = ImageLayout.Zoom;
            Public_Pool_button.Cursor = Cursors.Hand;
            Public_Pool_button.FlatAppearance.BorderSize = 2;
            Public_Pool_button.FlatStyle = FlatStyle.Flat;
            Public_Pool_button.Location = new Point(-99, 160);
            Public_Pool_button.Name = "Public_Pool_button";
            Public_Pool_button.Size = new Size(331, 86);
            Public_Pool_button.TabIndex = 13;
            Public_Pool_button.Text = "Κεντρική\r\nΠισίνα\r\n";
            Public_Pool_button.TextAlign = ContentAlignment.MiddleRight;
            Public_Pool_button.UseVisualStyleBackColor = false;
            Public_Pool_button.Click += Public_Pool_button_Click;
            // 
            // Control_Pools
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1727, 957);
            Controls.Add(label2);
            Controls.Add(pool_controls_panel);
            Controls.Add(Private_Pool_Button);
            Controls.Add(Public_Pool_button);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Control_Pools";
            Text = "Form10";
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel pool_controls_panel;
        private Button Private_Pool_Button;
        private Button Public_Pool_button;
        private Label label2;
    }
}