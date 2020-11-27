using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle
{
    public partial class Form1 : Form
    {

        System.Timers.Timer Timer;
        int minutes, seconds;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        public void Shuffle()
        {
            int i, j, Rn;
            int[] a = new int[9];
            Boolean flag = false;
            i = 1;
            do
            {
                Random rnd = new Random();
                Rn = ((rnd.Next(0, 8)) + 1);
                for (j = 1; j <= i; j++)
                {
                    if (a[j] == Rn)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == true)
                {
                    flag = false;
                }
                else
                {
                    a[i] = Rn;
                    i = i + 1;
                }
            }
            while (i <= 8);
            button1.Text = Convert.ToString(a[1]);
            button2.Text = Convert.ToString(a[2]);
            button3.Text = Convert.ToString(a[3]);
            button4.Text = Convert.ToString(a[4]);
            button5.Text = Convert.ToString(a[5]);
            button6.Text = Convert.ToString(a[6]);
            button7.Text = Convert.ToString(a[7]);
            button8.Text = Convert.ToString(a[8]);
            button9.Text = "";
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            Shuffle();
        }

        private void button9_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //Timer = new System.Timers.Timer();
            //Timer.Interval = 1000; // more like 1s
            //Timer.Elapsed += OnTimeEvent;
        }
    }
}
