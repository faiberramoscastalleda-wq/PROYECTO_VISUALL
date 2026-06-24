using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_1
{
    internal class Personaje
    {
        public string nombre;
        public int vida;
        public int daño;

       public Personaje(string nombre, int vida, int daño)
        {
            this.nombre = nombre;
            this.vida = vida;
            this.daño = daño;
        }

        public virtual void atacar(Personaje objetivo)
        {
            if (vida >= 0)
            {
                objetivo.vida -= daño;
                Console.WriteLine(nombre + " ataco a " + objetivo.nombre + " con " + AtaqueRealizado() + " causando " + daño + " de daño.");
            }
        }
        public virtual string AtaqueRealizado()
        {
            return "";
        }
}
}
