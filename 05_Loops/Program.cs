using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //criação de um vetor para armazenamento de 100 elementos
            //string [] nomes = new string [] 
            string[] nomes = new string[100];
            string continuar = "S";
            int contador = 1;

            while(continuar.ToUpper() == "S")
            {
                Console.WriteLine("Digite o {0}° nome: ", contador+1);
                //Append: Adiciona um item no vetor
                nomes[contador] = Console.ReadLine();

                contador++;
                Console.WriteLine("Deseja continuar? (S/N)");
                continuar = Console.ReadLine();
            }
            foreach (string varNomes in nomes) { 
            
                if(!string.IsNullOrEmpty(varNomes))
                {
                    Console.WriteLine("Nome: {0}", varNomes);
                }
                
            }


        }
    }
}
