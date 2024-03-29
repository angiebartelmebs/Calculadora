﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoraforum
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtREsultado.Text = txtREsultado.Text + "7";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtREsultado.Text = txtREsultado.Text + "1";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            txtREsultado.Text = txtREsultado.Text + "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtREsultado.Text = txtREsultado.Text + "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtREsultado.Text = txtREsultado.Text + "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtREsultado.Text = txtREsultado.Text + "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtREsultado.Text = txtREsultado.Text + "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtREsultado.Text = txtREsultado.Text + "6";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtREsultado.Text = txtREsultado.Text + "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtREsultado.Text = txtREsultado.Text + "9";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtREsultado.Text != "")
            {
                valor1 = decimal.Parse(txtREsultado.Text, CultureInfo.InvariantCulture);
                txtREsultado.Text = "";
                operacao = "SOMA";
                lblOperacao.Text = "+";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtREsultado.Text, CultureInfo.InvariantCulture);

            if(operacao == "SOMA") 
            {
                txtREsultado.Text = Convert.ToString(valor1 + valor2);
            } else if(operacao == "SUB")
            {
                txtREsultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "MULT")
            {
                txtREsultado.Text = Convert.ToString(valor1 * valor2);
            }
            else 
            {
                txtREsultado.Text = Convert.ToString(valor1 / valor2);
            }
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(txtREsultado.Text != "")
            {
                valor1 = decimal.Parse(txtREsultado.Text, CultureInfo.InvariantCulture);
                txtREsultado.Text = "";
                operacao = "SUB";
                lblOperacao.Text = "-";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if(txtREsultado.Text != "")
            {
                valor1 = decimal.Parse(txtREsultado.Text, CultureInfo.InvariantCulture);
                txtREsultado.Text = "";
                operacao = "MULTI";
                lblOperacao.Text = "*";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if(txtREsultado.Text != "")
            {
                valor1 = decimal.Parse(txtREsultado.Text, CultureInfo.InvariantCulture);
                txtREsultado.Text = "";
                operacao = "DIV";
                lblOperacao.Text = "/";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtREsultado.Text = "";
            lblOperacao.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtREsultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            lblOperacao.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtREsultado.Text = txtREsultado.Text + ".";
        }
    }
}
