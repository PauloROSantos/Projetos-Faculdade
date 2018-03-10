using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab01
{
    public partial class lab01Form : Form
    {
        public lab01Form()
        {
            InitializeComponent();
        }

        private void resultadoLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            decimal valor1 = valor1NumericUpDown.Value;

            decimal valor2 = valor2NumericUpDown.Value;

            decimal valor3 = valor3NumericUpDown.Value;

            if (( valor1 > valor2 ) && ( valor1 > valor3))
            {
                resultadoLabel.Text = valor1.ToString() + " é o maior valor";
            }
            else if(valor2 > valor3)
            {
                resultadoLabel.Text = valor2.ToString() + " é o maior valor";
            }
            else
            {
                resultadoLabel.Text = valor3.ToString() + " é o maior valor";
            }

        }
    }
}
