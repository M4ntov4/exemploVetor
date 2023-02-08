using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetoresExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valor = new int[5];// basico pra declarar um vetor

            int[] valor2; // basico para um usuario definir um tamanho parte 1
            int valor3;

            Console.WriteLine("insira o tamanho do vetor: ");
            valor3 = int.Parse(Console.ReadLine());

            valor2 = new int[valor3]; // basico para um usuario definir um tamanho parte 2


        }
    }
}
