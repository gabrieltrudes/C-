using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            float soma = 0;
            float resultado;

            for (int x = 1; x < 13; x++)
            {
                Console.Write("Digite a nota do" + x + "º aluno: ");
                float nota = float.Parse(Console.ReadLine());
                soma = soma + nota;
            }
            resultado = (soma / 12);
            Console.WriteLine("A média final será: {0}", resultado);

            Console.ReadKey();
        }
         }
        }
    


