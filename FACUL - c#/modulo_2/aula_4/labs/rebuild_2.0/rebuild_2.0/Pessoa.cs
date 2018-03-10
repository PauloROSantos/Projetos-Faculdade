using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rebuild_2._0
{
    class Pessoa : IDados
    {
        public String Nome { get; set; }
        public int Idade { get; set; }
        public decimal Altura { get; set; }
        public decimal Peso { get; set; }

        public string Pais { get; set; }
        public string Estado { get; set; }

        public string Cidade { get; set; }

        public string Observação { get; set; }

        public void Gravar()
        {
            string meusDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string arquivo = "Pessoa.txt";

            string arquivoCompleto = Path.Combine(meusDocumentos, arquivo);

            using (var sw = new StreamWriter(arquivoCompleto,true,Encoding.UTF8))
            {
                sw.WriteLine(Nome + ";"+
                             Idade + ";"+
                             Altura + ";" +
                             Peso + ";" +
                             Pais + ";" +
                             Estado + ";" +
                             Cidade + ";" +
                             Observação);

            }
        }

        public override string ToString()
        {
            return "Nome: " + Nome +
                   "\n Idade: " + Idade +
                   "\n Altura: " + Altura +
                   "\n Peso: " + Peso +
                   "\n Pais: " + Pais +
                   "\n Estado: " + Estado +
                   "\n Cidade: " + Cidade;

        }
    }
}
