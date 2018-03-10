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

namespace lab02
{
    public partial class lab02Form : Form
    {
        public lab02Form()
        {
            InitializeComponent();
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            endereçoBuscadoLabel.Text = string.Empty;

            try
            {
                if (folderBrowserDialog1.ShowDialog() != DialogResult.Cancel)
                {
                    endereçoBuscadoLabel.Text = folderBrowserDialog1.SelectedPath;
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void trocarButton_Click(object sender, EventArgs e)
        {
            try
            {
                FileInfo[] arquivos = new DirectoryInfo(endereçoBuscadoLabel.Text).GetFiles();

                if (!deTextBox.Text.Trim().Equals(""))
                {
                    foreach (var arquivo in arquivos)
                    {
                        string novoNome = endereçoBuscadoLabel.Text + "//" + arquivo.Name.Replace(deTextBox.Text, paraTextBox.Text);

                        if (!File.Exists(novoNome))
                        {
                            arquivo.CopyTo(novoNome);

                            arquivo.Delete();
                        }
                    }
                    MessageBox.Show("Troca Efetuada com sucesso!", "Happy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
