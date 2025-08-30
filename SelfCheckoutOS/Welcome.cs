namespace SelfCheckoutOS
{
    public partial class Welcome : Form
    {
        public Welcome()
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

        private void LoginScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // closes the entire app when this form closes
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            LoginScreen login = new LoginScreen();
            login.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
