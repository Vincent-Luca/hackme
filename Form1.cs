using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hackme
{
    public partial class Form1 : Form
    {
        string password;
        string guesspass;
        string alph = "abcdefghijklmnopqrstuvwxyz0123456789";
        public Form1()
        {
            InitializeComponent();
        }//jdsfn jf

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                //int count = 0;
                /*
                foreach (char item in textBox2.Text)
                {
                    count++;
                }
                if ()
                {

                }
                */
                password = textBox2.Text;
            }
            else
            {
                MessageBox.Show("You have to put something in");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (password == guesspass)
            {
                MessageBox.Show("You did it!");
            }
            else
            {
                MessageBox.Show("Somthing went wrong! password incorrect");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            guesspass = "";
            int i = 0;
            int count = 0;
            bool doingstuff = true;
            while (doingstuff)
            {
                foreach (char letter in alph)
                {
                    if (i != alph.Length)
                    {
                        guesspass = letter.ToString();
                        //int index = guesspass.LastIndexOf(letter);
                        textBox1.Text = guesspass;
                        guesspass.Substring(0, count);
                        if (guesspass == password)
                        {
                            doingstuff = false;
                            break;
                        }
                        i++;
                    }
                    else
                    {
                        i = 0;
                        count++;
                    }
                }
            }
        }
    }
}
