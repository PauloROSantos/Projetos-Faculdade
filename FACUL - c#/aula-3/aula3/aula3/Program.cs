using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 15, c = 10;

            bool d = a == c || b != a && a == b;
            Console.WriteLine(d);
        }
    }
}
