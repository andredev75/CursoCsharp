using System;
using System.Collections.Generic;
using System.Linq;

namespace CondicaoFor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 8; i++)
            {   
                if(i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

            //string[] carros = { "Fusca Azul", "Brasilia", "Ferrari" };
            //foreach(string y in carros)
            //{
            //    Console.WriteLine(y);
            //}
        }
    }
}