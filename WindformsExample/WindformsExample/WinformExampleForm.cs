namespace WindformsExample
{
    public partial class WinformExampleForm : Form
    {
        public WinformExampleForm()
        {
            InitializeComponent();
            SetDefaults();
        }

        private void SetDefaults()
        {
            NameTextBox.Text = "";
            NameTextBox.BackColor = Color.LightYellow;
            AgeTextBox.Text = "";
            AgeTextBox.BackColor = Color.LightYellow;
            CityTextBox.Text = "";
            PhoneTextBox.Text = "";

            UpperCaseRadioButton.Checked = true;
            SubmitButton.Enabled = false;
        }

        private bool ValidateFields()
        {
            bool valid = true;

            string message = "";
            if (PhoneTextBox.Text == "")
            {
                message = "Phone number is required.\n" + message;
                PhoneTextBox.Focus();
            }

            if (CityTextBox.Text == "")
            {
                message = "Location is required.\n" + message;
                CityTextBox.Focus();
            }

            if (AgeTextBox.Text == "")
            {
                message = "Age is required.\n" + message;
                AgeTextBox.Focus();
            }

            if (NameTextBox.Text == "")
            {
                message = "Name is required.\n" + message;
                NameTextBox.Focus();
            }

            if (message != "")
            {
                valid = false;
                MessageBox.Show(message);

            }
            return valid;
        }

        private void Uppercase()
        {
            if (UpperCaseRadioButton.Checked)
            {
                NameTextBox.Text = NameTextBox.Text.ToUpper();

            }
        }

        private void Reverse()
        {
            if (ReverseCaseRadioButton.Checked)
            {
                NameTextBox.Text = new string(NameTextBox.Text.Reverse().ToArray());
            }
        }

        //Event Handlers Below
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (ValidateFields()) ;
            {
                //this.Text = NameTextBox.Text;
                Uppercase();
                Reverse();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (NameTextBox.Text != "")
            {
                NameTextBox.BackColor = Color.White;
                SubmitButton.Enabled = true;
            }
            else
            {
                NameTextBox.BackColor = Color.LightYellow;
                SubmitButton.Enabled = false;
            }
        }

        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (AgeTextBox.Text != "")
            {
                AgeTextBox.BackColor = Color.White;
                SubmitButton.Enabled = true;
            }
            else
            {
                AgeTextBox.BackColor = Color.LightYellow;
                SubmitButton.Enabled = false;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
