namespace ListExamples
{
    public partial class ListExampleForm : Form
    {
        public ListExampleForm()
        {
            InitializeComponent();
            SetDefaults();
        }

        //Custom Methids below here --------------------------------------------------------------

        void ListExampleMethod()
        {
            List<string> names = new List<string>();
            names.Add("Sheila");
            names.Add("Bob");
            names.Add("Alex");
            //Console.WriteLine(names.Count); // 2
            this.Text = names.Count.ToString();
            names.Remove("Bob");
            this.Text = names.Count.ToString();
        }

        void SetDefaults()
        {
            //clear all text boxes and list box
            LastNameTextBox.Text = "";
            FirstNameTextBox.Text = "";
            CompanyTextBox.Text = "";
            SelectionComboBox.Text = "";
            DisplayListBox.Text = "";

            //set the background color of the text boxes to light yellow
            LastNameTextBox.BackColor = Color.LightYellow;
            FirstNameTextBox.BackColor = Color.LightYellow;
            CompanyTextBox.BackColor = Color.LightYellow;

            SubmitButton.Enabled = false;
        }

        void ValidateFields()
        {
            {
                bool valid = true;
                string message = "";

                if (CompanyTextBox.Text != "" && LastNameTextBox.Text != "" && FirstNameTextBox.Text != "")
                {
                    SubmitButton.Enabled = true;
                }

                else
                {
                    SubmitButton.Enabled = false;
                }
            }
        }

        void AddItemToListBox()
        {
            DisplayListBox.Items.Add($"{LastNameTextBox.Text},{FirstNameTextBox.Text} {CompanyTextBox.Text}");
        }

        void AddItemToComboBox()
        {
            SelectionComboBox.Items.Add($"{LastNameTextBox.Text},{FirstNameTextBox.Text}");
            if (SelectionComboBox.Items.Count > 0)
            {
                SelectionComboBox.SelectedIndex = 0;
                //SelectionComboBox.SelectedIndex = -1;
            }
        }

        //Event Handlers below here --------------------------------------------------------------

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Close the application
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            //ListExampleMethod();
            AddItemToListBox();
            AddItemToComboBox();
        }

        private void DisplayListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //isolate company
            string[] temp = DisplayListBox.SelectedItem.ToString().Split(" ");
            CompanyTextBox.Text = temp[1];
            //isolate first and last name
            temp = temp[0].Split(",");
            FirstNameTextBox.Text = temp[1];
            LastNameTextBox.Text = temp[0];

            //this.Text = DisplayListBox.SelectedIndex.ToString();
            //FirstNameTextBox.Text = DisplayListBox.SelectedItem.ToString();
        }

        private void SelectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //select the corosponding entry in the list box
            DisplayListBox.SelectedIndex = SelectionComboBox.SelectedIndex;
        }

        void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FirstNameTextBox.Text != "")
            {
                FirstNameTextBox.BackColor = Color.White;
            }
            else
            {
                FirstNameTextBox.BackColor = Color.LightYellow;
            }
            ValidateFields();
        }

        void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (LastNameTextBox.Text != "")
            {
                LastNameTextBox.BackColor = Color.White;
            }
            else
            {
                LastNameTextBox.BackColor = Color.LightYellow;
            }
            ValidateFields();
        }

        void CompanyTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CompanyTextBox.Text != "")
            {
                CompanyTextBox.BackColor = Color.White;
            }
            else
            {
                CompanyTextBox.BackColor = Color.LightYellow;
            }
            ValidateFields();
        }
    }
}

