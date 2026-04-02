namespace GraphicsExample
{
    public partial class GraphicExample : Form
    {
        public GraphicExample()
        {
            InitializeComponent();
        }

        // Custom methods-------------------------------------------------------------------------

        void DrawLine()
        {
            //create a graphics object named g that draws on the picture box
            Graphics g = DisplayPictureBox.CreateGraphics();
            //create a pen to draw with
            Pen thePen = new Pen(Color.Black);
            thePen.Width = 10;
            //draw the line here
            g.DrawLine(thePen, 0, 0, DisplayPictureBox.Width, DisplayPictureBox.Height);

            //free up resorces
            g.Dispose();
            thePen.Dispose();
        }

        // Event handlers-------------------------------------------------------------------------

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            DrawLine();
        }
    }
}
