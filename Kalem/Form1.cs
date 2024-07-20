using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalem
{
    public partial class Form1 : Form
    {
         Graphics g;
         Point p1,p2;
        Pen kalem = new Pen(Color.Red, 5);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //p1 = new Point(e.X, e.Y);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            p2 = new Point(e.X, e.Y);
            g.DrawLine(kalem, p1, p2);
            p1 = p2;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            //p2 = new Point(e.X, e.Y);
            //g.DrawLine(kalem, p1, p2);
        }
    }
}
