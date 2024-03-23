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
            // Bucle principal que permite al usuario seleccionar opciones hasta que decida salir
            while (true)
            {
                Console.WriteLine("Selecciona una opción:");
                Console.WriteLine("1. Calcular Potencia");
                Console.WriteLine("2. Encontrar Números Primos entre 1 y 100");
                Console.WriteLine("3. Salir");
                Console.Write("Ingresa el número de opción: ");

                // Validar la entrada del usuario y ejecutar la opción seleccionada
                if (!int.TryParse(Console.ReadLine(), out int opcion) || opcion < 1 || opcion > 3)
                {
                    Console.WriteLine("Opción no válida.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        CalcularPotencia(); // Llama al método para calcular la potencia
                        break;

                    case 2:
                        EncontrarNumerosPrimos(); // Llama al método para encontrar números primos
                        break;

                    case 3:
                        Console.WriteLine("Saliendo del programa..."); // Mensaje de salida
                        return;
                }
            }
        }

        // Método para calcular la potencia
        static void CalcularPotencia()
        {
            Console.WriteLine("Calculadora de Potencia");
            Console.Write("Ingrese la base: ");
            if (!double.TryParse(Console.ReadLine(), out double baseNumber)) // Verifica que la entrada sea un número válido
            {
                Console.WriteLine("Entrada inválida. Debes ingresar un número.");
                return;
            }

            Console.Write("Ingrese el exponente: ");
            if (!int.TryParse(Console.ReadLine(), out int exponente)) // Verifica que la entrada sea un número entero válido
            {
                Console.WriteLine("Entrada inválida. Debes ingresar un número entero.");
                return;
            }

            double resultado = Math.Pow(baseNumber, exponente); // Calcula la potencia
            Console.WriteLine($"El resultado de {baseNumber}^{exponente} es: {resultado}");
        }

        // Método para encontrar números primos
        static void EncontrarNumerosPrimos()
        {
            Console.WriteLine("Números Primos entre 1 y 100:");

            for (int i = 1; i <= 100; i++)
            {
                if (EsPrimo(i)) // Verifica si el número actual es primo
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine();
        }

        // Método para verificar si un número es primo
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
