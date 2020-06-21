using System;

namespace Sinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escreva um número: ");
            decimal numero=Convert.ToDecimal(Console.ReadLine());

            Console.Clear();

            if(numero>0)
            Console.WriteLine("positivo");
            else if(numero<0)
            Console.WriteLine("negativo");
            else
            Console.WriteLine("zero");


            
            
        }
    }
}
