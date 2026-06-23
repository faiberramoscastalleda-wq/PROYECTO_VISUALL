using System;
using System.Collections.Generic;
using System.Linq;
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
        public override string AtaqueRealizado()
        {
            return "bola de fuego";
        }
    }
}
