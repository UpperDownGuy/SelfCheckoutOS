namespace SelfCheckoutOS
{
    partial class ClientSide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientSide));
            label1 = new Label();
            total = new Label();
            label2 = new Label();
            one = new Label();
            two = new Label();
            four = new Label();
            three = new Label();
            six = new Label();
            five = new Label();
            eight = new Label();
            seven = new Label();
            ten = new Label();
            nine = new Label();
            finish = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 90F);
            label1.Location = new Point(12, 1022);
            label1.Name = "label1";
            label1.Size = new Size(566, 159);
            label1.TabIndex = 0;
            label1.Text = "Checkout";
            // 
            // total
            // 
            total.AutoSize = true;
            total.Font = new Font("Segoe UI", 90F);
            total.Location = new Point(593, 1022);
            total.Name = "total";
            total.Size = new Size(353, 159);
            total.TabIndex = 1;
            total.Text = "$0.00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 80F);
            label2.Location = new Point(25, 9);
            label2.Name = "label2";
            label2.Size = new Size(340, 142);
            label2.TabIndex = 2;
            label2.Text = "Items:";
            // 
            // one
            // 
            one.AutoSize = true;
            one.Font = new Font("Segoe UI", 50F);
            one.Location = new Point(25, 142);
            one.Name = "one";
            one.Size = new Size(89, 89);
            one.TabIndex = 3;
            one.Text = "1:";
            // 
            // two
            // 
            two.AutoSize = true;
            two.Font = new Font("Segoe UI", 50F);
            two.Location = new Point(25, 231);
            two.Name = "two";
            two.Size = new Size(89, 89);
            two.TabIndex = 4;
            two.Text = "2:";
            // 
            // four
            // 
            four.AutoSize = true;
            four.Font = new Font("Segoe UI", 50F);
            four.Location = new Point(25, 409);
            four.Name = "four";
            four.Size = new Size(89, 89);
            four.TabIndex = 6;
            four.Text = "4:";
            // 
            // three
            // 
            three.AutoSize = true;
            three.Font = new Font("Segoe UI", 50F);
            three.Location = new Point(25, 320);
            three.Name = "three";
            three.Size = new Size(89, 89);
            three.TabIndex = 5;
            three.Text = "3:";
            // 
            // six
            // 
            six.AutoSize = true;
            six.Font = new Font("Segoe UI", 50F);
            six.Location = new Point(25, 587);
            six.Name = "six";
            six.Size = new Size(89, 89);
            six.TabIndex = 8;
            six.Text = "6:";
            // 
            // five
            // 
            five.AutoSize = true;
            five.Font = new Font("Segoe UI", 50F);
            five.Location = new Point(25, 498);
            five.Name = "five";
            five.Size = new Size(89, 89);
            five.TabIndex = 7;
            five.Text = "5:";
            // 
            // eight
            // 
            eight.AutoSize = true;
            eight.Font = new Font("Segoe UI", 50F);
            eight.Location = new Point(25, 755);
            eight.Name = "eight";
            eight.Size = new Size(89, 89);
            eight.TabIndex = 10;
            eight.Text = "8:";
            // 
            // seven
            // 
            seven.AutoSize = true;
            seven.Font = new Font("Segoe UI", 50F);
            seven.Location = new Point(25, 666);
            seven.Name = "seven";
            seven.Size = new Size(89, 89);
            seven.TabIndex = 9;
            seven.Text = "7:";
            // 
            // ten
            // 
            ten.AutoSize = true;
            ten.Font = new Font("Segoe UI", 50F);
            ten.Location = new Point(12, 933);
            ten.Name = "ten";
            ten.Size = new Size(125, 89);
            ten.TabIndex = 12;
            ten.Text = "10:";
            // 
            // nine
            // 
            nine.AutoSize = true;
            nine.Font = new Font("Segoe UI", 50F);
            nine.Location = new Point(25, 844);
            nine.Name = "nine";
            nine.Size = new Size(89, 89);
            nine.TabIndex = 11;
            nine.Text = "9:";
            // 
            // finish
            // 
            finish.AutoSize = true;
            finish.Font = new Font("Segoe UI", 70F);
            finish.Location = new Point(571, 470);
            finish.Name = "finish";
            finish.Size = new Size(0, 125);
            finish.TabIndex = 13;
            // 
            // ClientSide
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(1947, 1190);
            Controls.Add(finish);
            Controls.Add(ten);
            Controls.Add(nine);
            Controls.Add(eight);
            Controls.Add(seven);
            Controls.Add(six);
            Controls.Add(five);
            Controls.Add(four);
            Controls.Add(three);
            Controls.Add(two);
            Controls.Add(one);
            Controls.Add(label2);
            Controls.Add(total);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ClientSide";
            Text = "User - Self Checkout OS";
            Load += ClientSide_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label total;
        private Label label2;
        private Label one;
        private Label two;
        private Label four;
        private Label three;
        private Label six;
        private Label five;
        private Label eight;
        private Label seven;
        private Label ten;
        private Label nine;
        private Label finish;
    }
}