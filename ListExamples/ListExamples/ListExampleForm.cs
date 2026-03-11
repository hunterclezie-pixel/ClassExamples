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
    }
}

