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

        public Nodo(T contenido)
        {
            this.contenido = contenido;
        }
    }
}
