namespace SelfCheckoutOS
{
    partial class info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(info));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 100F);
            label1.Location = new Point(1355, 9);
            label1.Name = "label1";
            label1.Size = new Size(337, 177);
            label1.TabIndex = 0;
            label1.Text = "Info:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 60F);
            label2.Location = new Point(1280, 186);
            label2.Name = "label2";
            label2.Size = new Size(507, 106);
            label2.TabIndex = 1;
            label2.Text = "Version: 0.0.1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 60F);
            label3.Location = new Point(1250, 871);
            label3.Name = "label3";
            label3.Size = new Size(549, 106);
            label3.TabIndex = 2;
            label3.Text = "Developed By:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 60F);
            label4.Location = new Point(1174, 992);
            label4.Name = "label4";
            label4.Size = new Size(707, 106);
            label4.TabIndex = 3;
            label4.Text = "Alexander - Owner";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 40F);
            button1.Location = new Point(1028, 1112);
            button1.Name = "button1";
            button1.Size = new Size(976, 116);
            button1.TabIndex = 4;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // info
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(2897, 1240);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "info";
            Text = "Info - Self Checkout OS";
            Load += info_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}