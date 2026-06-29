using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_1
{
    internal class Cofre_Legendario : cofres
    { 
        public override void abrirCofre(Personaje personaje)
        {
            if (!abierto)
            {
                if (personaje is ILlaveLegendaria)
                {
                    abierto = true;
                    Console.WriteLine(personaje.nombre + " abre el cofre legendario tu recompena es un objeto legendario en este caso una solicitud de empleo.");
                }
                else
                {
                    Console.WriteLine(personaje.nombre + " intenta abrir el cofre legendario ");
                }
            }
            else
            {
                Console.WriteLine(personaje.nombre + " el cofre ya estaba abierto ");
            }
        }   
    }
}
