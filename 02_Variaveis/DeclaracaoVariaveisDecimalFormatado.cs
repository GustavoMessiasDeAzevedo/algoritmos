using System;

class DeclaracaoVariaveisDecimalFormatado
{

	static void Main(string [] args)
	{
		decimal x = 0.999m;
		decimal y = 9999999999999999999999999999m;
		/*
		Utilizando Placeholder para demonstrar o conteudo
		de uma variavel no texto
		{0:C}
		0 = Posição da marcação
		C = Formatação da moeda (Currency)
		*/
		Console.WriteLine("Minha quantia = {0:C}", x);
		Console.WriteLine("Sua quantia = {0:C}", y);
		Console.WriteLine("Valor de X = {0:F3} e valor de y = {1:C}", x,y);
		
		/*
		Interpolação de string
		
		
		Console.WriteLine($"Minha quantia = {x:C}");
		Console.WriteLine($"Sua quantia = {y:C}");
		Console.WriteLine($"Valor de X = {x:F3} e valor de y = {y:C}");
		*/
	}

}