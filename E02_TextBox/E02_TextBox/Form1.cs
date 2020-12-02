using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E02_TextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
                  }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
              float num1, num2;

            num1 = float.Parse(tb_num3.Text);
            num2 = float.Parse(tb_num4.Text);

            if (num1>num2)
            {
                MessageBox.Show("El numero " + num1.ToString() + " es mayor que " + num2.ToString());
            }
            else if(num2 > num1)
            {
                MessageBox.Show("El numero " + num2.ToString() + " es mayor que " + num1.ToString());
            }
            else
            {
                MessageBox.Show("El numero " + num1.ToString() + " es igual que " + num2.ToString());

            }

        }
    }
}
