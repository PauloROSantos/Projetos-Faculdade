using System.Collections.Generic;

namespace SalvarArquivo
{
    public class Cliente
    {
        public string nome { get; set; }
        public string email { get; set; }
        public List<string> produtos   { get; set; }

        public Cliente()
        {
            produtos = new List<string>();
        }
    }
}