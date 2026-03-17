namespace TipAndTaxCalculator
{
    public partial class TipAndTaxCalculator : Form
    {
        public TipAndTaxCalculator()
        {
            InitializeComponent();
        }
        /*
        [] Set Defaults
        [] Tip Amount after discount exlude tax
        [] Calculate state tax amount after discount exlude tip
        [] Claculate discounts amounts / total discount
        [] diplay original, discounts, tip, tax, amount due formatted as currency
        */

        //custom networks -----------------------------------------------------------

        void SetDefaults()
        {
            DollarAmountTextBox.Text = "";
            Tip15RadioButton.Checked = true;
            TipCustomTextBox.Text = "";
            TipCustomTextBox.Enabled = false;
            DiscountAAACheckBox.Checked = false;
            DiscountDCCheckBox.Checked = false;
        }

        //Event handlers below here -------------------------------------------------
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {

        }
    }
}
