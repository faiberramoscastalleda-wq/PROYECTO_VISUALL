using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_1
{
    internal class CofreComun : cofres
    {
        public override void abrirCofre(IAbrible cofre)
        {
            if (abierto)
            {
                cofre.abrir();
                Console.WriteLine("El cofre comun se ha abierto correctamente tu recompensa es de 100 monedas.");
            }
            else
            {
                Console.WriteLine("El cofre ya estaba abrierto.");
            }

        }
    }
}
