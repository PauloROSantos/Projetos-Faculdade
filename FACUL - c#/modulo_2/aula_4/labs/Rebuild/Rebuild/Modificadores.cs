using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rebuild
{
    static class MetodosDeExtenção
    {

        public static string VerificaVazio(this TextBox txt)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.Focus();
                txt.SelectAll();
                throw new Exception("Preencha o campo!");
                

            }
            return txt.Text;

        }

        public static Int16 VerificaNumerico(this TextBox txt)
        {
           
            try
            {
                return Convert.ToInt16(txt.Text);
            }
            catch 
            {
                txt.Focus();
                txt.SelectAll();
                throw new Exception("Precisa ser um numero!");
                
                
                
            }
   
        }
        public static string VerificaCombo(this ComboBox cbo)
        {
            if (cbo.SelectedIndex == -1)
            {
                cbo.Focus();
                throw new Exception("Selecione um item!");
                


            }
            return cbo.Text;

        }

        public static void LimparTela(this Form form)
        {
            foreach (Control ctl in form.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = string.Empty;

                }
                else if (ctl is ComboBox)
                {
                    (ctl as ComboBox).SelectedIndex = -1;

                }
               

            }
        }
    }
}
