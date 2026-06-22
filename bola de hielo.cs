using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_1
{
    internal class Bola_De_Hielo
    {
        public void congelar(ICongelable objetivo)
        {
            objetivo.congelar();
        }
    }
}
