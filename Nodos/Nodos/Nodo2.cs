using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nodos
{
    class Nodo2<T>
    {
        T contenido;

        Nodo2<T> padre;

        public Nodo2(T contenido, Nodo2<T> padre=null)
        {
            this.contenido = contenido;
            this.padre = padre;
        }


        public void VerNodo()
        {
            Console.WriteLine("Contenido: "+contenido);
            Console.WriteLine("Padre: "+padre);
        }

    }
}
