using System;

class CalculoIMC
{
	
	static void Main()
	{
		double peso, altura, imc;
	
		Console.WriteLine("Digite seu peso atual: ");
		peso = Double.Parse(Console.ReadLine());
		
		Console.WriteLine("Digite seu altura atual: ");
		altura = Double.Parse(Console.ReadLine());
		
		imc = peso / (altura * altura);
		
		if(imc < 18.5){
			Console.WriteLine("Classificação: Abaixo do peso normal");
		}else if (imc < 25){
			Console.WriteLine("Classificação: Peso normal");
		}else{
			Console.WriteLine("Classificação: Acima do peso");
		};
	}
}