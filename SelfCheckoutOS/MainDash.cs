using System;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelfCheckoutOS
{
    public partial class MainDash : Form
    {
        private int[] itemCounts = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
        private int[] checkoutids = {1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010};
        private int[] prices = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        private string[] itemNames = { "Apple", "Banana", "Carrot", "Doughnut", "Egg", "Fish", "Grapes", "Honey", "Ice Cream", "Juice" };

        public MainDash()
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
            Application.Exit();
        }

        private void MainDash_Load(object sender, EventArgs e)
        {
            // Initialize total as currency
            label21.Text = 0m.ToString("C", CultureInfo.GetCultureInfo("en-US"));
        }

        private void info_Click(object sender, EventArgs e)
        {
            info information = new info();
            information.Show();
            this.Close();
        }

        private async void pay_Click(object sender, EventArgs e)
        {
            // Show Paid!
            pay.Text = "Paid!";
            ClientSide.Instance.finishtransaction();
            // Reset counts
            for (int i = 0; i < itemCounts.Length; i++)
                itemCounts[i] = 0;

            // Reset all line items back to default with colon
            one.Text = "1:";
            two.Text = "2:";
            three.Text = "3:";
            four.Text = "4:";
            five.Text = "5:";
            six.Text = "6:";
            seven.Text = "7:";
            eight.Text = "8:";
            nine.Text = "9:";
            ten.Text = "10:";

            // Reset total on MainDash
            label21.Text = 0m.ToString("C", CultureInfo.GetCultureInfo("en-US"));

            // Reset ClientSide too (if open)
            if (ClientSide.Instance != null)
            {
                // Requires ClientSide to implement: public void ClearAll()
                ClientSide.Instance.ClearAll();
            }

            await Task.Delay(1500);
            pay.Text = "Pay";
        }


        private void scan_Click(object sender, EventArgs e)
        {
            // ✅ Limit: Stop if 10 items already scanned
            int totalItems = itemCounts.Sum();
            if (totalItems >= 10)
            {
                scan.Text = "Limit Reached";
                return;
            }

            if (int.TryParse(id.Text, out int enteredId))
            {
                int index = Array.IndexOf(checkoutids, enteredId);

                if (index != -1)
                {
                    // Increment count
                    itemCounts[index]++;

                    int foundId = checkoutids[index];
                    int price = prices[index];
                    int count = itemCounts.Sum(); // position in the list
                    string itemName = itemNames[index];

                    // Update ClientSide labels
                    ClientSide.Instance.UpdateLabel(count, itemName, price);

                    // Put on the correct line, formatted price
                    string lineText = $"{count}: {itemName} | {price.ToString("C", CultureInfo.GetCultureInfo("en-US"))}";

                    switch (count)
                    {
                        case 1: one.Text = lineText; break;
                        case 2: two.Text = lineText; break;
                        case 3: three.Text = lineText; break;
                        case 4: four.Text = lineText; break;
                        case 5: five.Text = lineText; break;
                        case 6: six.Text = lineText; break;
                        case 7: seven.Text = lineText; break;
                        case 8: eight.Text = lineText; break;
                        case 9: nine.Text = lineText; break;
                        case 10: ten.Text = lineText; break;
                    }

                    // Update total
                    decimal currentTotal = 0;
                    decimal.TryParse(label21.Text,
                        NumberStyles.Currency,
                        CultureInfo.GetCultureInfo("en-US"),
                        out currentTotal);

                    currentTotal += price;
                    label21.Text = currentTotal.ToString("C", CultureInfo.GetCultureInfo("en-US"));
                }
                else
                {
                    scan.Text = "Invalid Input";
                }
            }
            else
            {
                scan.Text = "Invalid Input";
            }
        }

        private void closecustomerside_Click(object sender, EventArgs e)
        {
            ClientSide client = ClientSide.Instance;
            client.Close();
        }

        private void launchcustomerside_Click(object sender, EventArgs e)
        {
            ClientSide client = new ClientSide();
            client.Show();

            if (client != null)
            {
                client.Show();
            }

            id.Enabled = true;
            scan.Enabled = true;
            pay.Enabled = true;
            launchcustomerside.Enabled = false;
            closecustomerside.Enabled = true;
            disablescanmode.Enabled = true;
            enablescanmode.Enabled = false;
        }

        private void disablescanmode_Click(object sender, EventArgs e)
        {
            id.Enabled = false;
            scan.Enabled = false;
            pay.Enabled = false;
            launchcustomerside.Enabled = true;
            closecustomerside.Enabled = false;
            disablescanmode.Enabled = false;
            enablescanmode.Enabled = true;
            ClientSide client = ClientSide.Instance;
            client.Close();
        }

        private void enablescanmode_Click(object sender, EventArgs e)
        {
            ClientSide client = new ClientSide();
            client.Show();

            if (client != null)
            {
                client.Show();
            }

            id.Enabled = true;
            scan.Enabled = true;
            pay.Enabled = true;
            launchcustomerside.Enabled = false;
            closecustomerside.Enabled = true;
            disablescanmode.Enabled = true;
            enablescanmode.Enabled = false;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
            Welcome welcome = new Welcome();
            welcome.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
