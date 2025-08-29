using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
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

            Console.WriteLine("Digite o ano");
            int ano = int.Parse(Console.ReadLine());


            ImprimirCalendario(ano);
        }

        public static int[] RetornaFeriados(int mes, int ano)
        {
            int[] feriados = new int[15];
            int indice = 0;


            DateTime pascoa = DomingoDePascoa(ano);

            DateTime carnaval = pascoa.AddDays(-47);
            DateTime sextaFeiraSanta = pascoa.AddDays(-2);
            DateTime corpusChristi = pascoa.AddDays(60);

            if (carnaval.Month == mes)
            {
                feriados[indice++] = carnaval.Day;
            }
            if (sextaFeiraSanta.Month == mes)
            {
                feriados[indice++] = sextaFeiraSanta.Day;
            }
            if (corpusChristi.Month == mes)
            {
                feriados[indice++] = corpusChristi.Day;
            }
            if (pascoa.Month == mes)
            {
                feriados[indice++] = pascoa.Day;
            }

            Array.Sort(feriados);
            if (mes == 1)
            {
                feriados[indice++] = 1;
            }
            else if (mes == 4)
            {
                feriados[indice++] = 21;
                feriados[indice++] = 4;
            }
            else if (mes == 5)
            {
                feriados[indice++] = 1;
            }
            else if (mes == 9)
            {
                feriados[indice++] = 7;
            }
            else if (mes == 10)
            {
                feriados[indice++] = 12;
            }
            else if (mes == 11)
            {
                feriados[indice++] = 2;
                feriados[indice++] = 15;
                feriados[indice++] = 20;
            }
            else if (mes == 12)
            {
                feriados[indice++] = 25;
            }

            return feriados;
        }

        public static DateTime DomingoDePascoa(int ano)
        {
            int a = ano % 19;
            int b = ano / 100;
            int c = ano % 100;
            int d = b / 4;
            int e = b % 4;
            int f = (b + 8) / 25;
            int g = (b - f + 1) / 3;
            int h = (19 * a + b - d - g + 15) % 30;
            int i = c / 4;
            int k = c % 4;
            int l = (32 + 2 * e + 2 * i - h - k) % 7;
            int m = (a + 11 * h + 22 * l) / 451;
            int mes = (h + l - 7 * m + 114) / 31;
            int dia = ((h + l - 7 * m + 114) % 31) + 1;

            return new DateTime(ano, mes, dia);
        }

     
        public static void ImprimirCalendario(int ano)
        {
            for (int mes = 1; mes <= 12; mes++)
            {
                DateTime primeiroDiaMes = new DateTime(ano, mes, 1);
                int diasDoMes = DateTime.DaysInMonth(ano, mes);
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
                Console.WriteLine($"\nCalendário de {primeiroDiaMes.ToString("MMMM")} de {ano}");
                Console.WriteLine("DOM\tSEG\tTER\tQUA\tQUI\tSEX\tSAB");

                int[] diasFeriados = RetornaFeriados(mes, ano);

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
                    Console.Write("Feriados fixos do mês: ");
                    for (int i = 0; i < diasFeriados.Length; i++)
                    {
                        if (diasFeriados[i] > 0)
                        {
                            Console.Write($"{diasFeriados[i].ToString("D2")}\t");
                        }
                    }
                    Console.WriteLine();
                }
            }
            DateTime pascoa = DomingoDePascoa(ano);
            Console.WriteLine($"\nO Domingo de Páscoa em {pascoa.Day}/{pascoa.Month}/{ano}");
            Console.WriteLine("A Terça-feira de Carnaval ocorre 47 dias antes da Páscoa");
            Console.WriteLine("A Sexta-feira Santa ocorre 2 dias antes da Páscoa");
            Console.WriteLine("Corpus Christi ocorre 60 dias após a Páscoa");
        }
    }
}
