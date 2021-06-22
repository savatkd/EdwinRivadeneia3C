using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace EdwinRivadeneira3C
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack miPila = new Stack();
            int opcion; //opcion del menu 
            do
            {
                Console.Clear();    //Se limpia la consola
                opcion = menu();    //Se muestra el menu y espera la opción
                switch (opcion)
                {
                    case 1:
                        agregar(ref miPila);
                        break;
                    case 2:
                        eliminar(ref miPila);
                        break;
                    case 3:
                        limpiar(ref miPila);
                        break;
                    case 4:
                        imprimir(miPila);
                        break;
                    case 5: break; //salir
                    default:
                        mensaje("ERROR: la opción no es valida. Intente de nuevo.");
                        break;
                }
            }
            while (opcion != 5);
            mensaje("El programa a finalizado.");
        }

        /* Se añade un nuevo elemento a la pila */
        static void agregar(ref Stack pila)
        {
            Console.Write("\nIngresar el valor: ");
            try
            {
                int valor = Convert.ToInt32(Console.ReadLine());
                if (valor > 99 || valor <= 0)
                {
                    mensaje("Solo números del 1 al 99");
                }
                else
                {
                    pila.Push(valor);
                    imprimir(pila);
                }
            }
            catch
            {
                mensaje("Error: Solo números del 1 al 99");
            }
        }

        /* Elimina todo los elementos que se encuentran en la pila */
        static void limpiar(ref Stack pila)
        {
            pila.Clear();
            imprimir(pila);
        }

        /* Elimina elemento de la pila */
        static void eliminar(ref Stack pila)
        {
            if (pila.Count > 0)
            {
                int valor = (int)pila.Pop();
                mensaje("Elemento " + valor + " eliminado");
            }
            else
            {
                imprimir(pila);
            }
        }

        /* Se muestra el menu y retorna la opción */
        static int menu()
        {
            //Console.Clear();
            Console.WriteLine("\n       Stack Menu\n");
            Console.WriteLine(" 1.- Agregar elementos");
            Console.WriteLine(" 2.- Eliminar elementos");
            Console.WriteLine(" 3.- Vaciar Pila");
            Console.WriteLine(" 4.- Ver pila");
            Console.WriteLine(" 5.- Finalizar el sistema");
            Console.Write("=> digita una opción de los intens: ");
            try
            {
                int valor = Convert.ToInt32(Console.ReadLine());
                return valor;
            }
            catch
            {
                return 0;
            }
        }

        /* Muestra mensaje del programa al usuario */
        static void mensaje(String texto)
        {
            if (texto.Length > 0)
            {
                Console.WriteLine("\n  =========================================================");
                Console.WriteLine(" => {0}", texto);
                Console.WriteLine(" =======================================================");
                Console.WriteLine("\n Presione cualquier tecla para continuar con el sistema");
                Console.ReadKey();
            }
        }

        /* Imprime la pila */
        static void imprimir(Stack pila)
        {
            if (pila.Count > 0)
            {
                Console.WriteLine("");
                foreach (int dato in pila)
                {
                    Console.WriteLine(" |  |  |");
                    if (dato < 10)
                        Console.WriteLine(" | 0{0}  |", dato);
                    else
                        Console.WriteLine(" | {0}  |", dato);
                    Console.WriteLine(" |_|_|");
                }
                Console.WriteLine("\nPresione cualquier tecla para continuar con el sistema");
                Console.ReadKey();
            }
            else
            {
                mensaje("La Pila se encuentra vacia");
            }
        }
    }
}