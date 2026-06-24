using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_1
{
    internal class Guerrerocs:Personaje,ICurable
    {
        public void Curar(int curacion)
        {
            vida += curacion;
            Console.WriteLine(nombre + " se ha curado " + curacion + " puntos de vida.");
        }
        public Guerrerocs(string nombre, int vida, int daño) : base(nombre,vida,daño)
        {
        }
        public override string AtaqueRealizado()
        {
            return "espadazo";
        }
    }
}
