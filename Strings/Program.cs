using System;
using System.Collections.Generic;
using System.Linq;

namespace Strings // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string nome = "Naruto";
            string sobrenome = "Uzumaki";
            Console.WriteLine(nome + " " + sobrenome);
            Console.WriteLine(string.Concat(nome, sobrenome));
            string nomeCompleto = $"{nome}{sobrenome}";
            Console.WriteLine(nomeCompleto);
            Console.WriteLine(nome[3]);
            Console.WriteLine(nome.IndexOf("u"));

            int posicao = nomeCompleto.IndexOf("U");
            // Pegar o sobrenome
            string nomeFinal = nomeCompleto.Substring(posicao);
            Console.WriteLine(nomeFinal);
            Console.WriteLine(nomeFinal.ToUpper());
            Console.WriteLine(nomeFinal.ToLower());

        }
    }
}