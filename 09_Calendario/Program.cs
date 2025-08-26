using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Globalization;
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

            int diasDoMes = DateTime.DaysInMonth(ano, mes);
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

            int[] diasFeriados = RetornaFeriados(mes,ano);
            for (int semana = 0; semana < 6; semana++)
            {
                for (int diaDaSemana = 0; diaDaSemana < 7; diaDaSemana++)
                {
                    if (calendario[semana, diaDaSemana] != 0)
                    {
                        if (diasFeriados.Contains(calendario[semana, diaDaSemana]) || diaDaSemana == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(calendario[semana, diaDaSemana].ToString("D2") + "\t");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write(calendario[semana, diaDaSemana].ToString("D2") + "\t");
                        }
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine();
            }

            if (mes != 0)
            {
                Console.Write("Feriados: ");
                for (int i = 0; i <= diasFeriados.Length; i++)
                {
                    if(diasFeriados[i] > 0)
                    {
                        Console.Write($"{diasFeriados[i].ToString("D2")}\t");
                    }
                }
                
            }
        }


    public static int[] RetornaFeriados (int mes, int ano)
        {
            int[] feriados = new int[15];

            int indice = 0;
            //feriados[indice++] = 11;
            //feriados[indice++] = 21;

            if (mes == 1)
            {
                feriados[indice++] = 1;
            }
            else if (mes == 4) {

                feriados[indice++] = 4;
                feriados[indice++] = 21;
            }else if (mes == 5) {

                feriados[indice++] = 1;
            }else if (mes == 9) {

                feriados[indice++] = 7;
            }else if (mes == 10) {

                feriados[indice++] = 12;
            }else if (mes == 11) {

                feriados[indice++] = 2;
                feriados[indice++] = 15;
                feriados[indice++] = 20;
            }else if (mes == 12) {

                feriados[indice++] = 25;
            }

                return feriados;
        }
    }
}
