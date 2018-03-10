using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rebuild
{
    public partial class personagemForm : Form
    {
        public personagemForm()
        {
            InitializeComponent();
            
        }

        private void personagemForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.LimparTela();

            }
        }

        private void personagemForm_Load(object sender, EventArgs e)
        {
            raçaComboBox.DataSource = Enum.GetNames(typeof(Raças));
            raçaComboBox.SelectedIndex = -1;

            classeComboBox.DataSource = Enum.GetNames(typeof(Classes));
            classeComboBox.SelectedIndex = -1;

            profissaoComboBox.DataSource = Enum.GetNames(typeof(Profissões));
            profissaoComboBox.SelectedIndex = -1;
        }

        private void obsTextBox_TextChanged(object sender, EventArgs e)
        {
            contagemLabel.Text = "Restantes : " + (300 - obsTextBox.TextLength).ToString();
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            var personagem = new Personagem {
                            Nome = nomeTextBox.VerificaVazio(),
                            Inteligencia = intTextBox.VerificaNumerico(),
                            Str = strTextBox.VerificaNumerico(),
                            Dex = dexTextBox.VerificaNumerico(),
                            Vit = vitTextBox.VerificaNumerico(),
                            Raça = raçaComboBox.VerificaCombo(),
                            Classe = classeComboBox.VerificaCombo(),
                            Profissao = profissaoComboBox.VerificaCombo(),
                            Observação = obsTextBox.VerificaVazio()
                                            };
            personagem.Gravar();
            resultadoLabel.Text = personagem.ToString();
            resultadoLabel.Text += "\n Gravação efetuada com sucesso!";
            this.LimparTela();
        }
    }
}
