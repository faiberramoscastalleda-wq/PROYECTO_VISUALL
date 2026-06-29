using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_1
{
    internal class Cofre_Dorado : cofres
    {
        public Cofre_Dorado()
        {

        }
        public override void abrirCofre(Personaje personaje)
        {
            if (!abierto)
            {
                if (personaje is ILlaveDorada)
                {
                    abierto = true;
                    Console.WriteLine(personaje.nombre + " abre el cofre dorado tu recompena es de 1000 monedas.");
                }
                else
                {
                    Console.WriteLine(personaje.nombre + " intenta abrir el cofre dorado ");
                }
            }
            else
            {
                Console.WriteLine(personaje.nombre + " el cofre ya estaba abierto ");
            }
        }

    }
}
