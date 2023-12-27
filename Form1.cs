using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        int sayi1, sayi2;
        String islem = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void islemler(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            islem += btn.Text;
            sayi1 = Convert.ToInt32(textBox1.Text);
            textBox1.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            sayi1 = 0;
            sayi2 = 0;
            islem = string.Empty;
        }

        private void esittir(object sender, EventArgs e)
        {
            sayi2 = Convert.ToInt32(textBox1.Text);

            switch(islem)
            {
                case "+":
                    textBox1.Text = (sayi1+sayi2).ToString();
                    break;
                case "-":
                    textBox1.Text = (sayi1 - sayi2).ToString();
                    break;
                case "*":
                    textBox1.Text = (sayi1 * sayi2).ToString();
                    break;
                case "/":
                    textBox1.Text = (sayi1 / sayi2).ToString();
                    break;
                default:
                    break;
            }
        }

        private void rakamlar(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
        }
    }
}
