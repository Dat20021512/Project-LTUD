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
    public partial class IDD_DLG_SETTING : Form
    {
        public IDD_DLG_SETTING()
        {
            InitializeComponent();
        }

        private int brightnessValue = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            brightnessValue -= 10;
            txtLight_Val.Text = brightnessValue.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            brightnessValue += 10;
            txtLight_Val.Text = brightnessValue.ToString();
        }

        private void FormBrightness_Load(object sender, EventArgs e)
        {
            txtLight_Val.Text = brightnessValue.ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            brightnessValue = String.IsNullOrEmpty(txtLight_Val.Text) ? 0 : Convert.ToInt32(txtLight_Val.Text);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public int getBrightness()
        {
            return brightnessValue;
        }
    }
}
