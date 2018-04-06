using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int a, b, c;
        public int generateResult;
        public int guessResult;

        private void buttonGuess_Click(object sender, EventArgs e)
        {
            if (generateResult != 0)
            {


                if (string.IsNullOrEmpty(textBoxGuess.Text))
                {
                    MessageBox.Show("Enter your guess value !"); 
                    return;
                }

                guessResult = Convert.ToInt32(textBoxGuess.Text);
                if (guessResult == generateResult)
                {
                    MessageBox.Show("Congratulations , Correct Answer !");
                }
                else if (guessResult < generateResult)
                {
                    MessageBox.Show("Your Guess More Smaller That Generate Number GO UP ");
                    return;
                }
                else if (guessResult>generateResult)
                {
                    MessageBox.Show("Your Guess More Bigger Than Generate Number GO DOWN ");
                }

            }
            else
            {
                MessageBox.Show("Please Click Button To Create Random Value !");
                return;
            }

        }


        private void buttonCreateRandomValue_Click(object sender, EventArgs e)
        {
            Random rndNumber = new Random();
            labelGenerateResult.Text = rndNumber.Next(1, 100).ToString();
            generateResult = Convert.ToInt32(labelGenerateResult.Text);
        }
    }
}
