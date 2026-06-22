using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_1
{
    internal class Princesa : Personaje, ICongelable
    {
        public void congelar()
        {
            Console.WriteLine(Nombre + " le dio frio a la nena ");
        }
        public Princesa(string Nombre) : base(Nombre)
        {
        }
    }
}
