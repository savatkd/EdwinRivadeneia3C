using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdwinRivadeneira3C
{
    class Program
    {

        static void Main(string[] args)
        {
            cola c = new cola();
            c.encolar();
            c.encolar();
            c.encolar();
            c.encolar();
            c.encolar();
            Console.WriteLine("\n Cola ingresada\n");
            c.DesplegarCola();
            Console.ReadLine();

        }
    }
    //ESTA ES LA ESTRUCTURA DEL NODO
    //de modo que siempre la usaremos asi
    class Nodo
    {

        private int dato;
        private Nodo siguiente;

        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        public Nodo Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
    }
    class cola
    {
        //instanciamos el nodo ,NO LA COLA 
        //de esta forma hemos llamado al nodo
        private Nodo Primero = new Nodo();
        private Nodo Ultimo = new Nodo();

        //vamos a inicializar la cola utilizando null
        public cola()
        {
            Primero = null;
            Ultimo = null;
        }
        //realizar el metodo para encolar
        public void encolar()
        {
            //insertar un nuevo nodo en la cola
            Nodo nuevo = new Nodo();
            Console.WriteLine("ingrese el dato que contendra el nuevo nodo");
            nuevo.Dato = int.Parse(Console.ReadLine());

            if (Primero == null)
            {
                Primero = nuevo;
                Primero.Siguiente = null;
                Ultimo = nuevo;
            }
            else
            {
                Ultimo.Siguiente = nuevo;
                nuevo.Siguiente = null;
                Ultimo = nuevo;

            }
            Console.WriteLine("nodo ingresa correctamente");

        }
        //metodo para imprimir la cola respectiva
        public void DesplegarCola()
        {
            //vamos a crear un nodo que recorra toda la cola para que
            //pueda imprimir los elementos
            Nodo actual = new Nodo();
            actual = Primero;
            if (Primero != null)
            {

                while (actual != null)
                {

                    Console.WriteLine(" " + actual.Dato);
                    actual = actual.Siguiente;//la linea recorrera todo


                }
                //quiere decir que la cola si esta llena

            }
            else
            {
                Console.WriteLine("LA COLA ESTA VACIA");
            }


        }

    }

}