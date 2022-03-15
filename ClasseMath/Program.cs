using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassMath // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Valor maximo: " + Math.Max(5, 10));
            Console.WriteLine("Valor minimo: " + Math.Min(5, 10));

            Console.WriteLine("Raiz quadrada: " + Math.Sqrt(64));
            Console.WriteLine("Arrendondamento: " + Math.Round(9.99));

            int num1, num2;
            Console.WriteLine("Digite um numero:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite outro numero:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("O menor numero digitado é: " + Math.Min(num1, num2) + " O maior Numero digitado é: " + Math.Max(num1, num2));

            

        }
    }
}