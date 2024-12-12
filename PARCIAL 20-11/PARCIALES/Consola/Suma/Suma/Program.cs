using System;

namespace conso
{

    public class Suma {
        public static void Main(string[] args)
        {

            Console.WriteLine("Ingrese un numero: ");

            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese un numero: ");

            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = num1 + num2;

            Console.WriteLine("La suma de los dos numero es: " + result);
        }
        
    }
}
