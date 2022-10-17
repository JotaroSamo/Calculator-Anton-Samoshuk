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
    public partial class Formcal : Form
    {
        int count;
        bool simvol = true;
        float numo, numt;
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

        public string Add(int a, string dis)
        {
            return dis + a;
        }

        public string Counting(int count, float numo, float numt, float displayf)
        {

            switch (count)
            {

                case 1:
                    numt = numo + displayf;
                    return numt.ToString();

                case 2:
                    numt = numo - displayf;
                    return numt.ToString();

                case 3:
                    numt = numo * displayf;
                    return numt.ToString();

                case 4:
                    if (float.Parse(display.Text) == 0)
                    {
                        MessageBox.Show("Нельзя делить на ноль!");
                        return "0";
                    }
                    else
                    {
                        numt = numo / displayf;
                        return numt.ToString();
                    }

                default:
                    return "0";


            }



        }

        private void back_Click_1(object sender, EventArgs e)
        {
            backer();
        }

        private void plusmins_Click_1(object sender, EventArgs e)
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

        private void plus_Click_1(object sender, EventArgs e)
        {
            try
            {
                numo = float.Parse(display.Text);
                display.Clear();
                label1.Text = numo.ToString() + "+";

            }
            catch (Exception)
            {
                backer();
                label1.Text = numo.ToString() + "+";


            }
            finally
            {
                count = 1;
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

        private void dot_Click_1(object sender, EventArgs e)
        {
            display.Text = display.Text + ",";
        }

        private void equals_Click_1(object sender, EventArgs e)
        {
            try
            {
                display.Text = Counting(count, numo, numt, float.Parse(display.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Введите число!!!");
            }
            if (display.Text != "")
            {
                label1.Text = "";
            }
        }

        private void devide_Click_1(object sender, EventArgs e)
        {
            try
            {
                numo = float.Parse(display.Text);
                display.Clear();
                label1.Text = numo.ToString() + "/";

            }
            catch (Exception)
            {
                backer();
                label1.Text = numo.ToString() + "/";


            }
            finally
            {
                count = 4;
                simvol = true;
            }
        }

        private void multiply_Click_1(object sender, EventArgs e)
        {

            try
            {
                numo = float.Parse(display.Text);
                display.Clear();
                label1.Text = numo.ToString() + "*";

            }
            catch (Exception)
            {
                backer();
                label1.Text = numo.ToString() + "*";

            }
            finally
            {
                count = 3;
                simvol = true;
            }
        }

        private void minus_Click_1(object sender, EventArgs e)
        {
            try
            {
                numo = float.Parse(display.Text);
                display.Clear();
                label1.Text = numo.ToString() + "-";
            }
            catch (Exception)
            {
                backer();
                label1.Text = numo.ToString() + "-";

            }
            finally
            {
                count = 2;
                simvol = true;
            }
        }

        private void backer()
        {
            int leng = display.Text.Length - 1;
            string tx = display.Text;
            display.Clear();
            for (int i = 0; i < leng; i++)
            {
                display.Text = display.Text + tx[i];
            }
        }

    }
}
