using System;
using System.Globalization;
using System.Windows.Forms;

namespace SelfCheckoutOS
{
    public partial class ClientSide : Form
    {
        // Array to hold all your labels
        private Label[] labels;

        // Make a static instance so other forms can access ClientSide
        public static ClientSide Instance { get; private set; }

        public ClientSide()
        {
            InitializeComponent();

            // Disable resizing
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            // Disable Minimize/Maximize
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Remove the control box (X button too)
            this.ControlBox = false;

            // Register instance for cross-form access
            Instance = this;

            // Put your labels into an array, in order
            labels = new Label[]
            {
                one, two, three, four, five, six, seven, eight, nine, ten
            };

            // ✅ Initialize total display as currency if empty
            if (string.IsNullOrWhiteSpace(total.Text))
            {
                total.Text = 0m.ToString("C", CultureInfo.GetCultureInfo("en-US"));
            }
        }

        // Method to update the correct label
        public void UpdateLabel(int count, string name, int price)
        {
            if (count >= 1 && count <= labels.Length)
            {   
                labels[count - 1].Text = $"{count}: {name} | {price.ToString("C", CultureInfo.GetCultureInfo("en-US"))}";
            }

            // ✅ Safely parse total as currency and update
            decimal currentTotal = 0;
            decimal.TryParse(total.Text,
                NumberStyles.Currency,
                CultureInfo.GetCultureInfo("en-US"),
                out currentTotal);

            currentTotal += price;
            total.Text = currentTotal.ToString("C", CultureInfo.GetCultureInfo("en-US"));
        }

        // ✅ Method to clear everything (for Pay button)
        public void ClearAll()
        {
            for (int i = 0; i < labels.Length; i++)
            {
                labels[i].Text = $"{i + 1}:";
            }

            total.Text = 0m.ToString("C", CultureInfo.GetCultureInfo("en-US"));
        }

        private void LoginScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // closes the entire app when this form closes
        }

        public async void finishtransaction()
        {
            finish.Text = "Thanks For Shopping!";
            await Task.Delay(1000);
            finish.Text = "";
        }

        private void ClientSide_Load(object sender, EventArgs e)
        {

        }
    }
}
