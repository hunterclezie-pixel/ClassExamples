using Microsoft.VisualBasic.ApplicationServices;
using static System.Net.Mime.MediaTypeNames;

namespace GraphicsExample
{
    public partial class GraphicExample : Form
    {
        public GraphicExample()
        {
            InitializeComponent();
            DisplayPictureBox.MouseMove += DisplayPictureBox_MouseStuff;
            //DisplayPictureBox.MouseDown += DisplayPictureBox_MouseDown;
            DisplayPictureBox.MouseDown += DisplayPictureBox_MouseStuff;
        }

        // Custom methods-------------------------------------------------------------------------
        int oldX, oldY;
        void DrawLineSegment(int newX, int newY)
        {
            //create a graphics object named g that draws on the picture box
            Graphics g = DisplayPictureBox.CreateGraphics();
            //create a pen to draw with
            Pen thePen = new Pen(this.penColor);
            thePen.Width = 1;
            //draw the line here
            g.DrawLine(thePen, oldX, oldY, newX, newY);

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

        private Color penColor = Color.Black;
        void UpdateForeColor()
        { 
            PenColorDialog.ShowDialog();
            this.penColor = PenColorDialog.Color;
        }

        void DrawSineWave()
        {
            //create a graphics object named g that draws on the picture box
            Graphics g = DisplayPictureBox.CreateGraphics();
            //create a pen to draw with
            Pen thePen = new Pen(Color.Lime);
            int lastX = 0, lastY = 0, currentY = 0;
            float scaleX = DisplayPictureBox.Width / 360f;
            float scaleY = (DisplayPictureBox.Height / 200f) * -1;

            g.TranslateTransform(0, DisplayPictureBox.Height / 2);

            g.ScaleTransform(scaleX, scaleY);

            for (int currentX = 0; currentX < 360; currentX++)
            {
                currentY = (int)(Math.Round(100 * Math.Sin((Math.PI / 180) * currentX)));
                g.DrawLine(thePen, lastX, lastY, currentX, currentY);
                lastX = currentX;
                lastY = currentY;
            }

            //free up resorces
            g.Dispose();
            thePen.Dispose();
        }

        void DrawGrid()
        {
            int xDiv = DisplayPictureBox.Width / 10;
            int yDiv = DisplayPictureBox.Height / 8;   
            
            this.oldX = 0;
            this.oldY = 0;
            for (int x = 0; x < DisplayPictureBox.Width; x += xDiv)
            {
                oldX = x;
                DrawLineSegment(x, DisplayPictureBox.Height);
            }

            this.oldX = 0;
            this.oldY = 0;
            for (int y = 0; y < DisplayPictureBox.Height; y += yDiv)
            {
                oldY += y;
                DrawLineSegment(DisplayPictureBox.Width, y);
            }
        }

        // Event handlers-------------------------------------------------------------------------

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            //DrawEllipse();
            //DrawRectangle();
            //DrawPie();
            //DrawImage();
            //DrawText();
            DrawSineWave();
            DrawGrid();
        }

        private void DisplayPictureBox_MouseStuff(object? sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    DrawLineSegment(e.X, e.Y);
                    break;
                case MouseButtons.Right:
                    //Save for context menu
                    break;
                case MouseButtons.Middle:
                    //Todo: open color picker dialogue
                    UpdateForeColor();
                    break;
                default:
                    //MessageBox.Show($"{e.Button}");
                    break;
            }
            //Update last position on every move
            this.oldX = e.X;
            this.oldY = e.Y;
            this.Text = $"{e.X},{e.Y}";
        }

        //private void DisplayPictureBox_MouseDown(object? sender, MouseEventArgs e)
        //{
            //this.Text += $"{e.Button}";

            //PenColorDialog.ShowDialog();

        //}

        private void ClearButton_Click(object sender, EventArgs e)
        {
            DisplayPictureBox.Refresh();
        }
    }
}