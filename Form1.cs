using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

// Välkomnande meddelande
// En lista för att spara historik för räkningar
// Användaren matar in tal och matematiska operation
// OBS! Användaren måsta mata in ett tal för att kunna ta sig vidare i programmet!
// Ifall användaren skulle dela med 0 visa Ogiltig inmatning!
// Lägga resultat till listan
// Visa resultat
// Fråga användaren om den vill visa tidigare resultat.
// Visa tidigare resultat
// Fråga användaren om den vill avsluta eller fortsätta.

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
            //Välkomnar till kalkylatorn
        {
            InitializeComponent();
            textBox2.Text = "Välkommen till kalkylatorn";
        }
        //Creates a variabel to the first number, the answer and to count the answer.
        float num1, ans;
        int count;
        //Creates a list to get the history.
        List<string> lista = new List<string>();
        bool visarResultat = false;
        
        //Every button for numbers have a if statement to clear the window if it contains the answer or "Ogiltlig inmatning". This is to be able to start a new
        //calculation even if the window is not cleared manually.
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == ans.ToString() || textBox1.Text == "Ogiltlig inmatning")
            {
                reset();
                textBox1.Text = textBox1.Text + 1;
            }
            else
            {
                textBox1.Text = textBox1.Text + 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == ans.ToString() || textBox1.Text == "Ogiltlig inmatning")
            {
                reset();
                textBox1.Text = textBox1.Text + 2;
            }
            else
            {
                textBox1.Text = textBox1.Text + 2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == ans.ToString() || textBox1.Text == "Ogiltlig inmatning")
            {
                reset();
                textBox1.Text = textBox1.Text + 3;
            }
            else
            {
                textBox1.Text = textBox1.Text + 3;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == ans.ToString() || textBox1.Text == "Ogiltlig inmatning")
            {
                reset();
                textBox1.Text = textBox1.Text + 4;
            }
            else
            {
                textBox1.Text = textBox1.Text + 4;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == ans.ToString() || textBox1.Text == "Ogiltlig inmatning")
            {
                reset();
                textBox1.Text = textBox1.Text + 5;
            }
            else
            {
                textBox1.Text = textBox1.Text + 5;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == ans.ToString())
            {
                reset();
                textBox1.Text = textBox1.Text + 6;
            }
            else
            {
                textBox1.Text = textBox1.Text + 6;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == ans.ToString() || textBox1.Text == "Ogiltlig inmatning")
            {
                reset();
                textBox1.Text = textBox1.Text + 7;
            }
            else
            {
                textBox1.Text = textBox1.Text + 7;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == ans.ToString() || textBox1.Text == "Ogiltlig inmatning")
            {
                reset();
                textBox1.Text = textBox1.Text + 8;
            }
            else
            {
                textBox1.Text = textBox1.Text + 8;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == ans.ToString() || textBox1.Text == "Ogiltlig inmatning")
            {
                reset();
                textBox1.Text = textBox1.Text + 9;
            }
            else
            {
                textBox1.Text = textBox1.Text + 9;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == ans.ToString() || textBox1.Text == "Ogiltlig inmatning")
            {
                reset();
                textBox1.Text = textBox1.Text + 0;
            }
            else
            {
                textBox1.Text = textBox1.Text + 0;
            }
        }

        //Erase button to clear the window.
        private void erasebtn_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        //The if statement on the mathematic operators is used to add the operator if the window is not empty. If the window is empty u cant add the because it will give you error.
        private void plusbtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") 
            { 
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = '+';
            }
        }

        private void minusbtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = float.Parse(textBox1.Text);
                textBox1.Clear();
                count = '-';
            }
           
        }

        private void equalbtn_Click(object sender, EventArgs e)
        {
            compute(count);
            
        }

        private void dividebtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = float.Parse(textBox1.Text);
                textBox1.Clear();
                count = '/';
            }
        }
        private void timesbtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = float.Parse(textBox1.Text);
                textBox1.Clear();
                count = '*';
            }
        }

        //The if statement on the decimal button is used because if the window is empty and you use the decimal it will give you "0," but if the window already have numbers
        //it will only add the ","  
        private void btndecimal_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = 0 + ",";
            }
            else if (!textBox1.Text.Contains(","))
            {
                textBox1.Text += ",";
            }
        
        }
        //The if statement on the history button clears window 2 and reverse the list to get the most recent calculation on top.
        //It adds the calculation to the list and creates a new line to get one calculation on new lines.
        //If you press the button it will show you the history but if you press it again it will show you the welcome message.
        private void history_Click(object sender, EventArgs e)
        {
            if (!visarResultat)
            {
                textBox2.Clear();
                lista.Reverse();
                for (int i = 0; i < lista.Count; i++)
                {
                    textBox2.Text += lista[i].ToString() + Environment.NewLine;
                }
                lista.Reverse();
                visarResultat = true;
            }
            else
            {
                textBox2.Text = "Välkommen till kalkylatorn";
                visarResultat = false;
            }
        }

        //This is the switch case that calculates every mathematical operator. It gives you the answer of the two numbers you enter and then clears the box before you get the answer.
        public void compute(int count) 
        {
        switch (count)
            {
                case '-':
                    ans = num1 - float.Parse(textBox1.Text);
                    lista.Add(num1 + "-" + float.Parse(textBox1.Text) + "=" + ans);
                    textBox1.Clear();
                    textBox1.Text = ans.ToString();
                    break;
                case '+':
                    ans = num1 + float.Parse(textBox1.Text);
                    lista.Add(num1 + "+" + float.Parse(textBox1.Text) + "=" + ans);
                    textBox1.Clear();
                    textBox1.Text = ans.ToString();
                    break;
                case '*':
                    ans = num1 * float.Parse(textBox1.Text);
                    lista.Add(num1 + "*" + float.Parse(textBox1.Text) + "=" + ans);
                    textBox1.Clear();
                    textBox1.Text = ans.ToString();
                    break;
                case '/':
                    ans = num1 / float.Parse(textBox1.Text);
                    if (ans.ToString() == "\u221E")
                       textBox1.Text = textBox1.Text + "Ogiltlig inmatning";
                    else
                    {
                        lista.Add(num1 + "/" + float.Parse(textBox1.Text) + "=" + ans);
                    }
                    textBox1.Clear();
                    textBox1.Text = ans.ToString();

                    break;
                default:
                    break;
            }
        }
        //This is the reset i use to reset before adding numbers. 
        private void reset()
        {
            num1 = 0;
            count = 0;
            textBox1.Clear();
        }
    }
}
