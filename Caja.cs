using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Composite
{
    class Caja : IInventario
    {
        public string Nombre { get; set; }
        public List<IInventario> Listado = new List<IInventario>();
        public int Precio
        {
            get
            {
                int precioTotal = 0;
                foreach (var item in Listado)
                {
                    precioTotal += item.Precio;

                }
                return precioTotal;
            }

            set { }
        }

      

        public Caja(string nombreDeLaCaja)
        {
            Nombre = nombreDeLaCaja;
        
        }

        public void ImprimirNombre()
        {
            Console.WriteLine("El nombre de la caja es " + Nombre);
        }
        public void AgregarSubItem(IInventario item)
        {
            Listado.Add(item);
        }
        public void QuitarSubitem(IInventario item)
        {
            Listado.Remove(item);
        }

        public IInventario ObtenerSubitem(int index)
        {
            return Listado[index];
        }


    }
}
