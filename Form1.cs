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
        {
            InitializeComponent();
            textBox2.Text = "Välkommen till kalkylatorn";
        }

        float num1, ans;
        int count;
        List<string> lista = new List<string>();
        bool visarResultat = false;
        

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

        private void erasebtn_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            count = 0;
        }

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
                    textBox1.Clear();
                    if (ans.ToString() == "\u221E")
                       textBox1.Text = textBox1.Text + "Ogiltlig inmatning";
                    else
                    {
                        lista.Add(num1 + "/" + float.Parse(textBox1.Text) + "=" + ans);
                        textBox1.Text = ans.ToString();
                    }
                    
                    
                    break;
                default:
                    break;
            }
        }
        private void reset()
        {
            num1 = 0;
            count = 0;
            textBox1.Clear();
        }
    }
}
