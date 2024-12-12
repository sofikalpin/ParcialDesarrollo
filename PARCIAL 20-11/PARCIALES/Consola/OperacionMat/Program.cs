using System;
using Biblio;

namespace ConsolaParteA
{
    public class Program
    {
        static void Main()
        {
            Class1 aritmetica = new Class1();
            bool continuar = true;

            while (continuar)
            {
                AritmeticaMenu(aritmetica);
                Console.WriteLine("\n¿Desea realizar otra operación? (s/n): ");
                string respuesta = Console.ReadLine()?.ToLower();
                continuar = respuesta == "s";
            }

            Console.WriteLine("Gracias por usar el programa.");
        }

        static void AritmeticaMenu(Class1 operaciones)
        {
            try
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
                Console.Write("Seleccione una opción: ");
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
                        if (num2 != 0)
                            Console.WriteLine($"Resultado: {operaciones.Dividir(num1, num2)}");
                        else
                            Console.WriteLine("Error: No se puede dividir entre cero.");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Por favor, ingrese un número válido.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error: " + ex.Message);
            }
        }
    }
}


