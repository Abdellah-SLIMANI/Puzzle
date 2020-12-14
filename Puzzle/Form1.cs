using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Threading;

namespace Puzzle
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public void Shuffle()
        {
            //Variables
            int helper;
            int[] numbers = new int[9];
            bool flag = false;
            int i = 1;

            do
            {
                Random rnd = new Random();
                helper = ((rnd.Next(0, 8)) + 1);
                for (int j = 1; j <= i; j++)
                {
                    if (numbers[j] == helper)
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
                    numbers[i] = helper;
                    i += 1;
                }
            }
            while (i <= 8);
            groupBox1.Controls[0].Text = Convert.ToString(numbers[1]);
            groupBox1.Controls[1].Text = Convert.ToString(numbers[2]);
            groupBox1.Controls[2].Text = Convert.ToString(numbers[3]);
            groupBox1.Controls[3].Text = Convert.ToString(numbers[4]);
            groupBox1.Controls[4].Text = Convert.ToString(numbers[5]);
            groupBox1.Controls[5].Text = Convert.ToString(numbers[6]);
            groupBox1.Controls[6].Text = Convert.ToString(numbers[7]);
            groupBox1.Controls[7].Text = Convert.ToString(numbers[8]);
            groupBox1.Controls[8].Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Shuffle();
        }
    }
}