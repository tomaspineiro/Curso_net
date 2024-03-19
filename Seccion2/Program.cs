using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Seccion2 // Nota: reemplazar "MiApp" por el nombre que se le dio al proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            double temperaturaCelsius, temperaturaFahrenheit, longitudLado = 0.0;
            int numeroLados = 0;
            bool entradaValida;
            string opcion;

            do
            {
                entradaValida = false;
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Esta es la solucion de La tarea 2: ");
                Console.WriteLine("opción 1: calcular perimetro de cualquier poligono regular");
                Console.WriteLine("opción 2: pasar de grados centígrados a grados fahrenheit.");
                Console.WriteLine("opción 3: pasar de grados fahrenheit a grados centígrados ");
                Console.WriteLine("opción 4: salir.");
                Console.Write("Qué opción quieres hacer? (1, 2, 3 o 4): ");

                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Cálculo del perímetro de un polígono regular");
                        Console.WriteLine("---------------------------------------------");

                        // Solicitar al usuario el número de lados del polígono hasta que se ingrese un valor válido
                        while (!entradaValida)
                        {
                            Console.Write("Ingrese el número de lados del polígono: ");
                            string input = Console.ReadLine();

                            if (int.TryParse(input, out numeroLados) && numeroLados > 2)
                            {
                                entradaValida = true;
                            }
                            else
                            {
                                Console.WriteLine("Por favor, ingrese un número entero válido mayor que 2.");
                            }
                        }

                        entradaValida = false; // Reiniciamos la variable de entrada válida para el siguiente ciclo

                        // Solicitar al usuario la longitud de un lado del polígono hasta que se ingrese un valor válido
                        while (!entradaValida)
                        {
                            Console.Write("Ingrese la longitud de un lado del polígono: ");
                            string input1 = Console.ReadLine();

                            if (double.TryParse(input1, out longitudLado) && longitudLado > 0)
                            {
                                entradaValida = true;
                            }
                            else
                            {
                                Console.WriteLine("Por favor, ingrese un número decimal válido mayor que 0.");
                            }
                        }

                        // Calcular el perímetro del polígono
                        double perimetro = CalcularPerimetro(numeroLados, longitudLado);

                        // Mostrar el resultado
                        Console.WriteLine($"El perímetro del polígono con {numeroLados} lados y longitud de lado {longitudLado} es: {perimetro}");

                        break;

                    case "2":
                        Console.Write("Ingrese la temperatura en grados Celsius: ");
                        entradaValida = double.TryParse(Console.ReadLine(), out temperaturaCelsius);

                        if (entradaValida)
                        {
                            // Calcular la temperatura en grados Fahrenheit
                            temperaturaFahrenheit = CelsiusAFahrenheit(temperaturaCelsius);

                            // Mostrar el resultado
                            Console.WriteLine($"La temperatura de {temperaturaCelsius} grados Celsius es equivalente a {temperaturaFahrenheit} grados Fahrenheit.");
                        }
                        else
                        {
                            Console.WriteLine("Por favor, ingrese un número decimal válido.");
                        }
                        break;

                    case "3":
                        Console.Write("Ingrese la temperatura en grados Fahrenheit: ");
                        entradaValida = double.TryParse(Console.ReadLine(), out temperaturaFahrenheit);

                        if (entradaValida)
                        {
                            // Calcular la temperatura en grados Celsius
                            temperaturaCelsius = FahrenheitACelsius(temperaturaFahrenheit);

                            // Mostrar el resultado
                            Console.WriteLine($"La temperatura de {temperaturaFahrenheit} grados Fahrenheit es equivalente a {temperaturaCelsius} grados Celsius.");
                        }
                        else
                        {
                            Console.WriteLine("Por favor, ingrese un número decimal válido.");
                        }
                        break;

                    case "4":
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("No es una de las opciones que tenemos disponibles.");
                        break;
                }

                // Borra la pantalla
                Console.ReadKey();
                Console.Clear();

            } while (opcion != "4");
        }

        // Función para calcular el perímetro de un polígono regular
        static double CalcularPerimetro(int numeroLados, double longitudLado)
        {
            // El perímetro de un polígono regular se calcula multiplicando la longitud de un lado por el número de lados
            double perimetro = numeroLados * longitudLado;
            return perimetro;
        }

        // Función para convertir grados Celsius a Fahrenheit
        static double CelsiusAFahrenheit(double temperaturaCelsius)
        {
            double temperaturaFahrenheit = (temperaturaCelsius * 9 / 5) + 32;
            return temperaturaFahrenheit;
        }

        // Función para convertir grados Fahrenheit a Celsius
        static double FahrenheitACelsius(double temperaturaFahrenheit)
        {
            double temperaturaCelsius = (temperaturaFahrenheit - 32) * 5 / 9;
            return temperaturaCelsius;
        }
    }
}
