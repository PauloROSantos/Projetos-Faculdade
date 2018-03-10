using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploWindowsApp
{
    public partial class Form1 : Form
    {
        int teste;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("AE CUZAO");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sera que poderiamos fazer um jogo");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(teste == 45)
            {
                MessageBox.Show("kkkkkk");
            }
            else
            {
                MessageBox.Show("EITA FIAO");
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            teste = 45;
        }
    }
}
