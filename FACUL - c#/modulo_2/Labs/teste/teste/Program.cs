using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numeros = new int[8];

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = numeros.Length-i;

            }

            Console.WriteLine(numeros[6]); //(1)    
            Console.WriteLine(numeros[3]); //2
            Console.WriteLine(numeros[2]); //3
        }
    }
}
