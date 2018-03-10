using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class lab03Form : Form
    {
        public lab03Form()
        {
            InitializeComponent();
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            buscarOpenFileDialog1.Filter = "Arquivos bmp|*.bmp|Arquivos jpg|*.jpg";

            
            if(buscarOpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imagemPictureBox.ImageLocation = buscarOpenFileDialog1.FileName;
            }
        }
    }
}
