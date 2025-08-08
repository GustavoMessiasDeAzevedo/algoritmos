using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Vetores
{
    internal class Program
    {
        static void Main(string[] args)
         {
            string nome = "Fulano de tal!";
            Console.WriteLine(nome);

            string[] nomes = { "Fulano de tal", "Beltrano", "Sicrano", "João", "José", "Maria" };
            Console.WriteLine(nomes[0]);
            Console.WriteLine(nomes[1]);
            Console.WriteLine(nomes[2]);

            //Loop FOR
            for (int i = 0; i < nomes.Length; i++) { 
                Console.WriteLine("{0}° Nome: {1}", i+1, nomes[i]);
            }

            for(int i = 0; i <= 100; i += 2)
            {
                Console.WriteLine("Número: {0}",i);
            }

            //loop foreach 
            foreach (string varNome in nomes) { 
                Console.WriteLine("Nome: {0}",varNome);
            }
        }
    }
}
