using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Composite
{
    class Item : IInventario
    {
        public string Nombre { get; set; }
        public int Precio { get; set; }

        public Item(string nombre, int precio)
        {
            Nombre = nombre;
            Precio = precio;
        }

        public void ImprimirNombre()
        {
            Console.WriteLine("El nombre del item es " + Nombre);
        }
    }
}
