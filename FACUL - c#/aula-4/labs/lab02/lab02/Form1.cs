using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab02
{
    public partial class lab02Form : Form
    {
        public lab02Form()
        {
            InitializeComponent();
        }

        private void ufComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            calcularButton.PerformClick();
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            valorFreteLabel.Text = string.Empty;
            resultadoLabel.Text = string.Empty;

            if (clienteTextBox.Text.Trim().Equals(""))
            {
                MessageBox.Show("Nome é obrigatorio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                clienteTextBox.Focus();
                return;
            }
            else if (valorTextBox.Text.Trim().Equals(""))
            {
                MessageBox.Show("valor é obrigatorio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                valorTextBox.Focus();
                return;
            }
            else if (ufComboBox.Text.Trim().Equals(""))
            {
                MessageBox.Show("UF é obrigatorio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ufComboBox.Focus();
                return;
            }
            Calcular();
        }

        private void Calcular()
        {
            decimal valor = Convert.ToDecimal(valorTextBox.Text);

            decimal frete = 0;

            switch (ufComboBox.Text.ToUpper())
            {
                case "RJ":
                    frete = 0.6m; break;
                case "SP":
                    frete = 0.7m; break;
                case "AM":
                    frete = 0.4m; break;
                case "MO":
                    frete = 0.3m; break;
                case "PB":
                    frete = 0.1m; break;
                default:
                    frete = 0.5m; break;
            }

            valorTextBox.Text = valor.ToString("N2");
            valorFreteLabel.Text = frete.ToString("P1");
            resultadoLabel.Text = (valor *(1 + frete)).ToString("C2");

        }
    }
}
