using System;
using System.Collections.Generic;
using System.Linq;

namespace Switch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //int dia = 4;
            int dia;

            Console.WriteLine("Digite o numero do dia: ");
            dia = Convert.ToInt32(Console.ReadLine());

            switch (dia)
            {
                case 1:
                    Console.WriteLine("Segunda-feira");
                    break;
                case 2:
                    Console.WriteLine("Terça-feira");
                    break;

                case 3:
                    Console.WriteLine("Quarta-feira");
                    break;
                case 4:
                    Console.WriteLine("Quinta-feira");
                    break;
                case 5:
                    Console.WriteLine("Sexta-feira");
                    break;
                case 6:
                    Console.WriteLine("Sabado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;

                default:
                    Console.WriteLine("O valor informado não conresponde");
                    break;
            }
        }
    }
}