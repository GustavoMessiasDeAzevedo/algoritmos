using System;

class par_ou_impar{
	
	
	static void Main(){
		
		int numero1;
		Console.WriteLine("Digite um numero: ");
		numero1 = Convert.ToInt32(Console.ReadLine());
		if(numero1 % 2 == 0){
			Console.WriteLine("O numero é par");
		}else{
			Console.WriteLine("O numero é impar");
		};
	}
}
