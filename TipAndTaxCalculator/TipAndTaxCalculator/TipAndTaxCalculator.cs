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
            TipCustomTextBox.Text = "";
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
            return true;
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
        decimal CalculateTip(decimal thisAmount)
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
                    //TODO
                    break;
                default:
                    MessageBox.Show("Don't come by my house, don't even talk to me, we're done...");
                    break;
            }
            return 0.00m;
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
