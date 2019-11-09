using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphical_Designs
{
    public partial class Form1 : Form
    {

        Pen myPen = new Pen(Color.Black);
        Graphics g = null;

        static int center_x, center_y;

        static int start_x, start_y;
        static int end_x, end_y;
        static int my_angle=0;
        static int my_length = 0;
        static int my_increment = 0;
        static int num_lines = 0;



        public Form1()
        {
            InitializeComponent();
            start_x = canvas.Width / 2;
            start_y = canvas.Height / 2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            my_length = Int32.Parse(length1.Text);
            my_angle = Int32.Parse(angle1.Text);
            my_increment = Int32.Parse(increment1.Text);

            start_x = canvas.Width / 2;
            start_y = canvas.Height / 2;
            canvas.Refresh();
        }

        private void increment_Click(object sender, EventArgs e)
        {

        }

        private void drawLines()
        {
            new Point(start_x, start_y);
            new Point(start_x +100, start_y +100);

        }


        private void canvas_Paint(object sender, PaintEventArgs e)
        {

            drawLines();


        }
    }
}
