namespace SelfCheckoutOS
{
    partial class Welcome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Button login;
            Button button1;
            Button button2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            login = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // login
            // 
            login.BackColor = Color.CornflowerBlue;
            login.CausesValidation = false;
            login.Font = new Font("Segoe UI", 30F);
            login.Location = new Point(981, 996);
            login.Name = "login";
            login.Size = new Size(433, 65);
            login.TabIndex = 2;
            login.Text = "Log-In";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SlateGray;
            button1.CausesValidation = false;
            button1.Enabled = false;
            button1.Font = new Font("Segoe UI", 30F);
            button1.Location = new Point(1642, 996);
            button1.Name = "button1";
            button1.Size = new Size(433, 65);
            button1.TabIndex = 3;
            button1.Text = "Settings";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.CausesValidation = false;
            button2.Font = new Font("Segoe UI", 30F);
            button2.Location = new Point(1310, 1120);
            button2.Name = "button2";
            button2.Size = new Size(433, 65);
            button2.TabIndex = 5;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 80F);
            label1.Location = new Point(663, 132);
            label1.Name = "label1";
            label1.Size = new Size(659, 142);
            label1.TabIndex = 0;
            label1.Text = "Welcome To:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 100F);
            label2.Location = new Point(981, 464);
            label2.Name = "label2";
            label2.Size = new Size(1094, 177);
            label2.TabIndex = 1;
            label2.Text = "Self Checkout OS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 30F);
            label3.Location = new Point(1683, 939);
            label3.Name = "label3";
            label3.Size = new Size(349, 54);
            label3.TabIndex = 4;
            label3.Text = "-- Coming Soon --";
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(2897, 1240);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(login);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Welcome";
            Text = "Welcome - Self Checkout OS";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button login;
        private Label label3;
    }
}
