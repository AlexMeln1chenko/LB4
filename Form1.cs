using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x0 = double.Parse(textBoxX0.Text);
            double xk = double.Parse(textBoxXk.Text);
            double dx = double.Parse(textBoxdX.Text);
            double b = double.Parse(textBoxb.Text);
            for(double i = x0 ; i <= xk ; i += dx)
            {
                double y = 0.0025 * b * Math.Pow(i, 3) + Math.Sqrt(i + Math.Pow(Math.E, 0.82));
                textBox5.Text += " x=" + Convert.ToString(i) + "\ty=" + Convert.ToString(y)+ Environment.NewLine;
            }
            textBox5.Text += Environment.NewLine;
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxX0.Text) || String.IsNullOrEmpty(textBoxXk.Text) || String.IsNullOrEmpty(textBoxdX.Text) || String.IsNullOrEmpty(textBoxb.Text))
                button1.Enabled = false;
            else button1.Enabled = true;
        }
    }
}
