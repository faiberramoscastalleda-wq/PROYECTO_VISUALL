using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_1
{
    internal class cofres:IAbrible
    {
        protected bool abierto;

        public void abrir()
        {
            abierto = false;
        }
        public virtual void abrirCofre(IAbrible cofre)
        {
            if (abierto)
            {
                cofre.abrir();
            }
            else
            {
                Console.WriteLine("El cofre está cerrado y no se puede abrir.");
            }
        }
    }
}
