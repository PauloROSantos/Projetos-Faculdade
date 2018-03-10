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

namespace lab01
{
    public partial class lab01Form : Form
    {
        public lab01Form()
        {
            InitializeComponent();
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            if (kmTextBox.Text.Trim().Equals(""))
            {
                MessageBox.Show("Kilometragem necessaria!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                kmTextBox.Focus();
                return;
            }
            else if (litrosTextBox.Text.Trim().Equals(""))
            {
                MessageBox.Show("Quantidade de litros necessaria!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                litrosTextBox.Focus();
                return;
            }

            try
            {
                var testeKm = Convert.ToDecimal(kmTextBox.Text);
            }
            catch
            {
                kmTextBox.Focus();
                kmTextBox.SelectAll();

                throw new Exception("Os kms devem ser numeros!");

            }
            try
            {
                var testeLitros = Convert.ToDecimal(litrosTextBox.Text);
            }
            catch
            {
                litrosTextBox.Focus();
                litrosTextBox.SelectAll();

                

                MessageBox.Show("Os litros devem ser numeros!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            resultadoRendimentoLabel.Text = (Convert.ToDecimal(kmTextBox.Text) / Convert.ToDecimal(litrosTextBox.Text)).ToString("N1");
            resultadoConsumoLabel.Text = (Convert.ToDecimal(litrosTextBox.Text) / Convert.ToDecimal(kmTextBox.Text)).ToString("N3");

        }
    }
}
