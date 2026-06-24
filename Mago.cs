using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_1
{
    internal class Mago:Personaje, ICurable
    {
        public void curar()
        {   
        }
        public Mago(string nombre, int vida, int daño) : base(nombre, vida, daño)
        {
        }
        public void curar(Personaje personaje, int curacion)
        {
            if (curacion > 0)
            {
                Console.WriteLine(nombre + " se ha curado " + curacion + " puntos de vida.");
                return;
            }
            vida += curacion;
        }
        public override string AtaqueRealizado()
        {
            return "bola de fuego";
        }
    }
}
