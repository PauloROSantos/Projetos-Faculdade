using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Rebuild
{
    public class Personagem : IDados
    {
        public string Nome { get; set; }
        public int Inteligencia { get; set; }
        public int Str { get; set; }
        public int Dex { get; set; }
        public int Vit { get; set; }
        public string Raça { get; set; }
        public string Classe { get; set; }
        public string Profissao { get; set; }
        public string Observação { get; set; }

        public void Gravar()
        {
            string meusDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string arquivo = "Personagem.txt";

            string arquivoCompleto = Path.Combine(meusDocumentos, arquivo);

            using (var sw = new StreamWriter(arquivoCompleto,true,Encoding.UTF8))
            {
                sw.WriteLine("----------------------------------------------------");
                sw.WriteLine("Nome : " + Nome);
                sw.WriteLine("Atributos :");
                sw.WriteLine("  - Inteligencia: " + Inteligencia);
                sw.WriteLine("  - Força: " + Str);
                sw.WriteLine("  - Dextreza: " + Dex);
                sw.WriteLine("  - Vitalidade: " + Vit);
                sw.WriteLine("Jobs :");
                sw.WriteLine("  - Raça: " + Raça);
                sw.WriteLine("  - Classe: " + Classe);
                sw.WriteLine("  - Profissao: " + Profissao);
                sw.WriteLine("Observação:");
                sw.WriteLine(Observação);

            }


        }

        public override string ToString()
        {
            return "Nome : " + Nome +
                    "\n Inteligencia: " + Inteligencia +
                    "\n Força: " + Str +
                    "\n Dextreza: " + Dex +
                    "\n Vitalidade: " + Vit +
                    "\n Raça: " + Raça +
                    "\n Classe: " + Classe +
                    "\n Profissão: " + Profissao;
                    
        }
    }

   
}
