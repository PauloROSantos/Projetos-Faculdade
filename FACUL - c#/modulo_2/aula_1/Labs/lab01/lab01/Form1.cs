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

        private void lerButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Arquivos de texto(*.txt)|*.txt";
            string[] dados = new string[4];

            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                textoListBox.Items.Add("CODIGO".PadRight(7) +
                                        "CLIENTE".PadRight(40) +
                                        "CIDADE".PadRight(20) +
                                        "PAIS");

                textoListBox.Items.Add(new string('-', 80));

                var nomeArquivo = openFileDialog1.FileName;

                using (var sr = new StreamReader(nomeArquivo, Encoding.UTF7))
                {
                    while (!sr.EndOfStream)
                    {
                        dados = sr.ReadLine().Split(';');

                        textoListBox.Items.Add(dados[0].PadRight(7) +
                                                dados[1].PadRight(40) +
                                                dados[2].PadRight(20) +
                                                dados[3]);
                    }
                }

                


            }
        }
    }
}
