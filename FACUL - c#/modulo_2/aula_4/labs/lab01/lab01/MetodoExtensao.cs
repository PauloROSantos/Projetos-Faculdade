using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab01
{
    static class MetodoExtensao
    {

        // Definindo o metodo que valida textBox vazia
        public static string ValidarVazio(this TextBox txt)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.Focus();
                txt.SelectAll();
                throw new Exception("Preencha o campo"+ txt.AccessibleName.ToUpper());
            }
            return txt.Text;
        }

        // Definindo metodo que valida ComboBox vazia

        public static string ValidarCombo(this ComboBox combo)
        {
            if(combo.SelectedIndex == -1)
            {
                combo.Focus();
                throw new Exception("Escolha uma opção" + combo.AccessibleName.ToUpper());
            }
            return combo.Text;
        }

        // Definindo metodo que valida int16 ( ano )

        public static short ValidarInt16(this TextBox txt)
        {
            try
            {
                return Convert.ToInt16(txt.Text);
            }
            catch 
            {
                txt.Focus();
                txt.SelectAll();
                throw new Exception("Ano deve ser numerico");
            }
        }

        // Definindo o metodo que valida o ano

        public static short ValidarAno(this short ano)
        {
            if ( ano < 1950 || ano > DateTime.Now.Year + 1)
            {
                throw new Exception("ano deve estar entre 1950 e " + (DateTime.Now.Year +1).ToString());
            }
            return ano;
        }

        // Definindo o metodo que valida a placa

        public static string ValidarPlaca(this string placa)
        {
            if(!Regex.IsMatch(placa, "^[a-zA-Z]{3,3}[0-9]{4,4}$"))
            {
                throw new Exception("Informe uma placa Valida");
            }
            return placa;
        }

        // Definindo o metodo que limpa a tela
        public static void LimparTela(this Form Formulario)
        {
            foreach (Control ctl in Formulario.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = string.Empty;

                }
                else if(ctl is ComboBox)
                {
                    (ctl as ComboBox).SelectedIndex = -1;
                }

            }
        }

    }
}
