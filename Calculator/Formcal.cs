﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Formcal : Form
    {
        int count;
        bool simvol = true;
        float numo;
        public Formcal()
        {
            InitializeComponent();
        }

       

        private void C_Click(object sender, EventArgs e)
        {
            display.Text = "";
            label1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public string Add(int a, string dis)//добавдение числа
        {
            if (dis.Length == 34)
            {
                MessageBox.Show("Максимальное число!");
                return dis;
            }
            else
            {
                return dis + a;
            }
            
        }


        private void back_Click_1(object sender, EventArgs e)
        {
            Calculate calculate = new Calculate();
           display.Text= calculate.backer(display.Text);
        }

        private void plusmins_Click_1(object sender, EventArgs e)//отрицательное или положительное число
        {

            if (simvol == true)
            {
                display.Text = "-" + display.Text;
                simvol = false;
            }
            else if (simvol == false)
            {
                display.Text = display.Text.Replace("-", " ");
                simvol = true;
            }
        }

       
        #region numberbutton
        private void button1_Click(object sender, EventArgs e)
        {
            display.Text = Add(1, display.Text);
        }

        private void two_Click_1(object sender, EventArgs e)
        {
            display.Text = Add(2, display.Text);
        }

        private void three_Click_1(object sender, EventArgs e)
        {
            display.Text = Add(3, display.Text);
        }

        private void four_Click_1(object sender, EventArgs e)
        {
            display.Text = Add(4, display.Text);
        }

        private void five_Click_1(object sender, EventArgs e)
        {
            display.Text = Add(5, display.Text);
        }

        private void six_Click_1(object sender, EventArgs e)
        {
            display.Text = Add(6, display.Text);
        }

        private void seven_Click_1(object sender, EventArgs e)
        {
            display.Text = Add(7, display.Text);
        }

        private void eight_Click_1(object sender, EventArgs e)
        {
            display.Text = Add(8, display.Text);
        }

        private void nine_Click_1(object sender, EventArgs e)
        {
            display.Text = Add(9, display.Text);
        }

        private void zero_Click_1(object sender, EventArgs e)
        {
            display.Text = Add(0, display.Text);
        }
        #endregion

        private void dot_Click_1(object sender, EventArgs e)// запятая
        {
            display.Text = display.Text + ",";
        }

        private void equals_Click_1(object sender, EventArgs e)//Кнопка вычисления
        {
            Calculate calculate = new Calculate();
            try
            {

               display.Text = calculate.DoCalculate(count, numo, float.Parse(display.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Введите число!!!");
            }
            if  (display.Text != "")
            {
                label1.Text = "";
            }
        }
        private void plus_Click_1(object sender, EventArgs e)
        {
            Simvols("+", out simvol);
            count = 1;
        }
        private void devide_Click_1(object sender, EventArgs e)
        {
            Simvols("/",out simvol);
            count = 4;
        }

        private void multiply_Click_1(object sender, EventArgs e)
        {
            Simvols("*", out simvol);
            count = 3;
        }

        private void minus_Click_1(object sender, EventArgs e)
        {
            Simvols("-",out simvol);
            count = 2;
        }
        public void Simvols(string sim, out bool simvol)// Выбор знака
        {
            Calculate calculate = new Calculate();
            try
            {
                numo = float.Parse(display.Text);
                
                label1.Text = numo.ToString() + sim;
                display.Clear();
            }
            catch (Exception)
            {
                numo = float.Parse(calculate.backer(numo.ToString())) ;
                label1.Text = numo.ToString() + sim;

            }
            finally
            {
                simvol = true;
            }
        }
       

    }
}
