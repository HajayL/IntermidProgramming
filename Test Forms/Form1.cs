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
    }
}
