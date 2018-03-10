using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rebuild3
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

        private void obsTextBox_TextChanged(object sender, EventArgs e)
        {
            restantesLabel.Text = "Restantes : "+(200 - Convert.ToInt16(obsTextBox.TextLength)).ToString();
        }

        private void rebuildForm_Load(object sender, EventArgs e)
        {
            generoComboBox.DataSource = Enum.GetValues(typeof(Genero));
            generoComboBox.SelectedIndex = -1;

            editoraComboBox.DataSource = Enum.GetValues(typeof(Editora));
            editoraComboBox.SelectedIndex = -1;

            idiomaComboBox.DataSource = Enum.GetValues(typeof(Idioma));
            idiomaComboBox.SelectedIndex = -1;
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            var livro = new Livro
            {
                Nome = nomeTextBox.ValidarVazio(),
                Escritor = escritorTextBox.ValidarVazio(),
                NumeroDePaginas = npagTextBox.ValidarInt(),
                Edição = ediçaoTextBox.ValidarInt(),
                Genero = generoComboBox.ValidarCombo(),
                Editora = editoraComboBox.ValidarCombo(),
                Idioma = idiomaComboBox.ValidarCombo(),
                Observação = obsTextBox.Text,
                
            };

            livro.Gravar();
            this.LimparTela();
            resultanteLabel.Text = livro.ToString();
            MessageBox.Show("Livro cadastrado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
