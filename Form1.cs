﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulator_lab1_wizualne
{
    public partial class Form1 : Form
    {
        double firstNumber, secondNumber; 
        string currentOperator;
        public Form1()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (currentOperator == "=")
            {
                textBox1.Clear();
                currentOperator = "x";
            }
            textBox1.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentOperator == "=")
            {
                textBox1.Clear();
                currentOperator = "x";
            }
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (currentOperator == "=")
            {
                textBox1.Clear();
                currentOperator = "x";
            }
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (currentOperator == "=")
            {
                textBox1.Clear();
                currentOperator = "x";
            }
            textBox1.Text += "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (currentOperator == "=")
            {
                textBox1.Clear();
                currentOperator = "x";
            }
            textBox1.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (currentOperator == "=")
            {
                textBox1.Clear();
                currentOperator = "x";
            }
            textBox1.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (currentOperator == "=")
            {
                textBox1.Clear();
                currentOperator = "x";
            }
            textBox1.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (currentOperator == "=")
            {
                textBox1.Clear();
                currentOperator = "x";
            }
            textBox1.Text += "7";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (currentOperator == "=")
            {
                textBox1.Clear();
                currentOperator = "x";
            }
            textBox1.Text += "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (currentOperator == "=")
            {
                textBox1.Clear();
                currentOperator = "x";
            }
            textBox1.Text += "9";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(textBox1.Text);
            textBox1.Clear();
            currentOperator = "-";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(textBox1.Text);
            textBox1.Clear();
            currentOperator = "+";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(textBox1.Text);
            textBox1.Clear();
            currentOperator = "/";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(textBox1.Text);
            textBox1.Clear();
            currentOperator = "*";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            secondNumber = double.Parse(textBox1.Text); 

            if (currentOperator == "+")
                textBox1.Text = (firstNumber + secondNumber).ToString();
            else if (currentOperator == "-")
                textBox1.Text = (firstNumber - secondNumber).ToString();
            else if (currentOperator == "*")
                textBox1.Text = (firstNumber * secondNumber).ToString();
            else if (currentOperator == "/")
            {
                if (secondNumber != 0)
                    textBox1.Text = (firstNumber / secondNumber).ToString();
                else
                    textBox1.Text = "Błąd"; 
            }

            currentOperator = "=";
        }
    }
}
