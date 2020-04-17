using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 1)
            {
                Console.WriteLine("Digite um número para verificar sua tabuada: ");
                int numero = int.Parse(Console.ReadLine());

                for (int x = 1; x < 11; x++)
                {
                    int resp = numero * x;
                    Console.WriteLine(numero + "x" + x + "=" + resp);
                }
                Console.WriteLine("Tecle (1) para realizar uma nova tabuada");
                Console.WriteLine("Tecle (2) para sair");
                int decisao = int.Parse(Console.ReadLine());

                if (decisao == 1)
                {
                    i = 0;
                }
                if (decisao == 2)
                {
                    i++;
                }

            }

        }
    }
}
