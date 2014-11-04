using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appcontador10
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;
            float prom, suma = 0, valor;
            Console.WriteLine("ingrese los numeros");
                while(contador<=10)
                {
                    Console.WriteLine("ingrese un valor: ");
                    valor=float.Parse(Console.ReadLine());
                    suma=suma+valor;
                    contador++;
                }
            prom=suma/10;
            Console.WriteLine("la suma de los 10 numeros es:" +suma);
            Console.WriteLine("el promedio es:" +prom);
            Console.ReadKey();
        }
    }
}
