using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OperacionesParteA;

namespace ConsolaParteA
{
    public class Program
    {
        static void Main()
        {
            Aritmetica aritmetica = new Aritmetica();
            Logica logica = new Logica();

            while (true)
            {
                MostrarMenu();
                int opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        AritmeticaMenu(aritmetica);
                        break;
                    case 2:
                        LogicaMenu(logica);
                        break;
                    case 4:
                        return; 
                    default:
                        Console.WriteLine("Opción Invalida");
                        break;
                }
            }
        }

        static void MostrarMenu()
        {
            Console.WriteLine("Menu Operaciones");
            Console.WriteLine("1. Operación Aritmética");
            Console.WriteLine("2. Operación Lógica");
            Console.WriteLine("4. Salir");
            Console.WriteLine("Seleccione una opción:");
        }

        static void AritmeticaMenu(Aritmetica operaciones)
        {
            Console.WriteLine("\nOperaciones Aritméticas");
            Console.Write("Ingrese el primer número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine($"Resultado: {operaciones.Sumar(num1, num2)}");
                    break;
                case 2:
                    Console.WriteLine($"Resultado: {operaciones.Restar(num1, num2)}");
                    break;
                case 3:
                    Console.WriteLine($"Resultado: {operaciones.Multiplicar(num1, num2)}");
                    break;
                case 4:
                    try
                    {
                        Console.WriteLine($"Resultado: {operaciones.Dividir(num1, num2)}");
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                    break;
                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }
        }

        static void LogicaMenu(Logica operaciones)
        {
            Console.WriteLine("\nOperaciones Lógicas");
            Console.Write("Ingrese el primer booleano (1 para true o 0 para false): ");
            bool num1 = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Ingrese el segundo booleano (1 para true o 0 para false): ");
            bool num2 = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("1. AND");
            Console.WriteLine("2. OR");
            Console.WriteLine("3. NOT (primer valor)");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine($"Resultado: {operaciones.And(num1, num2)}");
                    break;
                case 2:
                    Console.WriteLine($"Resultado: {operaciones.Or(num1, num2)}");
                    break;
                case 3:
                    Console.WriteLine($"Resultado: {operaciones.Not(num1)}");
                    break;
                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }
        }
    }
}
