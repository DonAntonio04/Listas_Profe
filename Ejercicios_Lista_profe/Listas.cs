using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Lista_profe
{
  //  Lista Enlazada simple
    public class Listas
    {
        Nodo primero;
        Nodo ultimo;

        //con esto tenemos una lista vacia
        public Listas()
        {
            primero = ultimo = null;
        }

        public bool ListaVacia()
        {
            if (primero == null)
            {
                return true;
            }
            return false;

            // return primero == null ? true : false;  <--Esto es lo mismo pero en una sola linea
        }

        public int LongitudLista()
        {
            int contador = 0;
            if (ListaVacia())
            {
                return contador;
            }
            else
            {
                if (primero != null && primero.getSiguiente() != null)
                {
                    return (contador + 1);
                }
                else
                {
                    Nodo actual = primero;
                    while (actual.getSiguiente != null)
                    {
                        contador++;
                        actual = actual.getSiguiente();
                    }
                    return contador + 1;
                }
            }
        }

        public void ImprimirLista()
        {
            if (ListaVacia())
            {
                Console.WriteLine("Lista Vacia");
            }
            else
            {
                Nodo actual = primero;
                Console.WriteLine(primero.getDatos());
                while (actual.getSiguiente != null)
                {
                    Console.WriteLine($"Los datos son {actual.getDatos()}");
                    actual = actual.getSiguiente();
                }
                Console.WriteLine("--> null");

            }
        }

        public void BuscarNumero(int num)
        {
            bool encontrado = false;
            if (ListaVacia())
            {
                Console.WriteLine("El numero solicitado no se encuentra");
            }
            else
            {
                Nodo actual = primero;
                while (actual != null)
                {
                    if (actual.getDatos() == num)
                    {
                        Console.WriteLine("Si se encuentra el elemento deseado");
                        encontrado = true;
                    }
                    else
                    {
                        actual = actual.getSiguiente();
                    }
                }
                if (!encontrado)
                {
                    Console.WriteLine("No se encuentra");
                }
            }
        }

        public int ObtenerPosicion(int elemento)
        {
            int posicion = 0;
            bool encontrado = false;

            if (ListaVacia())
            {
                Console.WriteLine("La lista está vacía");
            }
            else
            {
                Nodo actual = primero;

                while (actual != null) // recorrer los nodos de la lista
                {
                    if (actual.getDatos() == elemento) //  nodo actual es igual al elemento buscado
                    {
                        encontrado = true;
                        break;
                    }
                    else
                    {
                        actual = actual.getSiguiente(); // pasamos al siguiente nodo
                        posicion++;
                    }
                }

                if (encontrado) // si se encuentra el elemento 
                {
                    return posicion; //devuelvo la poicion
                }
                else
                {
                    Console.WriteLine("El elemento no se encuentra en la lista");
                }
            }

            return -1;
        }

        public void InsertarElemento()
        {
            Console.WriteLine("Ingrese el nuevo elemento:");
            int nuevoDato = int.Parse(Console.ReadLine());

            Nodo nuevoNodo = new Nodo(nuevoDato); // creo un nuevo nodo

            if (ListaVacia())
            {
                primero = nuevoNodo;
            }
            else
            {
                Nodo actual = primero;

                while (actual.getSiguiente() != null)
                {
                    actual = actual.getSiguiente(); // mover el último nodo de la lista
                }


            }

            Console.WriteLine("Elemento insertado correctamente.");
        }
        public void InsertarElementoFinal()
        {
            Console.WriteLine("Ingrese el nuevo elemento:");
            int nuevoDato = int.Parse(Console.ReadLine());

            Nodo nuevoNodo = new Nodo(nuevoDato); // creo un nuevo nodo

            if (ListaVacia())
            {
                primero = nuevoNodo;
                ultimo = nuevoNodo; // Cuando la lista está vacía, el nuevo nodo es tanto el primero como el último
            }
            else
            {
                // En lugar de usar setSiguiente, asignamos directamente el siguiente nodo
                ultimo = nuevoNodo;

                // El nuevo nodo ahora es el último nodo de la lista
            }

            Console.WriteLine("Elemento insertado correctamente.");
        }




    }
}




