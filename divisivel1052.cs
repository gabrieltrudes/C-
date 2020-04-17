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
            Console.WriteLine("Entre com um número: ");
            float n1 = float.Parse(Console.ReadLine());

            float div10 = n1 % 10;
            float div5 = n1 % 5;
            float div2 = n1 % 2;

            if (div10 == 0)
            {
                Console.WriteLine("{0} é divisível por 10", n1);
            }
            else
            {
                Console.WriteLine("{0} não é divisível por 10", n1);
            }
            if (div5 == 0)
            {
                Console.WriteLine("{0} é divisível por 5", n1);
            }
            else
            {
                Console.WriteLine("{0} não é divisível por 5", n1);
            }
            if (div2 == 0)
            {
                Console.WriteLine("{0} é divisível por 2", n1);
            }
            else
            {
                Console.WriteLine("{0} não é divisível por 2", n1);
            }
                
                Console.ReadKey();        
    
            

        }
    }
}
