namespace vending_machine_attempt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisableAll();
        }

        private void cocacola_Click(object sender, EventArgs e)
        {
            String product = "Cola";
            Double amount = 4.00;
            AddItem(product, amount);
            AmountTotal();
            LblAct.Text = (product + " added to list");
        }

        private void Water_Click(object sender, EventArgs e)
        {
            string product = "Water";
            Double amount = 3.50;
            AddItem(product, amount);
            AmountTotal();
            LblAct.Text = (product + " added to list");
        }

        private void Pepsi_Click(object sender, EventArgs e)
        {
            string product = "Pepsi";
            Double amount = 4.00;
            AddItem(product, amount);
            AmountTotal();
            LblAct.Text = (product + " added to list");
        }

        private void Oreo_Click(object sender, EventArgs e)
        {
            string product = "Oreo";
            Double amount = 4.15;
            AddItem(product, amount);
            AmountTotal();
            LblAct.Text = (product + " added to list");
        }

        private void Snickers_Click(object sender, EventArgs e)
        {
            string product = "Snickers";
            Double amount = 3.50;
            AddItem(product, amount);
            AmountTotal();
            LblAct.Text = (product + " added to list");
        }

        private void Kitkat_Click(object sender, EventArgs e)
        {
            string product = "KitKat";
            Double amount = 3.50;
            AddItem(product, amount);
            AmountTotal();
            LblAct.Text = (product + " added to list");
        }

        private void Pringles_Click(object sender, EventArgs e)
        {
            string product = "Pringles";
            Double amount = 4.00;
            AddItem(product, amount);
            AmountTotal();
            LblAct.Text = (product + " added to list");
        }

        private void Skittles_Click(object sender, EventArgs e)
        {
            string product = "Skittles";
            Double amount = 3.50;
            AddItem(product, amount);
            AmountTotal();
            LblAct.Text = (product + " added to list");
        }

        private void AmountTotal()
        {
            //setting the default total to 0
            double total = 0;

            // a loop to go through each item in the price listbox
            foreach (var amount in PriceList.Items)
            {
                //converting each amount in the list to double and adding it to the total
                total += Convert.ToDouble(amount);
            }
            TotalAmount.Text = "Total: £" + total.ToString("0.00");
        }


        private void Start_Click(object sender, EventArgs e)
        {
            EnableAll();
            LblAct.Text = ("You Transaction have started");

        }


        private void DisableAll()
        {
            // dsiables all the buttons on the form
            cocacola.Enabled = false;
            Water.Enabled = false;
            Pepsi.Enabled = false;
            Oreo.Enabled = false;
            Snickers.Enabled = false;
            Kitkat.Enabled = false;
            Pringles.Enabled = false;
            Skittles.Enabled = false;
            TwoPound.Enabled = false;
            OnePound.Enabled = false;
            FiftyPence.Enabled = false;
            TenPence.Enabled = false;
            FivePence.Enabled = false;
            Checkout.Enabled = false;
            CoinSlot.Enabled = false;
            Cancel.Enabled = false;
            Bin.Enabled = false;
        }

        private void EnableAll()
        {
            cocacola.Enabled = true;
            Water.Enabled = true;
            Pepsi.Enabled = true;
            Oreo.Enabled = true;
            Snickers.Enabled = true;
            Kitkat.Enabled = true;
            Pringles.Enabled = true;
            Skittles.Enabled = true;
            Checkout.Enabled = true;
            Cancel.Enabled = true;
            Bin.Enabled = true;
        }

        private void Checkout_Click(object sender, EventArgs e)
        {
            // all the items buttons will be disabled after the checkout button is clicked

            cocacola.Enabled = false;
            Water.Enabled = false;
            Pepsi.Enabled = false;
            Oreo.Enabled = false;
            Snickers.Enabled = false;
            Kitkat.Enabled = false;
            Pringles.Enabled = false;
            Skittles.Enabled = false;
            Start.Enabled = false;
            Bin.Enabled = false;

            // enabling the coin buttons and coin slot for payment
            TwoPound.Enabled = true;
            OnePound.Enabled = true;
            FiftyPence.Enabled = true;
            TenPence.Enabled = true;
            FivePence.Enabled = true;
            Checkout.Enabled = true;
            CoinSlot.Enabled = true;

            LblAct.Text = ("You have clicked the checkout you can now checkout but can't add item");
        }

        private void TwoPound_MouseDown(object sender, MouseEventArgs e)
        {
            TwoPound.DoDragDrop(2.00, DragDropEffects.Copy);
            LblAct.Text = ("£2.00 coin dragged to the coin slot");
        }

        private void CoinSlot_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(double)))
                e.Effect = DragDropEffects.Copy;
        }

        private void CoinSlot_DragDrop(object sender, DragEventArgs e)
        {
            double coin = (double)e.Data.GetData(typeof(double));

            double CurrentTotal = double.Parse(TotalAmount.Text.Replace("Total: £", ""));
            CurrentTotal -= coin;
            if (CurrentTotal < 0)
            {
                double change = Math.Abs(CurrentTotal);
                CurrentTotal = 0;
                TotalAmount.Text = "£0.00";
                MessageBox.Show("Payment Completed Successfully! \n Your Change is: £" + change.ToString("0.00")
                    + "\n Enjoy Your Item");
                TransactionReceipt();
                DisableAll();
                Start.Enabled = true;
                ItemsAdded.Items.Clear();
                PriceList.Items.Clear();
                

            }
            else if (CurrentTotal == 0)
            {
                TotalAmount.Text = "£0.00";
                MessageBox.Show("Payment completed successfully! Enjoy your Items!");
                TransactionReceipt();
                DisableAll();
                Start.Enabled = true;
                ItemsAdded.Items.Clear();
                PriceList.Items.Clear();

            }
            else
            {
                TotalAmount.Text = "Total: £" + CurrentTotal.ToString("0.00");
            }


        }

        private void OnePound_MouseDown(object sender, MouseEventArgs e)
        {
            OnePound.DoDragDrop(1.00, DragDropEffects.Copy);
            LblAct.Text = ("£1.00 coin dragged to the coin slot");

        }

        private void FiftyPence_MouseDown(object sender, MouseEventArgs e)
        {
            FiftyPence.DoDragDrop(0.50, DragDropEffects.Copy);
            LblAct.Text = ("£0.50 coin dragged to the coin slot");
        }

        private void TenPence_MouseDown(object sender, MouseEventArgs e)
        {
            TenPence.DoDragDrop(0.10, DragDropEffects.Copy);
            LblAct.Text = ("£0.10 coin dragged to the coin slot");
        }

        private void FivePence_MouseDown(object sender, MouseEventArgs e)
        {
            FivePence.DoDragDrop(0.05, DragDropEffects.Copy);
            LblAct.Text = ("£0.05 coin dragged to the coin slot");

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel the transaction?",
                "Cancel Transaction",
                MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                TotalAmount.Text = "Total: £0.00";
                MessageBox.Show("Transaction cancelled successfully.");
                DisableAll();
                Start.Enabled = true;
                ItemsAdded.Items.Clear();
                PriceList.Items.Clear();
                LblAct.Text = ("You cancelled your transaction");
                LblAct.Text = ("Click START to begin a new transaction");

            }
            else
            {
                MessageBox.Show("Transaction continues.");
                LblAct.Text = ("You initiated cancellation of transaction but failed");
            }
        }

        private void ItemsAdded_MouseDown(object sender, MouseEventArgs e)
        {
            if (ItemsAdded.SelectedItem != null)
            {
                int selectedIndex = ItemsAdded.SelectedIndex;
                ItemsAdded.DoDragDrop(selectedIndex, DragDropEffects.Move);
            }
        }

        private void Bin_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(int)))
            {
                e.Effect = DragDropEffects.Move;
            }

        }

        private void Bin_DragDrop(object sender, DragEventArgs e)
        {
            int index = (int)e.Data.GetData(typeof(int));

            if (index >= 0 && index < ItemsAdded.Items.Count)
            {
                ItemsAdded.Items.RemoveAt(index);
                PriceList.Items.RemoveAt(index);
                MessageBox.Show("Item Removed Successfully");
                AmountTotal();

                LblAct.Text = ("Item removed from the list");

            }
        }

        private void AddItem(string product, double amount)
        {
            bool found = false;
            for (int i = 0; i < ItemsAdded.Items.Count; i++)
            {
                string currentItem = ItemsAdded.Items[i].ToString();
                if (currentItem.StartsWith(product))
                {
                    found = true;

                    int QuantityStart = currentItem.IndexOf("x") + 1;
                    int Quantity = int.Parse(currentItem.Substring(QuantityStart));
                    Quantity++;
                    ItemsAdded.Items[i] = product + "x" + Quantity;
                    double NewAmount = Convert.ToDouble(PriceList.Items[i]);
                    PriceList.Items[i] = (NewAmount + amount).ToString("0.00");
                    break;
                }
            }
            if (!found)
            {
                ItemsAdded.Items.Add(product + " x1");
                PriceList.Items.Add(amount.ToString("0.00"));
            }
        }


        private  void TransactionReceipt()
        {
            // creating a file name with the current date and time
            double Total = 0;
            string FileName = "Receipt_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + "txt";
            
            // creating a streamwriter to write to the file 
            using (StreamWriter writer = new StreamWriter(FileName))
            {
                writer.WriteLine("=== Transaction Summary ===");
                writer.WriteLine("Date: " + DateTime.Now.ToString(FileName));
                writer.WriteLine();

                // looping through each item in the items listbox and writing it to the file
                for (int i = 0; i < ItemsAdded.Items.Count; i++)
                {
                    string item = ItemsAdded.Items[i].ToString();
                    double price = double.Parse(PriceList.Items[i].ToString());
                    writer.WriteLine("" + item + " - £" + price.ToString("0.00"));
                    Total += price;
                }

                writer.WriteLine();
                writer.WriteLine("Total Amount: £" + Total.ToString("0.00"));
                writer.WriteLine("=== Thank You! ====");
                

            }
            MessageBox.Show("Trasaction receipt created successfully!");
        }
    }
}
