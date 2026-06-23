using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_1
{
    internal class Sacerdote:Personaje
    {
        int Daño;
        int Vida;
        string Nombre;

        public Sacerdote(string nombre, int vida, int daño) : base(nombre, vida, daño)
        {
        }
        public override string AtaqueRealizado()
        {
           return "rayo de luz";
        }
    }
}
