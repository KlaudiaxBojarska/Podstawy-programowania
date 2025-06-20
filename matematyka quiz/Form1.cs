using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matematyka_quiz
{
    public partial class Form1 : Form
    {
        Random randomizer = new Random();
        int addend1;
        int addend2;
        int minuend;
        int subtrahend;
        int multiplicand;
        int multiplier;
        int dividend;
        int divisor;

        public void StartTheQuiz()
        {
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();
            SUM.Value = 0;
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            label7.Text = minuend.ToString();
            label4.Text = subtrahend.ToString();
            odejmowanie.Value = 0;
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            label11.Text = multiplicand.ToString();
            label8.Text = multiplier.ToString();
            mnożenie.Value = 0;
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            label15.Text = dividend.ToString();
            label12.Text = divisor.ToString();
            dzielenie.Value = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            Start.Enabled = false;
        }
    }
}