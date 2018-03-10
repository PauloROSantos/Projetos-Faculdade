using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class lab02Form : Form
    {
        public lab02Form()
        {
            InitializeComponent();
        }

        private void AtualizarCor()
        {
            corResultanteLabel.BackColor = Color.FromArgb(
                redHScrollBar.Value,
                verdeHScrollBar.Value,
                azulHScrollBar.Value);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void redHScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            redvalorLabel.Text = Convert.ToString(redHScrollBar.Value);
            AtualizarCor();
        }

        private void verdeHScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            verdeValorLabel.Text = Convert.ToString(verdeHScrollBar.Value);
            AtualizarCor();
        }

        private void azulHScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            azulValorLabel.Text = Convert.ToString(azulHScrollBar.Value);
            AtualizarCor();
        }

        private void lab02Form_Load(object sender, EventArgs e)
        {
            redHScrollBar_Scroll(null, null);
            verdeHScrollBar_Scroll(null, null);
            azulHScrollBar_Scroll(null, null);
        }
    }
}
