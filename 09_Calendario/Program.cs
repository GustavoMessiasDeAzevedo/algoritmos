using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Calendario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o mês (1..12)");
            int mes = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o ano");
            int ano = int.Parse(Console.ReadLine());

            //diasdo mes

            int diasDoMes = DateTime.DaysInMonth(ano, mes);
            //gera o primeiro dia do mês
            DateTime primeiroDiaMes = new DateTime(ano, mes, 1);
            int diaSemanaInicio = (int)primeiroDiaMes.DayOfWeek;

            int[,] calendario = new int[6, 7];

            int dia = 1;

            for (int semana = 0; semana < 6; semana++)
            {

                for (int diaDaSemana = 0; diaDaSemana < 7; diaDaSemana++)
                {

                    if (semana == 0 && diaDaSemana < diaSemanaInicio)
                    {

                        calendario[semana, diaDaSemana] = 0;
                    }
                    else if (dia <= diasDoMes)
                    {
                        calendario[semana, diaDaSemana] = dia++;
                    }
                }
            }

            Console.WriteLine($"\nCalendario de " + $"{primeiroDiaMes.ToString("MMMM")} de {ano}");
            Console.WriteLine("DOM\tSEG\tTER\tQUA\tQUI\tSEX\tSAB");
            for (int semana = 0; semana < 6; semana++)
            {
                for (int diaDaSemana = 0; diaDaSemana < 7; diaDaSemana++)
                {
                    if (calendario[semana, diaDaSemana] == 0)
                        Console.Write("\t");
                    else
                        Console.Write($"{calendario[semana, diaDaSemana]}\t");
                }
                Console.WriteLine();
            }

        }
    }
}
