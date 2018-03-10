using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rebuild3
{
    public static class Modificadores
    {
        public static string ValidarVazio(this TextBox txt)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.Focus();
                txt.SelectAll();
                throw new Exception("Preencha Este campo!");
            }
            return txt.Text;
        }
        public static short ValidarInt(this TextBox txt)
        {
            try
            {
                return Convert.ToInt16(txt.Text);
            }
            catch
            {
                txt.Focus();
                txt.SelectAll();
                throw new Exception("Preencha esse Campo com um Numero Inteiro");
            }
        }

        public static string ValidarCombo(this ComboBox cbo)
        {
            if(cbo.SelectedIndex == -1)
            {
                cbo.Focus();
                throw new Exception("Escolha uma Opção!");
            }
            return cbo.SelectedItem.ToString();
        }
        public static void LimparTela(this Form form)
        {
            foreach (Control ctl in form.Controls)
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
