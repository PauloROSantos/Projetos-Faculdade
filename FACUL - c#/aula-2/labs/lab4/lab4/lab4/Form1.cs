using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class lab04Form : Form
    {
        public lab04Form()
        {
            InitializeComponent();
        }

        private void novoToolStripButton_Click(object sender, EventArgs e)
        {
            novoToolStripMenuItem.PerformClick();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textoRichTextBox.Rtf = string.Empty;
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Abrir arquivo";
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "Arquivos RTF|*.rtf";

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader leitor = new System.IO.StreamReader(openFileDialog1.FileName);

                textoRichTextBox.Rtf = leitor.ReadToEnd();

                leitor.Close();
            }
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Salvar arquivo";

            saveFileDialog1.FileName = "";

            saveFileDialog1.InitialDirectory = "C:\\";

            saveFileDialog1.Filter = "Arquivos RTF |*.rtf";

            if ( saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFileDialog1.FileName);

                sw.Write(textoRichTextBox.Rtf);

                sw.Close();
            }
        }

        private void encerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void recortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textoRichTextBox.SelectedRtf);

            textoRichTextBox.SelectedRtf = "";
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textoRichTextBox.SelectedRtf);
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textoRichTextBox.SelectedRtf = Clipboard.GetText();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textoRichTextBox.SelectAll();
        }

        private void fonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog().Equals(DialogResult.OK))
            {
                textoRichTextBox.SelectionFont = fontDialog1.Font;
            }
        }

        private void corDaFonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog().Equals(DialogResult.OK))
            {
                textoRichTextBox.SelectionColor = colorDialog1.Color;
            }
        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            abrirToolStripMenuItem.PerformClick();
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            salvarToolStripMenuItem.PerformClick();
        }

        private void cortarToolStripButton_Click(object sender, EventArgs e)
        {
            recortarToolStripMenuItem.PerformClick();
        }

        private void copiarToolStripButton_Click(object sender, EventArgs e)
        {
            copiarToolStripMenuItem.PerformClick();
        }

        private void colarToolStripButton_Click(object sender, EventArgs e)
        {
            colarToolStripMenuItem.PerformClick();
        }
    }
}
