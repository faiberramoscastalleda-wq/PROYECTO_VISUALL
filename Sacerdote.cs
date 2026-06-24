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
        public void curar(Personaje personaje, int curacion)
        {
            if (curacion > 0)
            {
                Console.WriteLine(nombre + " tiene prohibido curarse ");
                return;
            }
            personaje.vida += curacion;
            Console.WriteLine(nombre + " ha curado a " + personaje.nombre + " por " + curacion + " puntos de vida.");
        }
        public void Curar(ICurable objetivo, int curacion)
        {
            objetivo.Curar(curacion);
        }
    }
}
