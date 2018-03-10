using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo3
{
    public partial class cadastroForm : Form
    {
        public cadastroForm()
        {
            InitializeComponent();
        }

        private void confirmarButton_Click(object sender, EventArgs e)
        {
            string nome = nomeTextBox.Text;
            DateTime dataMatricula = dataMatriculaDateTimePicker1.Value;
            string cidade = cidadeComboBox.Text;
            bool periodoManha = periodoManhaButton.Checked;
            bool periodoTarde = periodoTardeButton.Checked;
            bool periodoNoite = periodoNoiteButton.Checked;

            MessageBox.Show("nome: " + nome);
            MessageBox.Show("data Matricula: " + dataMatricula);
            MessageBox.Show("Periodo manha: " + periodoManha);
            MessageBox.Show("Periodo tarde: " + periodoTarde);
            MessageBox.Show("Periodo noite: " + periodoNoite);



        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
