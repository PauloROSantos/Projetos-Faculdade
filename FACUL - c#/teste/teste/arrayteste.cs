using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    class arrayteste
    {
        public ArrayList respostas { get; set; }
        

        public void PopularArray()
        {
            
            respostas.Add(5);
            respostas.Add(6);
            respostas.Add(7);
            respostas.Add(8);
        }

        public arrayteste()
        {
            respostas = new ArrayList();
            PopularArray();
        }
    }
}
