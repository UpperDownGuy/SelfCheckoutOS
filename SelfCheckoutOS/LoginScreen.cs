using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelfCheckoutOS
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();

            // Disable resizing
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            // Disable Minimize/Maximize
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Remove the control box (X button too)
            this.ControlBox = false;
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }

        private void LoginScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // closes the entire app when this form closes
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "19887243")
            {
                button1.Text = "Please Wait...";
                await Task.Delay(200);
                button1.Text = "Please Wait.";
                await Task.Delay(200);
                button1.Text = "Please Wait..";
                await Task.Delay(200);
                button1.Text = "Please Wait...";
                await Task.Delay(200);
                button1.Text = "Please Wait.";
                await Task.Delay(200);
                button1.Text = "Please Wait..";
                await Task.Delay(200);
                button1.Text = "Please Wait...";
                await Task.Delay(200);
                button1.Text = "Please Wait.";
                await Task.Delay(200);
                button1.Text = "Please Wait..";
                await Task.Delay(200);

                MainDash main = new MainDash();
                main.Show();
                this.Hide();
            }
            else
            {
                button1.Text = "Invalid API Key!";
                await Task.Delay(1000);
                button1.Text = "Log-In";
            }
        }
    }
}
