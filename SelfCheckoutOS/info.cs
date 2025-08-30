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
    public partial class info : Form
    {
        public info()
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

        private void button1_Click(object sender, EventArgs e)
        {
            MainDash main = new MainDash();
            main.Show();
            this.Close();

        }

        private void LoginScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // closes the entire app when this form closes
        }

        private void info_Load(object sender, EventArgs e)
        {

        }
    }
}
