using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class lab01Form : Form
    {
        public lab01Form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            if (numeroTextBox.Text.Equals(""))
            {
                MessageBox.Show("digite um numero:");
            }else
            {
                resultadoLabel.Text = string.Format("O quadrado de {0} é {1}",
                                                numeroTextBox.Text,
                                                Convert.ToString(Convert.ToInt32(numeroTextBox.Text) * Convert.ToInt32(numeroTextBox.Text)));

            }
           
        }

        private void numeroTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
