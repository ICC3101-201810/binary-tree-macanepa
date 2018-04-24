using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nodos
{
    class Nodo<T>
    {
        T contenido;

        Nodo<T> hijo1;
        Nodo<T> hijo2;

        public Nodo(T contenido)
        {
            this.contenido = contenido;
        }

        public Nodo(T contenido, Nodo<T> hijo1)
        {
            this.contenido = contenido;
            this.hijo1 = hijo1;
        }

        public Nodo(T contenido, Nodo<T> hijo1, Nodo<T> hijo2)
        {
            this.contenido = contenido;
            this.hijo1 = hijo1;
            this.hijo2 = hijo2;
        }




    }
}
