using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1;
            float n2;

            Console.WriteLine("Digite um número: ");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            n2 = float.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine("{0} será maior que {1}", n1, n2);
            }
            if (n1 == n2)
            {
                Console.WriteLine("{0} e {1} são iguais", n1, n2);
            }
            else
            { 
                Console.WriteLine("{0} será menor que {1}", n1, n2);
            }
                Console.ReadKey();        
    
            

        }
    }
}
