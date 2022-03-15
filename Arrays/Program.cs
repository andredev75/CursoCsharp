using System;
using System.Collections.Generic;
using System.Linq;

namespace CondicaoFor
{
    public class Program
    {
        public static void Main(string[] args)
        {

            string[] carros = { "Fusca", "Brasilia", "Onix", "Volvo"};
            int[] numeros = { 1, 2, 3, 4 };

            carros[2] = "Passat amarelo";
            //Console.WriteLine(carros[2]);
            //Console.WriteLine(carros.Length);

            for(int i = 0; i < carros.Length; i++)
            {
                Console.WriteLine(carros[i]);
            }
        }
    }
}