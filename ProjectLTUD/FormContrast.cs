using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectLTUD
{
    public partial class FormContrast : Form
    {
        public FormContrast()
        {
            InitializeComponent();
        }

        private double valueContrast = 0.0;

        private void FormContrast_Load(object sender, EventArgs e)
        {
            textBox1.Text = valueContrast.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            valueContrast += 0.1;
            textBox1.Text = valueContrast.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            valueContrast += 10.0;
            textBox1.Text = valueContrast.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            valueContrast -= 0.1;
            textBox1.Text = valueContrast.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            valueContrast -= 10.0;
            textBox1.Text = valueContrast.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            valueContrast = String.IsNullOrEmpty(textBox1.Text) ? 0 : Convert.ToDouble(textBox1.Text);
            this.Close();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public double getContrast()
        {
            return valueContrast;
        }
    }
}
