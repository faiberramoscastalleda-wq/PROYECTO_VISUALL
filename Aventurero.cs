using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_1
{
    internal class Aventurero:Personaje, ILlaveDorada
    {
        public Aventurero(string nombre) : base(nombre)
        {
        }
        public void abrirDorada()
        {
            Console.WriteLine("Abriendo cofre dorado...");
        }
        public override void abrirCofre(Personaje personaje)
        {
            if (personaje is ILlaveDorada)
            {
                Console.WriteLine( " ha abierto el cofre dorado.");
            }
            else
            {
                Console.WriteLine($"{Nombre} no tiene la llave dorada para abrir el cofre.");
            }
        }
    }
}
