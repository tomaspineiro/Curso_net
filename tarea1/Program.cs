using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace tarea1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Bienvenido a MiProyectoConsola!");
            Console.Write("Por favor, ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine($"¡Hola, {nombre}!");
        }
    }
}