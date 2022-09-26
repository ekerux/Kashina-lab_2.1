using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alg_laba2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
        int x, r1,r2, y,result;

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(numericUpDown1.Value);
            y = Convert.ToInt32(numericUpDown2.Value);
            r1 = Convert.ToInt32(numericUpDown3.Value);
            r2 = Convert.ToInt32(numericUpDown4.Value);
            if (numericUpDown4.Value> numericUpDown3.Value)
            {
                textBox1.Text = "error";   
                
                return; }
            if (numericUpDown4.Value < numericUpDown3.Value)
            {
                result = ((int)(Math.Sqrt(Math.Pow((double)numericUpDown1.Value, 2)) + Math.Pow((double)numericUpDown2.Value, 2)));
            }
            if (result >= r1)
            {
                textBox1.Text = "принадлежит";        
            }
            else
            {
                textBox1.Text = "не принадлежит";
            }
        }
    }
}
