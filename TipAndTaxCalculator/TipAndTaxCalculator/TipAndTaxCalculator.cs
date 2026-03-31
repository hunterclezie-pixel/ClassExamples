namespace TipAndTaxCalculator
{
    public partial class TipAndTaxCalculator : Form
    {
        public TipAndTaxCalculator()
        {
            InitializeComponent();
            SetDefaults();
        }
        /*
        [x] Set Defaults
        [] Tip Amount after discount exlude tax
        [] Calculate state tax amount after discount exlude tip
        [] Claculate discounts amounts / total discount
        [] diplay original, discounts, tip, tax, amount due formatted as currency
        */

        //custom networks -----------------------------------------------------------

        /// <summary>
        /// Resets all input fields and controls to their default values for a new calculation session.
        /// </summary>
        /// <remarks>This method clears any existing values and selections in the UI, preparing the form
        /// for new user input. It is typically called when starting a new calculation or after completing a
        /// transaction.</remarks>
        void SetDefaults()
        {
            DollarAmountTextBox.Text = "";
            Tip15RadioButton.Checked = true;
            TipCustomTextBox.Text = "0.00";
            TipCustomTextBox.Enabled = false;
            DiscountAAACheckBox.Checked = false;
            DiscountDCCheckBox.Checked = false;
            DisplayLabel.Text = "";
            DollarAmountTextBox.Select();
            DollarAmountTextBox.BackColor = Color.LightYellow;
        }

        bool AllFieldsValid()
        {
            bool _valid = true;
            //This checks if the text in the DollarAmountTextBox can be parsed as a decimal.
            try
            {
                decimal.Parse(DollarAmountTextBox.Text);
                DollarAmountTextBox.BackColor = Color.White;
            }
            catch (Exception)
            {
                DollarAmountTextBox.BackColor = Color.LightYellow;
                _valid = false;
            }

            // This checks if the text in the TipCustomTextBox can be parsed as a decimal.
            try
            {
                decimal.Parse(TipCustomTextBox.Text);
                TipCustomTextBox.BackColor = Color.White;
            }
            catch (Exception)
            {
                TipCustomTextBox.BackColor = Color.LightYellow;
                _valid = false;
            }
            return true;
        }

        /// <summary>
        /// Calculates the AAA discount amount based on the specified total.
        /// </summary>
        /// <param name="thisAmount">The total amount to which the AAA discount will be applied. Must be a non-negative value.</param>
        /// <returns>A decimal value representing 3 percent of the specified amount. Returns 0 if the input is 0.</returns>
        decimal CalculateAAADiscount(decimal thisAmount)
        {
            return thisAmount * 0.03m;
        }

        /// <summary>
        /// Calculates the discount amount for a Diner Card transaction based on the specified purchase amount.
        /// </summary>
        /// <param name="thisAmount">The total purchase amount to which the Diner Card discount will be applied. Must be a non-negative value.</param>
        /// <returns>The calculated discount amount, equal to 5% of the specified purchase amount.</returns>
        decimal CalculateDinerCardDiscount(decimal thisAmount)
        {
            return thisAmount * 0.05m;
        }

        /// <summary>
        /// Calculates the tax amount for a specified monetary value using a fixed tax rate of 6%.
        /// </summary>
        /// <param name="thisAmount">The monetary value on which tax is to be calculated. Must be a non-negative decimal.</param>
        /// <returns>The calculated tax amount as a decimal. Returns 0 if the input value is 0.</returns>
        decimal CalculateTaxOn(decimal thisAmount)
        {
            return thisAmount * 0.06m;
        }

        /// <summary>
        /// Calculates the tip amount based on the specified subtotal and the selected tip percentage option.
        /// </summary>
        /// <remarks>The tip percentage is determined by the selected radio button. If a custom tip option
        /// is selected, additional logic may be required. If no valid option is selected, the method returns zero and
        /// displays a message.</remarks>
        /// <param name="thisAmount">The subtotal amount for which the tip is to be calculated. Must be a non-negative value.</param>
        /// <returns>A decimal value representing the calculated tip amount. The value depends on the selected tip percentage
        /// option.</returns>
        decimal CalculateTip(decimal thisAmount , decimal customTip = 0)
        {
            decimal subTotal = 0;
            switch (true)
            {
                case bool when Tip15RadioButton.Checked:
                    subTotal = thisAmount * 0.15m;
                    break;
                case bool when Tip18RadioButton.Checked:
                    subTotal = thisAmount * 0.18m;
                    break;
                case bool when Tip20RadioButton.Checked:
                    subTotal = thisAmount * 0.20m;
                    break;
                case bool when TipCustomRadioButton.Checked:
                    subTotal = customTip;
                    break;
                default:
                    MessageBox.Show("Don't come by my house, don't even talk to me, we're done...");
                    break;
            }
            return subTotal;
        }

        //Event handlers below here -------------------------------------------------
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            decimal originalAmount = 0;
            decimal totalDiscount = 0;
            decimal tax = 0;
            decimal tip = 0;
            decimal amountDue = 0;
            int padding = 20;
            if (AllFieldsValid())
            {
                originalAmount = decimal.Parse(DollarAmountTextBox.Text);
                totalDiscount += CalculateAAADiscount(originalAmount);
                totalDiscount += CalculateDinerCardDiscount(originalAmount);
                tax = CalculateTaxOn(originalAmount - totalDiscount);
                tip = CalculateTip(originalAmount - totalDiscount + tax);
                amountDue = originalAmount - totalDiscount + tax + tip;  
                //Todo: refactor to papa luke
                DisplayLabel.Text = $"Original Amount:".PadRight(padding) + $"{originalAmount.ToString("C")}\n" +
                                    $"Total Discount:".PadRight(padding) + $"{totalDiscount.ToString("C")}\n" +
                                    $"Sales Tax:".PadRight(padding) + $"{tax.ToString("C")}\n" +
                                    $"Subtotal:".PadRight(padding) + $"{(originalAmount - totalDiscount + tax).ToString("C")}\n" +
                                    $"Tip:".PadRight(padding) + $"{tip.ToString("C")}\n" +
                                    $"Total:".PadRight(padding) + $"{amountDue.ToString("C")}";
            }
        }

        private void DollarAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            AllFieldsValid();
        }

        private void TipCustomRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (TipCustomRadioButton.Checked)
            { 
                TipCustomTextBox.Enabled = true;
            }
            else             
            {
                TipCustomTextBox.Enabled = false;
                TipCustomTextBox.Text = "";
            }
        }
    }
}
