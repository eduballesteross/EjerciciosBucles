using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosBucles.Servicios
{
    internal class OperativaImplemetacion : OperativaInterfaz
    {
        public void calculoEjercicio1(int seleccionEjercicio1)
        {
            int suma;
            suma = 0;

            for (int i = 0; i <= seleccionEjercicio1; i++)
            {
                suma = +i;
            }

            Console.WriteLine("La suma de 1 hasta " + seleccionEjercicio1 + " es: " + suma);

        }

        public void calculoEjercicio2(double numeroDouble, int numeroEntero)
        {
            double resultado = 1.0;


            Console.WriteLine(numeroDouble);
            Console.WriteLine(numeroEntero);

            for (int i = 0; i <= numeroEntero; i++)
            {

                resultado *= numeroDouble;
                Console.WriteLine(i);   
            }

            Console.WriteLine("El resultado de " + numeroDouble + " ^ " + numeroEntero + " es: " + resultado);


        }


    }

}