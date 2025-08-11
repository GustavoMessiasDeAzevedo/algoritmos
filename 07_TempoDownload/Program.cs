using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_TempoDownload
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string digitoNumerico;
            string valorMBPS;
            int mb, mbps;
              
            Console.WriteLine("Digite o tamanho do arquivo em MB: ");
            digitoNumerico = Console.ReadLine();
            while (!int.TryParse(digitoNumerico, out mb) || mb <= 0)
            {

                Console.WriteLine("O numero é menor ou igual a zero, ou possui digitos diferente de numeros");
                Console.WriteLine("Digite um valor numérico: ");
                digitoNumerico = Console.ReadLine();          
            }
            
            
            Console.WriteLine("Digite a velocidade da internet em mbps: ");
            valorMBPS = Console.ReadLine();
            while (!int.TryParse(valorMBPS, out mbps) || mbps <= 0)
            {
                Console.WriteLine("O numero é menor ou igual a zero, ou possui digitos diferente de numeros");
                Console.WriteLine("Digite um valor numérico: ");
                digitoNumerico = Console.ReadLine();
            }

            double valorSegundos = (mb * 8) / mbps;
            double valorMinutos = valorSegundos / 60;

            Console.WriteLine("O tempo aproximado é de: {0:F2}", valorMinutos);

        }
    }
}
