using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_1
{
    internal class Cofre_Legendario : cofres
    { 
        public override void abrirCofre(IAbrible cofre)
        {
            if (abierto)
            {
                cofre.abrir();
                Console.WriteLine("El cofre legendario se ha abierto tu recompena es un objeto legendario en este caso una solicitud de empleo.");
            }
            else
            {
                Console.WriteLine("El cofre está cerrado y no se puede abrir.");
            }
        }   
    }
}
