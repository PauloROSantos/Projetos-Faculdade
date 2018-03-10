using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rebuild_2._0
{
    static class Modificadores
    {
        public static void LimparTela(this Form form)
        {

            foreach (Control item in form.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                }
                else if (item is ComboBox)
                {
                    (item as ComboBox).SelectedIndex = -1;
                }

            }
            

        }

        public static string ValidaVazio(this TextBox txt)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.Focus();
                txt.SelectAll();
                throw new Exception("Preencha esse campo!");
            }
            return txt.Text;
        }

        public static int ValidaInt(this TextBox txt)
        {
            try
            {
                return Convert.ToInt16(txt.Text);
            }
            catch
            {
                txt.Focus();
                txt.SelectAll();

                throw new Exception("Preencha esse campo com um numero Inteiro");
            }
            

        }

        public static decimal ValidarDecimal(this TextBox txt)
        {
            try
            {
                return Convert.ToDecimal(txt.Text);
            }
            catch 
            {
                txt.Focus();
                txt.SelectAll();
                throw new Exception("Preencha esse campo com um numero Decimal");
            }
        }

        public static string ValidarCombo(this ComboBox cbo)
        {
            if(cbo.SelectedIndex == -1)
            {
                cbo.Focus();
                throw new Exception("Escolha uma opção");
            }
            return cbo.SelectedItem.ToString();
        }
    }
}
