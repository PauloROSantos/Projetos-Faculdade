using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rebuild_2._0
{
    public partial class rebuildForm : Form
    {
        public rebuildForm()
        {
            InitializeComponent();
        }

        private void rebuildForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.LimparTela();
            }
        }

        private void rebuildForm_Load(object sender, EventArgs e)
        {
            paisComboBox.DataSource = Enum.GetNames(typeof(Paises));
            paisComboBox.SelectedIndex = -1;

            estadoComboBox.DataSource = Enum.GetNames(typeof(Estados));
            estadoComboBox.SelectedIndex = -1;

            cidadeComboBox.DataSource = Enum.GetNames(typeof(Cidades));
            cidadeComboBox.SelectedIndex = -1;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            contagemLabel.Text = "Restantes: " + (300 - obsTextBox.TextLength).ToString();
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            var pessoa = new Pessoa()
            {
                Nome = nomeTextBox.ValidaVazio(),
                Idade = idadeTextBox.ValidaInt(),
                Altura = alturaTextBox.ValidarDecimal(),
                Peso = pesoTextBox.ValidarDecimal(),
                Pais = paisComboBox.ValidarCombo(),
                Estado = estadoComboBox.ValidarCombo(),
                Cidade = cidadeComboBox.ValidarCombo(),
                Observação = obsTextBox.ValidaVazio()
            };

            pessoa.Gravar();
            this.LimparTela();
            nomeTextBox.Focus();
            resultadoLabel.Text = pessoa.ToString();
        }
    }
}
