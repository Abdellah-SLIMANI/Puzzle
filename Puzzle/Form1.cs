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

namespace Puzzle
{
    public partial class Form1 : Form
    {
        System.Timers.Timer myTimer;
        int minutes, seconds;
        Button[] ArrayOfBtns = new Button[9];
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /*
        public void Timer()
        {
            // TImer fucntion onClick on start (FullFill btn)
            myTimer = new System.Timers.Timer();
            myTimer.Interval = 1000; //which is 1 second
            myTimer.Elapsed += CountDown();
        }

        private  ElapsedEventHandler CountDown()
        {
            Invoke(new Action(() =>
            {
                seconds += 1;
                if(seconds == 59)
                {
                    seconds = 0;
                    minutes += 1;
                }
                label2.Text = string.Format("{0}:{1}", minutes.ToString(), seconds.ToString());
            }));
        }
        */
        private void isOver()
        {
            if (
                button1.Text == "1" 
                && button2.Text == "2" 
                && button3.Text == "3" 
                && button4.Text == "4" 
                && button5.Text == "5" 
                && button6.Text == "6" 
                && button7.Text == "7" 
                && button8.Text == "8" 
                && button9.Text == "")
            {
                MessageBox.Show("YOU WON!");
            }
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
            button1.Text = Convert.ToString(numbers[1]);
            button2.Text = Convert.ToString(numbers[2]);
            button3.Text = Convert.ToString(numbers[3]);
            button4.Text = Convert.ToString(numbers[4]);
            button5.Text = Convert.ToString(numbers[5]);
            button6.Text = Convert.ToString(numbers[6]);
            button7.Text = Convert.ToString(numbers[7]);
            button8.Text = Convert.ToString(numbers[8]);
            button9.Text = "";
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            Shuffle();
            //Timer();
            isOver();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (button2.Text == "")
            {
                button2.Text = button1.Text;
                button1.Text = "";
            }
            if (button4.Text == "")
            {
                button4.Text = button1.Text;
                button1.Text = "";
            }
            isOver();
        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            if (button1.Text == "")
            {
                button1.Text = button2.Text;
                button2.Text = "";
            }
            if (button3.Text == "")
            {
                button3.Text = button2.Text;
                button2.Text = "";
            }
            if (button5.Text == "")
            {
                button5.Text = button2.Text;
                button2.Text = "";
            }
            isOver();
        }

        private void button3_KeyDown(object sender, KeyEventArgs e)
        {
            if (button2.Text == "")
            {
                button2.Text = button3.Text;
                button3.Text = "";
            }
            if (button6.Text == "")
            {
                button6.Text = button3.Text;
                button3.Text = "";
            }
            isOver();
        }

        private void button4_KeyDown(object sender, KeyEventArgs e)
        {
            if (button1.Text == "")
            {
                button1.Text = button4.Text;
                button4.Text = "";
            }
            if (button5.Text == "")
            {
                button5.Text = button4.Text;
                button4.Text = "";
            }
            if (button7.Text == "")
            {
                button7.Text = button4.Text;
                button4.Text = "";
            }
            isOver();
        }

        private void button5_KeyDown(object sender, KeyEventArgs e)
        {
            if (button2.Text == "")
            {
                button2.Text = button5.Text;
                button5.Text = "";
            }
            if (button4.Text == "")
            {
                button4.Text = button5.Text;
                button5.Text = "";
            }
            if (button6.Text == "")
            {
                button6.Text = button5.Text;
                button5.Text = "";
            }
            if (button8.Text == "")
            {
                button8.Text = button5.Text;
                button5.Text = "";
            }
            isOver();
        }

        private void button6_KeyDown(object sender, KeyEventArgs e)
        {
            if (button3.Text == "")
            {
                button3.Text = button6.Text;
                button6.Text = "";
            }
            if (button5.Text == "")
            {
                button5.Text = button6.Text;
                button6.Text = "";
            }
            if (button9.Text == "")
            {
                button9.Text = button6.Text;
                button6.Text = "";
            }
            isOver();
        }

        private void button7_KeyDown(object sender, KeyEventArgs e)
        {
            if (button4.Text == "")
            {
                button4.Text = button7.Text;
                button7.Text = "";
            }
            if (button8.Text == "")
            {
                button8.Text = button7.Text;
                button7.Text = "";
            }
            isOver();
        }

        private void button8_KeyDown(object sender, KeyEventArgs e)
        {
            if (button5.Text == "")
            {
                button5.Text = button8.Text;
                button8.Text = "";
            }
            if (button7.Text == "")
            {
                button7.Text = button8.Text;
                button8.Text = "";
            }
            if (button9.Text == "")
            {
                button9.Text = button8.Text;
                button8.Text = "";
            }
            isOver();
        }

        private void button9_KeyDown(object sender, KeyEventArgs e)
        {
            if (button6.Text == "")
            {
                button6.Text = button9.Text;
                button9.Text = "";
            }
            if (button8.Text == "")
            {
                button8.Text = button9.Text;
                button9.Text = "";
            }
            isOver();
        }
    }
}