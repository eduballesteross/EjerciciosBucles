using EjerciciosBucles.Servicios;

namespace EjercicioBucles
{

    /// <summary>
    /// Clase principal de las aplicacións
    /// 2910223-ebp
    /// </summary>

    internal class Program
    {

        /// <summary>
        /// Método principal de la aplicación
        /// </summary>
        /// <param name="args"></param>

        public static void Main(string[] args)
        {
            
            PeticionesInterfaz pI = new PeticionesImplementacion();
            OperativaInterfaz oI = new OperativaImplemetacion();

            int opcion;
            bool cerrarMenu= false;


            while (!cerrarMenu) 
            {

                opcion = pI.SeleccionarYMostrarMenu();

                switch(opcion) 
                {
                    case 0:
                        cerrarMenu = true;  
                        break;
                    case 1:
                        Console.Clear();

                        int suma;
                        int seleccionEjercicio1;

                        Console.WriteLine("Has seleccionado el ejercicio 1");
                        seleccionEjercicio1 = pI.peticionEjercicio1();
                        oI.calculoEjercicio1(seleccionEjercicio1);

                        break;

                    case 2:
                        Console.Clear();
                        double numeroDouble;
                        int numeroEntero;

                        Console.WriteLine("Has seleccionado el ejercicio 2");
                        numeroDouble = pI.peticionEjercicio2Double();
                        numeroEntero = pI.peticionEjercicio2Entero();
                        oI.calculoEjercicio2(numeroDouble,numeroEntero);
                       
                     
                        break;

                    case 3:
                        int seleccionEjercicio3;

                        seleccionEjercicio3 = pI.peticionEjercicio1();

                        oI.calculoEjercicio3(seleccionEjercicio3);
                        break;
                        
                    case 4:
                        int seleccionEjercicio4;

                        seleccionEjercicio4 = pI.peticionEjercicio2Entero();

                        oI.calculoEjercicio4(seleccionEjercicio4);


                        break;

                    case 5:
                        break;

                    default:
                        Console.WriteLine("Opcion incorrecta");
                        break;
                }

            }



        }

    }
}