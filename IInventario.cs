using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Composite
{
    interface IInventario
    {
        public string Nombre { get; set; }
        public int Precio { get; set; }
        void ImprimirNombre();


    }
}
