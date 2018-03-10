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

        private void lab01Form_Load(object sender, EventArgs e)
        {
            combustivelComboBox.DataSource = Enum.GetNames(typeof(Combustiveis));
            combustivelComboBox.SelectedIndex = -1;

            marcaComboBox.DataSource = Enum.GetNames(typeof(Marca));
            marcaComboBox.SelectedIndex = -1;

            cambioComboBox.DataSource = Enum.GetNames(typeof(Cambios));
            cambioComboBox.SelectedIndex = -1;
        }

        private void observaçãoRichTextBox_TextChanged(object sender, EventArgs e)
        {
            contagemLabel.Text = (250 - observaçãoRichTextBox.TextLength).ToString();
        }

        private void lab01Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.LimparTela();
            }
        }

        private void gravarButton_Click(object sender, EventArgs e)
        {
            Carro carro = new Carro();
            carro.Placa = placaTextBox.Text.ValidarPlaca();
            carro.Modelo = modeloTextBox.ValidarVazio();
            carro.Cor = corTextBox.ValidarVazio();
            carro.Ano = anoTextBox.ValidarInt16().ValidarAno();
            carro.Marca = marcaComboBox.ValidarCombo();
            carro.Cambio = cambioComboBox.ValidarCombo();
            carro.Combustivel = combustivelComboBox.ValidarCombo();
            carro.Observação = observaçãoRichTextBox.Text;

            Dados.Gravar(carro);

            MessageBox.Show("Veiculo Gravado com Sucesso!","Sucesso!",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
