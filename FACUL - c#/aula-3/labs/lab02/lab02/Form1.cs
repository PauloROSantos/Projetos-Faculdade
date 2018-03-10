using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void calcularButton_Click(object sender, EventArgs e)
        {
            decimal compra = Convert.ToDecimal(valorDaCompraTextBox.Text);

            decimal pago = Convert.ToDecimal(valorPagoDinheiroTextBox.Text);

            decimal troco = (pago - compra);

            double troco2 = Convert.ToDouble(pago - compra);

            if ( pago > compra)
            {
               

                int _1real = (int)(troco / 1 );

                int _50cents = Convert.ToInt16((troco % 1) / 0.50m);

                int _25cents = Convert.ToInt16( ( (troco % 1) % 0.50m) / 0.25m);

                int _10cents = Convert.ToInt16((( (troco % 1) % 0.50m) % 0.25m) / 0.10m);

                int _5cents = Convert.ToInt16(((((troco % 1) % 0.50m) % 0.25m) % 0.10m) / 0.05m);

                int _1cents = Convert.ToInt16((((((troco % 1) % 0.50m) % 0.25m) % 0.10m) % 0.05m) / 0.01m);

                qtdMoedas1RealLabel.Text = Convert.ToString(_1real);
                qtdMoedas50centsLabel.Text = Convert.ToString(_50cents);
                qtdMoedas25centsLabel.Text = Convert.ToString(_25cents);
                qtdMoedas10centsLabel.Text = Convert.ToString(_10cents);
                qtdMoedas5centsLabel.Text = Convert.ToString(_5cents);
                qtdMoedas1centsLabel.Text = Convert.ToString(_1cents);

                trocoLabel.Text = (_1real +
                                    _50cents * 0.05 +
                                    _25cents * 0.25 +
                                    _10cents * 0.10 +
                                    _5cents * 0.05 +
                                    _1cents * 0.01).ToString("C2");
            }   
            else
            {
                MessageBox.Show("Não tem troco rapa!");
            }
        }
    }
}
