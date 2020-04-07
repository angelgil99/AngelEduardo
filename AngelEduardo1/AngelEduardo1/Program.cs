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
            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine($"{n1} Es el numero Mayor...");
            }
            else if (n1 < n2 & n1 > n3)
            {
                Console.WriteLine($"{n1} Es mayor que {n3} pero no es Mayor que {n2}, Por lo tanto no es el numero Mayor");
            }
            else if (n1 > n2 & n1 < n3)
            {

                Console.WriteLine($"{n1} es mayor que {n2} pero no es mayor que {n3}, Por lo tanto no es el numero Mayor... ");
            }


            Console.WriteLine();
            if (n2 > n1 & n2 > n3)
            {
                Console.WriteLine($"{n2} Es el numero Mayor...");
            }
            else if (n2 < n1 & n2 > n3)
            {
                Console.WriteLine($"{n2} Es mayor que {n3} pero no es Mayor que {n1}, Por lo tanto no es el numero Mayor");
            }
            else if (n2 > n1 & n2 < n3)
            {

                Console.WriteLine($"{n2} es mayor que {n1} pero no es mayor que {n3}, Por lo tanto no es el numero Mayor... ");
            }
            Console.WriteLine();
            if (n3 > n2 & n3 > n1)
            {
                Console.WriteLine($"{n3} Es el numero Mayor...");
            }
            else if (n3 < n2 & n3 > n1)
            {
                Console.WriteLine($"{n3} Es mayor que {n1} pero no es Mayor que {n2}, Por lo tanto no es el numero Mayor");
            }
            else if (n3 > n2 & n3 < n1)
            {

                Console.WriteLine($"{n3} es mayor que {n2} pero no es mayor que {n1}, Por lo tanto no es el numero Mayor... ");
            }
            Console.WriteLine();



            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
