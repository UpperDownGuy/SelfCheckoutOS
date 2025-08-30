namespace SelfCheckoutOS
{
    partial class MainDash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDash));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            launchcustomerside = new Button();
            label5 = new Label();
            exit = new Button();
            logout = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            enablescanmode = new Button();
            disablescanmode = new Button();
            closecustomerside = new Button();
            items = new Label();
            one = new Label();
            two = new Label();
            three = new Label();
            four = new Label();
            five = new Label();
            ten = new Label();
            nine = new Label();
            eight = new Label();
            seven = new Label();
            six = new Label();
            status = new Label();
            id = new TextBox();
            scan = new Button();
            pay = new Button();
            label20 = new Label();
            label21 = new Label();
            info = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(328, 54);
            label1.TabIndex = 0;
            label1.Text = "Self Checkout OS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(51, 63);
            label2.Name = "label2";
            label2.Size = new Size(232, 25);
            label2.TabIndex = 1;
            label2.Text = "- Made By Alexander 💖 - ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 50F);
            label3.Location = new Point(2510, 11);
            label3.Name = "label3";
            label3.Size = new Size(375, 89);
            label3.TabIndex = 2;
            label3.Text = "Main Menu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(2626, 100);
            label4.Name = "label4";
            label4.Size = new Size(149, 28);
            label4.TabIndex = 3;
            label4.Text = "- Cashier Side - ";
            // 
            // launchcustomerside
            // 
            launchcustomerside.Location = new Point(11, 645);
            launchcustomerside.Name = "launchcustomerside";
            launchcustomerside.Size = new Size(272, 35);
            launchcustomerside.TabIndex = 4;
            launchcustomerside.Text = "Launch Customer Side";
            launchcustomerside.UseVisualStyleBackColor = true;
            launchcustomerside.Click += launchcustomerside_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(-215, 500);
            label5.Name = "label5";
            label5.Size = new Size(3249, 19);
            label5.TabIndex = 5;
            label5.Text = resources.GetString("label5.Text");
            // 
            // exit
            // 
            exit.Location = new Point(12, 522);
            exit.Name = "exit";
            exit.Size = new Size(124, 35);
            exit.TabIndex = 6;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // logout
            // 
            logout.Location = new Point(142, 522);
            logout.Name = "logout";
            logout.Size = new Size(141, 35);
            logout.TabIndex = 7;
            logout.Text = "Log-Out";
            logout.UseVisualStyleBackColor = true;
            logout.Click += logout_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F);
            label6.Location = new Point(1401, 463);
            label6.Name = "label6";
            label6.Size = new Size(177, 37);
            label6.TabIndex = 8;
            label6.Text = "Control Panel";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 40F);
            label7.Location = new Point(1401, 16);
            label7.Name = "label7";
            label7.Size = new Size(201, 72);
            label7.TabIndex = 9;
            label7.Text = "Status: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 50F);
            label8.Location = new Point(1435, 88);
            label8.Name = "label8";
            label8.Size = new Size(130, 89);
            label8.TabIndex = 10;
            label8.Text = "✅";
            // 
            // enablescanmode
            // 
            enablescanmode.Location = new Point(11, 563);
            enablescanmode.Name = "enablescanmode";
            enablescanmode.Size = new Size(272, 35);
            enablescanmode.TabIndex = 11;
            enablescanmode.Text = "Enable Scan Mode";
            enablescanmode.UseVisualStyleBackColor = true;
            enablescanmode.Click += enablescanmode_Click;
            // 
            // disablescanmode
            // 
            disablescanmode.Enabled = false;
            disablescanmode.Location = new Point(11, 604);
            disablescanmode.Name = "disablescanmode";
            disablescanmode.Size = new Size(272, 35);
            disablescanmode.TabIndex = 12;
            disablescanmode.Text = "Disable Scan Mode";
            disablescanmode.UseVisualStyleBackColor = true;
            disablescanmode.Click += disablescanmode_Click;
            // 
            // closecustomerside
            // 
            closecustomerside.Enabled = false;
            closecustomerside.Location = new Point(11, 686);
            closecustomerside.Name = "closecustomerside";
            closecustomerside.Size = new Size(272, 35);
            closecustomerside.TabIndex = 13;
            closecustomerside.Text = "Close Customer Side";
            closecustomerside.UseVisualStyleBackColor = true;
            closecustomerside.Click += closecustomerside_Click;
            // 
            // items
            // 
            items.AutoSize = true;
            items.Font = new Font("Segoe UI", 17F);
            items.Location = new Point(1450, 526);
            items.Name = "items";
            items.Size = new Size(75, 31);
            items.TabIndex = 14;
            items.Text = "Items:";
            // 
            // one
            // 
            one.AutoSize = true;
            one.Font = new Font("Segoe UI", 17F);
            one.Location = new Point(1390, 567);
            one.Name = "one";
            one.Size = new Size(31, 31);
            one.TabIndex = 15;
            one.Text = "1:";
            // 
            // two
            // 
            two.AutoSize = true;
            two.Font = new Font("Segoe UI", 17F);
            two.Location = new Point(1390, 598);
            two.Name = "two";
            two.Size = new Size(31, 31);
            two.TabIndex = 16;
            two.Text = "2:";
            // 
            // three
            // 
            three.AutoSize = true;
            three.Font = new Font("Segoe UI", 17F);
            three.Location = new Point(1390, 629);
            three.Name = "three";
            three.Size = new Size(31, 31);
            three.TabIndex = 17;
            three.Text = "3:";
            // 
            // four
            // 
            four.AutoSize = true;
            four.Font = new Font("Segoe UI", 17F);
            four.Location = new Point(1390, 660);
            four.Name = "four";
            four.Size = new Size(31, 31);
            four.TabIndex = 18;
            four.Text = "4:";
            // 
            // five
            // 
            five.AutoSize = true;
            five.Font = new Font("Segoe UI", 17F);
            five.Location = new Point(1390, 691);
            five.Name = "five";
            five.Size = new Size(31, 31);
            five.TabIndex = 19;
            five.Text = "5:";
            // 
            // ten
            // 
            ten.AutoSize = true;
            ten.Font = new Font("Segoe UI", 17F);
            ten.Location = new Point(1378, 846);
            ten.Name = "ten";
            ten.Size = new Size(43, 31);
            ten.TabIndex = 24;
            ten.Text = "10:";
            // 
            // nine
            // 
            nine.AutoSize = true;
            nine.Font = new Font("Segoe UI", 17F);
            nine.Location = new Point(1390, 815);
            nine.Name = "nine";
            nine.Size = new Size(31, 31);
            nine.TabIndex = 23;
            nine.Text = "9:";
            // 
            // eight
            // 
            eight.AutoSize = true;
            eight.Font = new Font("Segoe UI", 17F);
            eight.Location = new Point(1390, 784);
            eight.Name = "eight";
            eight.Size = new Size(31, 31);
            eight.TabIndex = 22;
            eight.Text = "8:";
            // 
            // seven
            // 
            seven.AutoSize = true;
            seven.Font = new Font("Segoe UI", 17F);
            seven.Location = new Point(1390, 753);
            seven.Name = "seven";
            seven.Size = new Size(31, 31);
            seven.TabIndex = 21;
            seven.Text = "7:";
            // 
            // six
            // 
            six.AutoSize = true;
            six.Font = new Font("Segoe UI", 17F);
            six.Location = new Point(1390, 722);
            six.Name = "six";
            six.Size = new Size(31, 31);
            six.TabIndex = 20;
            six.Text = "6:";
            // 
            // status
            // 
            status.AutoSize = true;
            status.Font = new Font("Segoe UI", 14F);
            status.Location = new Point(1378, 925);
            status.Name = "status";
            status.Size = new Size(85, 25);
            status.TabIndex = 25;
            status.Text = "Disabled";
            // 
            // id
            // 
            id.Enabled = false;
            id.Location = new Point(1378, 953);
            id.Name = "id";
            id.Size = new Size(224, 23);
            id.TabIndex = 26;
            // 
            // scan
            // 
            scan.Enabled = false;
            scan.Location = new Point(1378, 982);
            scan.Name = "scan";
            scan.Size = new Size(224, 29);
            scan.TabIndex = 27;
            scan.Text = "Scan";
            scan.UseVisualStyleBackColor = true;
            scan.Click += scan_Click;
            // 
            // pay
            // 
            pay.Enabled = false;
            pay.Font = new Font("Segoe UI", 13F);
            pay.Location = new Point(1452, 1066);
            pay.Name = "pay";
            pay.Size = new Size(90, 41);
            pay.TabIndex = 28;
            pay.Text = "Pay";
            pay.UseVisualStyleBackColor = true;
            pay.Click += pay_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 14F);
            label20.Location = new Point(1434, 1024);
            label20.Name = "label20";
            label20.Size = new Size(58, 25);
            label20.TabIndex = 29;
            label20.Text = "Price:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 13.5F);
            label21.Location = new Point(1498, 1024);
            label21.Name = "label21";
            label21.Size = new Size(56, 25);
            label21.TabIndex = 30;
            label21.Text = "$0.00";
            // 
            // info
            // 
            info.Location = new Point(2626, 1191);
            info.Name = "info";
            info.Size = new Size(259, 37);
            info.TabIndex = 31;
            info.Text = "Application Info";
            info.UseVisualStyleBackColor = true;
            info.Click += info_Click;
            // 
            // MainDash
            // 
            AcceptButton = scan;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(2897, 1240);
            Controls.Add(info);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(pay);
            Controls.Add(scan);
            Controls.Add(id);
            Controls.Add(status);
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
            Controls.Add(items);
            Controls.Add(closecustomerside);
            Controls.Add(disablescanmode);
            Controls.Add(enablescanmode);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(logout);
            Controls.Add(exit);
            Controls.Add(label5);
            Controls.Add(launchcustomerside);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainDash";
            Text = "Main Menu - Self Checkout OS";
            Load += MainDash_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button launchcustomerside;
        private Label label5;
        private Button exit;
        private Button logout;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button enablescanmode;
        private Button disablescanmode;
        private Button closecustomerside;
        private Label items;
        private Label one;
        private Label two;
        private Label three;
        private Label four;
        private Label five;
        private Label ten;
        private Label nine;
        private Label eight;
        private Label seven;
        private Label six;
        private Label status;
        private TextBox id;
        private Button scan;
        private Button pay;
        private Label label20;
        private Label label21;
        private Button info;
    }
}