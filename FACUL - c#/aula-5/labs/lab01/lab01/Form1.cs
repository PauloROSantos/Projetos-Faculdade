using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void numeroTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!numeroTextBox.Text.Trim().Equals(""))
            {
                resultadoLabel.Text = string.Empty;
                for (int i = 1; i <= 10; i++)
                {
                    resultadoLabel.Text += string.Format("{0} x {1} = {2}\n", numeroTextBox.Text, i, (i * Convert.ToInt32(numeroTextBox.Text)));
                }
            }
            else
            {
                resultadoLabel.Text = string.Empty;
                
            }
           
        }
    }
}
