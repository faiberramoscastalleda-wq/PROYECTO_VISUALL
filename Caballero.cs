using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_1
{
    internal class Caballero : Personaje, ICongelable , IQuemable
    {

        public void quemar()
        {
            Console.WriteLine(Nombre + " se quemo el nene ");
        }
        public void congelar()
        {
            Console.WriteLine(Nombre + " le dio frio al nene ");
        }
        public Caballero(string Nombre) : base(Nombre)
        {
        }
    }
}
