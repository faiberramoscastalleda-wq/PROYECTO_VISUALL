using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_1
{
    internal class Cofre_Dorado: cofres
    {
      public Cofre_Dorado()
        {

        }
      public override void abrirCofre(IAbrible cofre)
        {
            if (abierto)
            {
                cofre.abrir();
                Console.WriteLine("El cofre dorado se ha abierto correctamente tu recompena es de 1000 monedas.");
            }
            else
            {
                Console.WriteLine("El cofre está cerrado y no se puede abrir.");
            }
        }

    }
}
