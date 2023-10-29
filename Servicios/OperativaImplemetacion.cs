using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosBucles.Servicios
{
    internal class OperativaImplemetacion : OperativaInterfaz
    {
        public int calculoEjercicio1(int seleccionEjercicio1)
        {
            int suma;
            for (int i = 0; i <= seleccionEjercicio1; i++) 
            {
                suma =+ i;
                Console.WriteLine("La suma de 1 hasta " + seleccionEjercicio1 + " es: " + suma);
                return suma;
            }
        }
        }
    }
}
