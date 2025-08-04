using System;

class DeclaracaoVariaveisDecimalFormatado
{

	static void Main(string [] args)
	{
		decimal x = 0.999m;
		decimal y = 9999999999999999999999999999m;
		Console.WriteLine("Minha quantia = {0:C}", x);
		Console.WriteLine("Sua quantia = {0:C}", y);
	}

}