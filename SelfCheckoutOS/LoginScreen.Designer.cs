namespace SelfCheckoutOS
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 30F);
            textBox1.Location = new Point(975, 470);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(943, 61);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 80F);
            label1.Location = new Point(1245, 97);
            label1.Name = "label1";
            label1.Size = new Size(368, 142);
            label1.TabIndex = 1;
            label1.Text = "Log-In";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 23F);
            label2.Location = new Point(975, 406);
            label2.Name = "label2";
            label2.Size = new Size(271, 42);
            label2.TabIndex = 2;
            label2.Text = "Generated API Key";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 25F);
            button1.Location = new Point(1214, 859);
            button1.Name = "button1";
            button1.Size = new Size(505, 91);
            button1.TabIndex = 3;
            button1.Text = "Log-In";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(2897, 1240);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginScreen";
            Text = "Login - Self Checkout OS";
            Load += LoginScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}