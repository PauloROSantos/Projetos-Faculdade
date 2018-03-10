using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SalvarArquivo
{
    public static class Dados
    {
        public static void Gravar(Cliente cli)
        {
            string meusDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string arquivo = "ClientesProdutos.txt";

            string nomeCompleto = Path.Combine(meusDocumentos, arquivo);

            using (var sw = new StreamWriter(nomeCompleto,true, Encoding.UTF8))
            {
                sw.WriteLine("----------------------------------");
                sw.WriteLine("Data: " + DateTime.Now.Date.ToString("d"));
                sw.WriteLine("nome: " + cli.nome);
                sw.WriteLine("email: " + cli.email);

                sw.WriteLine("Produtos:");
                foreach (var item in cli.produtos)
                {
                    sw.WriteLine("   - " + item);
                }

            }



        }
    }
}
