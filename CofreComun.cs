using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_1
{
    internal class CofreComun : cofres
    {
        public override void abrirCofre(Personaje personaje )
        {
            if (!abierto)
            {
                abierto = true;
                Console.WriteLine(personaje.nombre + " intenta abrir el cofre comun ");
            }
            else
            {
                Console.WriteLine(personaje.nombre + " El cofre ya estaba abrierto.");
            }

        }
    }
}
