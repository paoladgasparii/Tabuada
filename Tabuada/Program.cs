using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;

            Console.WriteLine("Digite a tabuada: ");
            int tab = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de vezes: ");
            int vezes = int.Parse(Console.ReadLine());

            while (cont <= vezes)
            {
                double resultado = tab * cont;
                Console.WriteLine(tab + "x" +cont + "=" +resultado);
                cont++;
            }

            Console.ReadKey();
        }
    }
}
