using System;

public class Program04
{
	public static void Main()
	{
		int numero=5;
		if (numero>=0 && numero<5) {
			Console.WriteLine("Has suspendido.");
		} else if (numero==5) {
			Console.WriteLine("Has aprobado por los pelos.");
		} else {
			Console.WriteLine("Has sacado buena nota.");
		}
	}
}
