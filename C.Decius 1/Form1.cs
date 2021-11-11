using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C.Decius_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result;
            string str = textBox1.Text;
            if (int.TryParse(str, out result))
            {
                MessageBox.Show("This is a valid integer");

            }
            else
            {
                MessageBox.Show("This is NOT an integer, please try again");
            }
            try
            {
                result = int.Parse(str);
            }
            catch
            {
                MessageBox.Show("CATCH - not a valid integer");
            }
            if (result > 10 || result < 1)
            {
                MessageBox.Show("Please enter a number between 1-10");
            }
        }
    }
}
