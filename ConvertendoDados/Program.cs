using System;
using System.Collections.Generic;
using System.Linq;

namespace ConvertendoDados // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int meuInteiro = 10;
            double meuDouble = 5.25;
            bool meuBool = true;

            Console.WriteLine(Convert.ToString(meuInteiro));
            Console.WriteLine(Convert.ToDouble(meuInteiro));
            Console.WriteLine(Convert.ToInt32(meuDouble));
            Console.Write("Teste");
            Console.WriteLine("Novo Conteudo");
        }
    }
}