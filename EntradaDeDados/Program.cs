using System;
using System.Collections.Generic;
using System.Linq;

namespace EntradaDeDados // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.Write("Qual Seu nome? ");
            string nomeDaPessoa = Console.ReadLine();

            Console.Write("Qual sua idade? ");
            int idadeDaPessoa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("O nome é: " + nomeDaPessoa + " Sua Idade é: " + idadeDaPessoa);
            
        }
    }
}