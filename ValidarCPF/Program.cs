using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValidarCPF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o CPF: ");
            string cpf = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(cpf)){
                Console.WriteLine("O campo não pode estar vazio.");
            }
            else{
                string cpfNumeros = RemoverCaracteresEspeciais(cpf);

                if (cpfNumeros.Length != 11){
                    Console.WriteLine("O CPF deve conter 11 números.");
                }
                else if (Letras(cpf)){
                    Console.WriteLine("O CPF não pode conter letras.");
                }
                else{
                    if (ValidarCPF(cpfNumeros)){
                        Console.WriteLine("CPF válido!");
                    }
                    else{
                        Console.WriteLine("CPF inválido!");
                    }
                }
            }
        }

        static string RemoverCaracteresEspeciais(string input)
        {
            return Regex.Replace(input, @"[^0-9]", "");
        }
        
        static bool Letras(string value){
            foreach (char c in value){
                if (char.IsLetter(c)){
                    return true;
                }
            }
            return false;
        }

        static bool ValidarCPF(string cpf){
            if (new string(cpf[0], 11) == cpf){
                return false;
            }
                

            if (cpf.Length == 11){
                int[] numeroCPF = new int[11];

                for (int i = 0; i < 11; i++)
                    numeroCPF[i] = int.Parse(cpf[i].ToString());

                // Primeiro dígito verificador
                int soma = 0;
                for (int i = 0; i < 9; i++)
                    soma += numeroCPF[i] * (10 - i);

                int resto = soma % 11;
                if (resto < 2)
                    numeroCPF[9] = 0;
                else
                    numeroCPF[9] = 11 - resto;

                // Segundo dígito verificador
                int soma2 = 0;
                for (int i = 0; i < 10; i++)
                    soma2 += numeroCPF[i] * (11 - i);

                int resto2 = soma2 % 11;
                if (resto2 < 2){
                    numeroCPF[10] = 0;
                }else{
                    numeroCPF[10] = 11 - resto2;
                }
                    

                if (cpf[9].ToString() == numeroCPF[9].ToString() && cpf[10].ToString() == numeroCPF[10].ToString()){
                    return true;
                }else{
                    return false;
                }
            }
            else{
                return false;
            }
        }
    }
}
