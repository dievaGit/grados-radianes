using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallarPotencia
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0, potencia = 0, cont = 2, resultado = 0;

            Console.Write("Escriba el numero que desea hallar la potencia:");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Escriba la potencia a la que quiere elevar el numero");
            potencia = Convert.ToInt32(Console.ReadLine());
            resultado = numero;

            while(cont <= potencia)
            {
                resultado *= numero;
                cont += 1;
            }

            Console.WriteLine("El numero {0} elevado a la {1} potencia es igual a {2}", numero, potencia, resultado);
            Console.ReadKey();        
        }
    }
}
