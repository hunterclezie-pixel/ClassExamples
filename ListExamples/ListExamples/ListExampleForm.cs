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
            ListExampleMethod();
        }
    }
}

