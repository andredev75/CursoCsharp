using System;
using System.Collections.Generic;
using System.Linq;

namespace CondicaoIfElse // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //bool gostoDeGoiaba = false;

            //if(gostoDeGoiaba == true)
            //{
            //    Console.WriteLine("Eu compro");
            //}
            //else
            //{
            //    Console.WriteLine("Eu não compro");
            //}

            int time = 13;

            string resultado = (time < 12) ? "Bom dia" : "Boa tarde";

            Console.WriteLine(resultado);

            //if(time < 12)
            //{
            //    Console.WriteLine("Bom dia");
            //}
            //else if(time < 18)
            //{
            //    Console.WriteLine("Boa tarde");
            //}
            //else
            //{
            //    Console.WriteLine("Boa noite");
            //}




        }
    }
}