using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_1
{
    internal class Guerrerocs:Personaje,ICurable
    {
        public void curar()
        {
        }
        public Guerrerocs(string nombre, int vida, int daño) : base(nombre,vida,daño)
        {
        }
        public void curar(ICurable nombre)
        {
           nombre.curar();
        }
        public override string AtaqueRealizado()
        {
            return "espadazo";
        }
    }
}
