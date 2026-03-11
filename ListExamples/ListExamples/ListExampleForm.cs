namespace ListExamples
{
    public partial class ListExampleForm : Form
    {
        public ListExampleForm()
        {
            InitializeComponent();
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
            LastNameLabel.Text = temp[0];

            //this.Text = DisplayListBox.SelectedIndex.ToString();
            //FirstNameTextBox.Text = DisplayListBox.SelectedItem.ToString();
        }

        private void SelectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //select the corosponding entry in the list box
            DisplayListBox.SelectedIndex = SelectionComboBox.SelectedIndex;
        }
    }
}

