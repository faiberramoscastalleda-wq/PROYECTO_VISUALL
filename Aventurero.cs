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
            
        }
    }
}
