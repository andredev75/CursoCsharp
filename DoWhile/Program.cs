using System;
using System.Collections.Generic;
using System.Linq;

namespace DoWhile
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;

            }
            while (i < 5);
        }
    }
}