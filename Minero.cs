using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_1
{
    internal class Minero : Personaje, IQuemable
    {
        public void quemar()
        {
            Console.WriteLine(Nombre + " se quemo el nene ");
        }

        public Minero(string Nombre) : base(Nombre)
        {
        }
    }
}
