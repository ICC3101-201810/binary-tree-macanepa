using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Nodo<int> nodo6 = new Nodo<int>(6);
            Nodo<int> nodo7 = new Nodo<int>(7);

            Nodo<int> nodo5 = new Nodo<int>(5, nodo6, nodo7);

            Nodo<int> nodo3 = new Nodo<int>(3, nodo5);

            Nodo<int> nodo4 = new Nodo<int>(4);

            Nodo<int> nodo2 = new Nodo<int>(2, nodo3, nodo4);

            Nodo<int> nodo1 = new Nodo<int>(1, nodo2);

        }
    }
}
