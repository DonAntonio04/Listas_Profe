using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Lista_profe
{
    public class Nodo
    {
        private int _datos;
        private Nodo _Siguiente;
        public Nodo(int valor) 
        {
            _datos = valor;
            _Siguiente = null;
        }

        public Nodo(int valor, Nodo siguiente)
        {
            _datos = valor;
            _Siguiente = siguiente;
        }
        //public int Datos { get; }
        //public Nodo Siguiente { get; }

        public int getDatos()
        {
            return _datos;
        }
        public Nodo getSiguiente()
        {
            return _Siguiente;
        }
    }
}
