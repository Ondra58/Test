using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int operace = 0;
        int pomocna;
        private void button1_Click(object sender, EventArgs e)
        {
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            if (pomocna == 1)
            {
                textBox1.Clear();
                textBox2.Clear();
                label1.Text = "";
                label2.Text = "";
                pomocna = 0;
            }
            if (operace != 0)
            {
                textBox2.AppendText("1");
            }
            else
            {
                textBox1.AppendText("1");
            }
            label2.Visible = false;
            label1.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            if (pomocna == 1)
            {
                textBox1.Clear();
                textBox2.Clear();
                label1.Text = "";
                label2.Text = "";
                pomocna = 0;
            }
            if (operace != 0)
            {
                textBox2.AppendText("2");
            }
            else
            {
                textBox1.AppendText("2");
            }
            label2.Visible = false;
            label1.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            if (pomocna == 1)
            {
                textBox1.Clear();
                textBox2.Clear();
                label1.Text = "";
                label2.Text = "";
                pomocna = 0;
            }
            if (operace != 0)
            {
                textBox2.AppendText("3");
            }
            else
            {
                textBox1.AppendText("3");
            }
            label2.Visible = false;
            label1.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            if (pomocna == 1)
            {
                textBox1.Clear();
                textBox2.Clear();
                label1.Text = "";
                label2.Text = "";
                pomocna = 0;
            }
            if (operace != 0)
            {
                textBox2.AppendText("4");
            }
            else
            {
                textBox1.AppendText("4");
            }
            label2.Visible = false;
            label1.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            if (pomocna == 1)
            {
                textBox1.Clear();
                textBox2.Clear();
                label1.Text = "";
                label2.Text = "";
                pomocna = 0;
            }
            if (operace != 0)
            {
                textBox2.AppendText("5");
            }
            else
            {
                textBox1.AppendText("5");
            }
            label2.Visible = false;
            label1.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            if (pomocna == 1)
            {
                textBox1.Clear();
                textBox2.Clear();
                label1.Text = "";
                label2.Text = "";
                pomocna = 0;
            }
            if (operace != 0)
            {
                textBox2.AppendText("6");
            }
            else
            {
                textBox1.AppendText("6");
            }
            label2.Visible = false;
            label1.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            if (pomocna == 1)
            {
                textBox1.Clear();
                textBox2.Clear();
                label1.Text = "";
                label2.Text = "";
                pomocna = 0;
            }
            if (operace != 0)
            {
                textBox2.AppendText("7");
            }
            else
            {
                textBox1.AppendText("7");
            }
            label2.Visible = false;
            label1.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            if (pomocna == 1)
            {
                textBox1.Clear();
                textBox2.Clear();
                label1.Text = "";
                label2.Text = "";
                pomocna = 0;
            }
            if (operace != 0)
            {
                textBox2.AppendText("8");
            }
            else
            {
                textBox1.AppendText("8");
            }
            label2.Visible = false;
            label1.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            if (pomocna == 1)
            {
                textBox1.Clear();
                textBox2.Clear();
                label1.Text = "";
                label2.Text = "";
                pomocna = 0;
            }
            if (operace != 0)
            {
                textBox2.AppendText("9");
            }
            else
            {
                textBox1.AppendText("9");
            }
            label2.Visible = false;
            label1.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (operace == 4)
            {
                MessageBox.Show("Chyba!", "Chyba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
                button16.Enabled = true;
                if (pomocna == 1)
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    label1.Text = "";
                    label2.Text = "";
                    pomocna = 0;
                }
                if (operace != 0)
                {
                    textBox2.AppendText("0");
                }
                else
                {
                    textBox1.AppendText("0");
                }
                label2.Visible = false;
                label1.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            operace = 1;
            label1.Text = "+";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            operace = 2;
            label1.Text = "-";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            operace = 3;
            label1.Text = "*";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            operace = 4;
            label1.Text = "/";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            operace = 5;
            label1.Text = "%";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pomocna = 1;
            try
            {

                int cislo1 = int.Parse(textBox1.Text);
                int cislo2 = int.Parse(textBox2.Text);
                int vysledek = 0;
                double vysledek2 = 0;
                if (operace == 1)
                {
                    vysledek = cislo1 + cislo2;
                }
                if (operace == 2)
                {
                    vysledek = cislo1 - cislo2;
                }
                if (operace == 3)
                {
                    vysledek = cislo1 * cislo2;
                }
                if (operace == 4)
                {
                    vysledek2 = (double)cislo1 / (double)cislo2;
                    label2.Text = "" + vysledek2;
                }
                if (operace == 5)
                {
                    vysledek = cislo1 % cislo2;
                }
                if (operace != 4)
                {
                    label2.Text = "" + vysledek;
                }
                label2.Visible = true;
                label1.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
            }
            catch
            {
                MessageBox.Show("Chyba!", "Chyba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            operace = 0;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label1.Text = "";
            label2.Text = "";
            operace = 0;
        }
    }
}