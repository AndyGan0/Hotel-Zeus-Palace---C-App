namespace allhlepidrash
{
    partial class Control_Orders_employee
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
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            send_message_button = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(39, 99);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 637);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(420, 99);
            panel2.Name = "panel2";
            panel2.Size = new Size(956, 586);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(128, 45);
            label1.Name = "label1";
            label1.Size = new Size(119, 38);
            label1.TabIndex = 1;
            label1.Text = "Πελάτες";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(789, 45);
            label2.Name = "label2";
            label2.Size = new Size(138, 38);
            label2.TabIndex = 1;
            label2.Text = "Συνομιλία";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(503, 691);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Πληκτρολογίστε κάτι";
            textBox1.Size = new Size(670, 45);
            textBox1.TabIndex = 0;
            // 
            // send_message_button
            // 
            send_message_button.Location = new Point(1193, 691);
            send_message_button.Name = "send_message_button";
            send_message_button.Size = new Size(112, 45);
            send_message_button.TabIndex = 1;
            send_message_button.Text = "Αποστολή";
            send_message_button.UseVisualStyleBackColor = true;
            send_message_button.Click += send_message_button_Click;
            // 
            // Control_Orders_employee
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(1506, 748);
            Controls.Add(label2);
            Controls.Add(send_message_button);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Control_Orders_employee";
            Text = "Control_employee_orders";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Button send_message_button;
        private TextBox textBox1;
    }
}