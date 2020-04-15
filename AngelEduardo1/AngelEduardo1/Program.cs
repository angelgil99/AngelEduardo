using System;

namespace AngelEduardo1
{
class Program
{
	static void Main(string[] args)
	{
		Console.ForegroundColor = ConsoleColor.Blue;
		Console.WriteLine("- - - -  - - - EJERCICIO 1- - - - - - - - -");
		Console.ForegroundColor = ConsoleColor.White;
		Console.WriteLine("A continuacion ingrese tres numeros...");
		Console.ForegroundColor = ConsoleColor.Red; int n1 = Convert.ToInt32(Console.ReadLine());
		Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("Ingrese segundo valor: ");
		Console.ForegroundColor = ConsoleColor.Red; int n2 = Convert.ToInt32(Console.ReadLine());
		Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("Ingrese tercer valor: ");
		Console.ForegroundColor = ConsoleColor.Red; int n3 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine();
		Console.ForegroundColor = ConsoleColor.White;
		Console.WriteLine("Presione Enter...");
		Console.ReadLine();
		Console.ForegroundColor = ConsoleColor.Blue;
		Console.WriteLine($"Teniendo estos tres numeros queremos saber cual de ellos es mayor...");
		Console.ForegroundColor = ConsoleColor.White;

		Console.WriteLine(" ");
    
		int[] numbers = {n1, n2, n3};
		int temp;

		for (int j = 0; j <= numbers.Length - 2; j++) {
			for (int i = 0; i <= numbers.Length - 2; i++) {
				if (arr[i] > arr[i + 1]) {
					temp= arr[i + 1];
					arr[i + 1] = arr[i];
					arr[i] = temp;
				}
			}
		}
		Console.WriteLine($"{numbers[numbers.Length - 1]} Es el numero Mayor...");

		Console.WriteLine();
		Console.ReadLine();
	}
}
}
