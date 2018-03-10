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
    public partial class lab01Form : Form
    {
        public lab01Form()
        {
            InitializeComponent();
        }

        private void validarButton_Click(object sender, EventArgs e)
        {
            // Consistir os dados ( testar se não esta vazio ou com espaço )
            if (string.IsNullOrWhiteSpace(cpfTextBox.Text))
            {
                MessageBox.Show("CPF É OBRIGATORIO!");
                cpfTextBox.Focus();
                cpfTextBox.SelectAll();
                return;
            }


            // Tratando o cpf informado ( removendo . - e " " )
            string cpfInformado = cpfTextBox.Text.Replace(".", "").Replace("-", "").Replace(" ", "");


            // Testando se o cpf informado tem 11 posições
            if (cpfInformado.Length != 11)
            {

                resultadoLabel.Text = string.Empty;
                resultadoLabel.Text = cpfInformado;
                resultadoLabel.Text += "\n CPF INVALIDO";
                resultadoLabel.ForeColor = Color.Red;
                return;


            }

            // Separar as primeiras 9 posições  ( sem os digitos )
            string cpf = cpfInformado.Substring(0, 9);

            // acumulador
            int soma = 0;

            // valor de referencia
            int valorRef = 10;

            // Posição vai de 0 à 8 enquanto valorRef vai de 10 à 2

            for (int i = 0; i <= 8; i++)
            {
                soma += Convert.ToInt32(cpf[i].ToString()) * valorRef--;
            }

            // Primeiro dígito é o resto do valor acumulado dividido por 11

            int dv1 = (int)(soma % 11);

            //Se dv for menor que 2, então dv vale 0      
            //Se dv for maior ou igual a 2, então dv vale 11 menos dv

            if (dv1 < 2)
            {
                dv1 = 0;
            }
            else
            {
                dv1 = 11 - dv1;
            }

            //Verificar se o primeiro dígito verificador informado é válido

            if (!cpfInformado.Substring(9, 1).Equals(dv1.ToString()))
            {
                resultadoLabel.Text = string.Empty;
                resultadoLabel.Text = cpfInformado;
                resultadoLabel.Text += "\n CPF INVALIDO";
                resultadoLabel.ForeColor = Color.Red;
                return;
            }

            //Calcular segundo dígito verificador       
            //Acrescentando dv1 ao cpf de teste

            cpf = cpf + dv1.ToString();

            //”Zerar” as variáveis
            valorRef = 11; soma = 0;

            //Posição vai de 0 à 9 enquanto valorRef vai de 11 à 2       
            for (int i = 0; i <= 9; i++)
            {
                soma += Convert.ToInt32(cpf[i].ToString()) * valorRef--;
            }

            //Segundo dígito é o resto do valor acumulado dividido por 11
            int dv2 = (int)(soma % 11);

            //Se dv for menor que 2, então dv vale 0       
            //Se dv for maior ou igual a 2, então dv vale 11 menos dv    
            
            if (dv2 < 2)
            {
                dv2 = 0;
            }
            else
            {
                dv2 = 11 - dv2;
            }

            //Verificar se o segundo dígito verificador informado é válido  
            
            if (!cpfInformado.Substring(10, 1).Equals(dv2.ToString()))
            {
                resultadoLabel.Text = string.Empty;
                resultadoLabel.Text = cpfInformado;
                resultadoLabel.Text += "\n CPF INVALIDO";
                resultadoLabel.ForeColor = Color.Red;
                return;
            }


            // cpf valido
            {
                resultadoLabel.Text = string.Empty;
                resultadoLabel.Text = cpfInformado;
                resultadoLabel.Text += "\n CPF VALIDO!";
                resultadoLabel.ForeColor = Color.Green;
            }
        }
    }
}


