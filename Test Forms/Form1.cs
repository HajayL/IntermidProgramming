using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Forms
{
    public partial class Form1 : Form
    {
        float[] mousePos = { 0, 0};
        int timesClicked = 0;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Hello World!");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Console.WriteLine("Goodbye World!");
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            Console.WriteLine("Hello!!!");
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            Console.WriteLine("Goodbye");
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            this.Text = String.Format("This form has been clicked [{0}] times", ++timesClicked);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            mousePos = new float[2] { e.X, e.Y };
            label1.Text = String.Format("Mouse Pos | ({0}, {1})", mousePos[0], mousePos[1]);
        }

        
    }
}
