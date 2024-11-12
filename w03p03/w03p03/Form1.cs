using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w03p03
{
    public partial class Form1 : Form
    {

        int ile = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left )
            {
                timer1.Start();
            }
            else if(e.Button == MouseButtons.Right )
            { 
                timer2.Start();
            }
       
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ile++;
            label1.Text = ile.ToString();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            ile--;
            label1.Text = ile.ToString();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up) {
                timer1.Start();
            } else if(e.KeyCode == Keys.Down)
            {
                timer2.Start();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
        }
    }
}
