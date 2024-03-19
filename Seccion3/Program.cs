using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion3 // Espacio de nombres para organizar el código
{
    class Program
    {
        static void Main()
        {
            // Bucle principal para mantener el programa en ejecución
            while (true)
            {
                // Mostrar el menú de opciones al usuario
                Console.WriteLine("Selecciona una opción:");
                Console.WriteLine("1. Determinar el nombre del mes correspondiente a un número del 1 al 12.");
                Console.WriteLine("2. Determinar si un número es par o impar.");
                Console.WriteLine("3. Calcular el precio del estacionamiento según el tiempo de permanencia.");
                Console.WriteLine("4. Salir.");
                Console.Write("Ingresa el número de opción: ");

                // Leer la opción seleccionada por el usuario
                if (!int.TryParse(Console.ReadLine(), out int opcion) || opcion < 1 || opcion > 4)
                {
                    // Manejar el caso de una entrada inválida
                    Console.WriteLine("Opción no válida.");
                    continue; // Volver al inicio del bucle para mostrar el menú nuevamente
                }

                // Salir del programa si la opción seleccionada es 4
                if (opcion == 4)
                {
                    Console.WriteLine("Saliendo del programa...");
                    break; // Salir del bucle y finalizar la ejecución del programa
                }

                // Procesar la opción seleccionada por el usuario
                switch (opcion)
                {
                    case 1:
                        // Determinar el nombre del mes correspondiente a un número del 1 al 12
                        Console.Write("Ingresa un número del 1 al 12: ");
                        if (!int.TryParse(Console.ReadLine(), out int numeroMes) || numeroMes < 1 || numeroMes > 12)
                        {
                            Console.WriteLine("Número de mes inválido.");
                            continue; // Volver al inicio del bucle si la entrada es inválida
                        }

                        string nombreMes;
                        switch (numeroMes)
                        {
                            case 1:
                                nombreMes = "Enero";
                                break;
                            case 2:
                                nombreMes = "Febrero";
                                break;
                            case 3:
                                nombreMes = "Marzo";
                                break;
                            case 4:
                                nombreMes = "Abril";
                                break;
                            case 5:
                                nombreMes = "Mayo";
                                break;
                            case 6:
                                nombreMes = "Junio";
                                break;
                            case 7:
                                nombreMes = "Julio";
                                break;
                            case 8:
                                nombreMes = "Agosto";
                                break;
                            case 9:
                                nombreMes = "Septiembre";
                                break;
                            case 10:
                                nombreMes = "Octubre";
                                break;
                            case 11:
                                nombreMes = "Noviembre";
                                break;
                            case 12:
                                nombreMes = "Diciembre";
                                break;
                            default:
                                nombreMes = "Número de mes inválido";
                                break;
                        }

                        Console.WriteLine("El nombre del mes es: " + nombreMes);
                        break;

                    case 2:
                        // Determinar si un número es par o impar
                        Console.Write("Ingresa un número: ");
                        if (!int.TryParse(Console.ReadLine(), out int numero))
                        {
                            Console.WriteLine("Entrada inválida. Debes ingresar un número entero.");
                            continue; // Volver al inicio del bucle si la entrada es inválida
                        }

                        if (numero % 2 == 0)
                        {
                            Console.WriteLine("El número es par.");
                        }
                        else
                        {
                            Console.WriteLine("El número es impar.");
                        }
                        break;

                    case 3:
                        // Calcular el precio del estacionamiento según el tiempo de permanencia
                        Console.Write("Ingresa el tiempo de permanencia en minutos: ");
                        if (!int.TryParse(Console.ReadLine(), out int tiempo) || tiempo <= 0)
                        {
                            Console.WriteLine("Tiempo de permanencia inválido. Debe ser un número entero positivo.");
                            continue; // Volver al inicio del bucle si la entrada es inválida
                        }

                        double precio;
                        if (tiempo <= 60)
                        {
                            precio = 5.00;
                        }
                        else if (tiempo <= 120)
                        {
                            precio = 15.00;
                        }
                        else
                        {
                            precio = 40.00;
                        }

                        Console.WriteLine("El precio a pagar es: $" + precio);
                        break;
                }
            
                // Esperar a que el usuario presione una tecla antes de borrar la pantalla
                Console.ReadKey();
                Console.Clear(); // Limpiar la pantalla para mostrar el menú nuevamente
            }
        }
    }
}

