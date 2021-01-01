using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number_System_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            
            int binaryNumber = int.Parse(txt2.Text);
            int decimalValue = Convert.ToInt32(binaryNumber.ToString(), 2);
            txt10.Text = Convert.ToString(decimalValue);
            int number = int.Parse(txt10.Text);
            string Base = Convert.ToString(number, 2);
            txt2.Text = Base;
            string Base1 = Convert.ToString(number, 8);
            txt8.Text = Base1;
            string Base2 = Convert.ToString(number, 16);
            txt16.Text = Base2.ToUpper();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            int octnum = 0, r = 0;
            int i = 0;
            double decnum = 0;
            octnum = int.Parse(txt8.Text);
            while (octnum != 0)
            {
                r = octnum % 10;
                decnum = decnum + (r * Math.Pow(8, i++));
                octnum = octnum / 10;
            }
            txt10.Text = decnum.ToString();
            int number = int.Parse(txt10.Text);
            string Base = Convert.ToString(number, 2);
            txt2.Text = Base;
            string Base2 = Convert.ToString(number, 16);
            txt16.Text = Base2.ToUpper();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txt10.Text);
            string Base = Convert.ToString(number, 2);
            txt2.Text = Base;
            string Base1 = Convert.ToString(number, 8);
            txt8.Text = Base1;
            string Base2 = Convert.ToString(number, 16);
            txt16.Text = Base2.ToUpper();            
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            string hex_value = txt16.Text;
            int int_value = Convert.ToInt32(hex_value, 16);
            txt10.Text = Convert.ToString(int_value);
            int number = int.Parse(txt10.Text);
            string Base = Convert.ToString(number, 2);
            txt2.Text = Base;
            string Base2 = Convert.ToString(number, 8);
            txt8.Text = Base2;            
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            txt2.Clear();
            txt8.Clear();
            txt10.Clear();
            txt16.Clear();
            txt2.Focus();
        }
    }
}
