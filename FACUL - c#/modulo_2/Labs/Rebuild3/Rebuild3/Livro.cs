using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebuild3
{
    class Livro : IDados
    {
        public string Nome { get; set; }
        public string Escritor { get; set; }
        public int Edição { get; set; }
        public int NumeroDePaginas { get; set; }
        public string Observação { get; set; }
        public string Genero { get; set; }
        public string Idioma { get; set; }
        public string Editora { get; set; }

        public void Gravar()
        {
            string meusDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string arquivo = "Livros.txt";

            string caminhoCompleto = Path.Combine(meusDocumentos, arquivo);

            using (var sw = new StreamWriter(caminhoCompleto,true,Encoding.UTF8))
            {
                sw.WriteLine(Nome + ";" +
                             Escritor + ";"+
                             Edição + ";" +
                             NumeroDePaginas + ";"+
                             Genero + ";"+
                             Idioma + ";"+
                             Editora + ";"+
                             Observação);

            }
        }
        public override string ToString()
        {
            return "nome: "+ Nome+
                    "\n Editor: "+Escritor+
                    "\n Editora: "+Editora+
                    "\n Genero: "+Genero+
                    "\n Idioma: "+Idioma+
                    "\n Numero de Pag: "+NumeroDePaginas;
        }
    }
}
