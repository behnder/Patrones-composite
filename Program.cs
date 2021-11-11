using System;

namespace Patrones_Composite
{
    class Program
    {
        static void Main(string[] args)
        {

            Caja caja = new Caja("Caja 1");
            Caja caja2 = new Caja("Caja 2");
            Caja caja3 = new Caja("Caja 3");

            caja.AgregarSubItem(new Item("pañuelo",45));
            caja.AgregarSubItem(new Item("bolsa",89));
            caja.AgregarSubItem(new Item("celular",1000));
            caja.AgregarSubItem(new Item("canilla",450));
            caja.AgregarSubItem(caja2);
            caja.AgregarSubItem(caja3);
            caja2.AgregarSubItem(new Item("chocolates",300));
            caja2.AgregarSubItem(new Item("servilletas",200));
            caja2.AgregarSubItem(new Item("cafe",210));
            caja3.AgregarSubItem(new Item("Cables", 90));
            caja3.AgregarSubItem(new Item("Monitor", 2000));
            caja3.AgregarSubItem(new Item("Fuente", 1550));

           



            Console.WriteLine(caja.Precio);
            Console.WriteLine(caja2.Precio);
            Console.WriteLine(caja3.Precio);

            Console.ReadKey();

        }
    }
}
