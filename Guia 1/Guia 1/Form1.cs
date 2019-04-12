using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total = 0;
            if (radioButton1.Checked == true)
            {
                total = total + 50;
            }
            if (radioButton2.Checked == true)
            {
                total = total + 100;
            }
            if (radioButton3.Checked == true)
            {
                total = total + 150;
            }
            if (this.checkBox1.Checked == true)
            {
                total = total + 5;
            } if (this.checkBox2.Checked == true)
            {
                total = total + 15;
            }
            if (this.checkBox3.Checked == true)
            {
                total = total + 20;

            }
            MessageBox.Show("El total de gastos de envio es: " + total.ToString("c2"));
        }
    }
}
