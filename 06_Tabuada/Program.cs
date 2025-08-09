using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int multiplicando;

            Console.WriteLine("Digite um número: ");
            multiplicando = int.Parse(Console.ReadLine());

            for (int multiplicador = 0; multiplicador <= 10; multiplicador++) {

                Console.WriteLine("{0} x {1} = {2}", multiplicando, multiplicador, multiplicando*multiplicador);
            }
        }
    }
}
