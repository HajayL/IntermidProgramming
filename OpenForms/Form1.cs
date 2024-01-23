using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;

namespace OpenForms
{
    public partial class Form1 : Form
    {
        Stopwatch time;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            time = new Stopwatch();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = $"{time.ElapsedMilliseconds} ms";
        }

        private void resume_Click(object sender, EventArgs e)
        {
            time.Start();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            time.Stop();
        }

        private void lap_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add($"{(double)time.ElapsedMilliseconds / 1000}");
        }

        private void reset_Click(object sender, EventArgs e)
        {
            time.Reset();
            listBox1.Items.Clear();
        }

        private void radioButton_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
                groupBox1.ForeColor = Color.Black;
                groupBox2.ForeColor = Color.Black;
                resume.BackColor = Color.White;
                stop.BackColor = Color.White;
                lap.BackColor = Color.White;
                reset.BackColor = Color.White;
            }
            else if (radioButton2.Checked)
            {
                this.BackColor = Color.Gray;
                this.ForeColor = Color.Black;
                groupBox1.ForeColor = Color.Black;
                groupBox2.ForeColor = Color.Black;
                resume.BackColor = Color.White;
                stop.BackColor = Color.White;
                lap.BackColor = Color.White;
                reset.BackColor = Color.White;
            }
            else if (radioButton3.Checked)
            {
                this.BackColor = Color.Black;
                this.ForeColor = Color.White;
                groupBox1.ForeColor = Color.White;
                groupBox2.ForeColor = Color.White;
                resume.BackColor = Color.Gray;
                stop.BackColor = Color.Gray;
                lap.BackColor = Color.Gray;
                reset.BackColor = Color.Gray;
            }
        }

        private void radio2Button_Click(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                listBox1.BackColor = Color.White;
                listBox1.ForeColor = Color.Black;
            }
            else if (radioButton5.Checked)
            {
                listBox1.BackColor = Color.Gray;
                listBox1.ForeColor = Color.Black;
            }
            else if (radioButton4.Checked)
            {
                listBox1.BackColor = Color.Black;
                listBox1.ForeColor = Color.White;
            }
        }
    }
}
