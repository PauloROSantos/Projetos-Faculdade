using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalvarArquivo
{
    public partial class SalvarArquivoForm : Form
    {
        public SalvarArquivoForm()
        {
            InitializeComponent();
        }

        private void adicionarButton_Click(object sender, EventArgs e)
        {
            if (!produtosTextBox.Text.Trim().Equals(""))
            {
                produtosListBox.Items.Add(produtosTextBox.Text);
                produtosTextBox.Clear();
                produtosTextBox.Focus();
            }
               
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            if (!nomeTextBox.Text.Trim().Equals(""))
            {
                cliente.nome = nomeTextBox.Text;
                
            }
            else
            {
                MessageBox.Show("Nome obrigatorio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!emailTextBox.Text.Trim().Equals(""))
            {
                cliente.email = emailTextBox.Text;
            }
            else
            {
                MessageBox.Show("email obrigatorio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (produtosListBox.Items.Count > 0)
            {
                foreach (var item in produtosListBox.Items)
                {
                    cliente.produtos.Add(item.ToString());
                }
            }


            Dados.Gravar(cliente);
            nomeTextBox.Clear();
            emailTextBox.Clear();
            produtosListBox.Items.Clear();
            nomeTextBox.Focus();
            
        }
    }
}
