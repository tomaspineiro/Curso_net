using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPotenciaYPrimos
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Selecciona una opción:");
                Console.WriteLine("1. Calcular Potencia");
                Console.WriteLine("2. Encontrar Números Primos entre 1 y 100");
                Console.WriteLine("3. Salir");
                Console.Write("Ingresa el número de opción: ");

                if (!int.TryParse(Console.ReadLine(), out int opcion) || opcion < 1 || opcion > 3)
                {
                    Console.WriteLine("Opción no válida.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        CalcularPotencia();
                        break;

                    case 2:
                        EncontrarNumerosPrimos();
                        break;

                    case 3:
                        Console.WriteLine("Saliendo del programa...");
                        return;
                }
            }
        }

        static void CalcularPotencia()
        {
            Console.WriteLine("Calculadora de Potencia");
            Console.Write("Ingrese la base: ");
            if (!double.TryParse(Console.ReadLine(), out double baseNumber))
            {
                Console.WriteLine("Entrada inválida. Debes ingresar un número.");
                return;
            }

            Console.Write("Ingrese el exponente: ");
            if (!int.TryParse(Console.ReadLine(), out int exponente))
            {
                Console.WriteLine("Entrada inválida. Debes ingresar un número entero.");
                return;
            }

            double resultado = Math.Pow(baseNumber, exponente);
            Console.WriteLine($"El resultado de {baseNumber}^{exponente} es: {resultado}");
        }

        static void EncontrarNumerosPrimos()
        {
            Console.WriteLine("Números Primos entre 1 y 100:");

            for (int i = 1; i <= 100; i++)
            {
                if (EsPrimo(i))
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine();
        }

        static bool EsPrimo(int numero)
        {
            if (numero <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
