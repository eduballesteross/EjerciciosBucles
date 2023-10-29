using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosBucles.Servicios
{
    internal class PeticionesImplementacion : PeticionesInterfaz
    {
        public int peticionEjercicio1()
        {
            int seleccionEjercicio1;

            Console.WriteLine("Introduzca un número entero mayor que cero: ");
            seleccionEjercicio1=Convert.ToInt32(Console.ReadLine());    

            return seleccionEjercicio1; 
        }

        public int SeleccionarYMostrarMenu()
        { 
            int opcion;

            Console.WriteLine("╔════════════════════════════════════╗");
            Console.WriteLine("║           Menú Principal           ║");
            Console.WriteLine("╠════════════════════════════════════╣");
            Console.WriteLine("║ 0. Salir                           ║");
            Console.WriteLine("║ 1. Ejercicio 1                     ║");
            Console.WriteLine("║ 2. Ejercicio 2                     ║");
            Console.WriteLine("║ 3. Ejercicio 3                     ║");
            Console.WriteLine("║ 4. Ejercicio 4                     ║");
            Console.WriteLine("║ 5. Ejercicio 5                     ║");
            Console.WriteLine("╚════════════════════════════════════╝");
            Console.Write("Elija una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
    }








}
