using Microsoft.VisualBasic.ApplicationServices;
using static System.Net.Mime.MediaTypeNames;

namespace GraphicsExample
{
    public partial class GraphicExample : Form
    {
        public GraphicExample()
        {
            InitializeComponent();
            DisplayPictureBox.MouseMove += DisplayPictureBox_MouseMove;
        }

        // Custom methods-------------------------------------------------------------------------
        int oldX, oldY;
        void DrawLineSegment(int newX, int newY)
        {
            //create a graphics object named g that draws on the picture box
            Graphics g = DisplayPictureBox.CreateGraphics();
            //create a pen to draw with
            Pen thePen = new Pen(Color.Black);
            thePen.Width = 10;
            //draw the line here
            g.DrawLine(thePen, oldX, oldY, newX, newY);
            oldX = newX;
            oldY = newY;

            //free up resorces
            g.Dispose();
            thePen.Dispose();
        }

        void DrawEllipse()
        {
            //create a graphics object named g that draws on the picture box
            Graphics g = DisplayPictureBox.CreateGraphics();
            //create a pen to draw with
            Pen thePen = new Pen(Color.Black);
            thePen.Width = 5;
            //draw the line here
            g.DrawEllipse(thePen, 0, 0, 100, 100);

            //free up resorces
            g.Dispose();
            thePen.Dispose();
        }

        //rectangle
        void DrawRectangle()
        {
            //create a graphics object named g that draws on the picture box
            Graphics g = DisplayPictureBox.CreateGraphics();
            //create a pen to draw with
            Pen thePen = new Pen(Color.LightGoldenrodYellow);
            thePen.Width = 5;
            //draw the line here
            g.DrawRectangle(thePen, 100, 100, 200, 200);

            //free up resorces
            g.Dispose();
            thePen.Dispose();
        }

        void DrawPie()
        {
            //create a graphics object named g that draws on the picture box
            Graphics g = DisplayPictureBox.CreateGraphics();
            //create a pen to draw with
            Pen thePen = new Pen(Color.HotPink);
            thePen.Width = 5;
            SolidBrush theBrush = new SolidBrush(Color.DarkSeaGreen);
            Rectangle bounds = new Rectangle(100, 100, 200, 200);
            //draw the line here

            //g.DrawPie(thePen, bounds, 0, 45);
            g.FillPie(theBrush, bounds, 0, 45);
            theBrush = new SolidBrush(Color.DarkKhaki);
            g.FillPie(theBrush, bounds, 45, 135);
            theBrush = new SolidBrush(Color.IndianRed);
            g.FillPie(theBrush, bounds, 180, 180);

            //free up resorces
            g.Dispose();
            thePen.Dispose();
            theBrush.Dispose();
        }

        //text
        void DrawText()
        {
            //create a graphics object named g that draws on the picture box
            Graphics g = DisplayPictureBox.CreateGraphics();
            //create a pen to draw with
            Pen thePen = new Pen(Color.Black);
            thePen.Width = 5;
            System.Drawing.Font theFont = new System.Drawing.Font("Arial", 24);
            SolidBrush theBrush = new SolidBrush(Color.RebeccaPurple);
            Rectangle bounds = new Rectangle(100, 100, 200, 200);

            g.DrawString("Are you sure?", theFont, theBrush, 0, DisplayPictureBox.Height / 2);

            //free up resorces
            g.Dispose();
            thePen.Dispose();
            theBrush.Dispose();
        }

        //image
        void DrawImage()
        {
            //create a graphics object named g that draws on the picture box
            Graphics g = DisplayPictureBox.CreateGraphics();
            //create an image object to load the image file
            System.Drawing.Image theImage = System.Drawing.Image.FromFile("..\\..\\..\\Omni-Man.png");
            Rectangle bounds = new Rectangle(200, 50, theImage.Width, theImage.Height);
            g.DrawImage(theImage, bounds);

            //free up resorces
            g.Dispose();
            theImage.Dispose();
        }

        // Event handlers-------------------------------------------------------------------------

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            DrawEllipse();
            DrawRectangle();
            DrawPie();
            DrawImage();
            DrawText();
        }

        private void DisplayPictureBox_MouseMove(object? sender, MouseEventArgs e)
        {
            this.Text = $"{e.X},{e.Y}";
            DrawLineSegment(e.X,e.Y);
        }
    }
}
