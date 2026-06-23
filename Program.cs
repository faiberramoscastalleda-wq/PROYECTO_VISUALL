using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Guerrerocs g1 = new Guerrerocs("guerrero", 200, 50);
            Mago m1 = new Mago("mago", 100, 75);
            Sacerdote s1 = new Sacerdote("sacerdote", 150, 40);



            g1.atacar(m1);
            m1.atacar(g1);
        }

         
    }
}


