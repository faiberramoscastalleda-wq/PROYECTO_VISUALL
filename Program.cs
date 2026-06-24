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
            s1.curar(g1,30);
            g1.atacar(m1);
            g1.atacar(s1);
            s1.atacar(g1);
            g1.atacar(m1);
            m1.atacar(g1);
            s1.curar(s1, 50);

            Console.ReadLine();
            Console.WriteLine("///DATOS FINALES///");
            Console.WriteLine("mago: " + m1.nombre + " vida: " + m1.vida);
            Console.WriteLine("guerrero: " + g1.nombre + " vida: " + g1.vida);
            Console.WriteLine("sacerdote: " + s1.nombre + " vida: " + s1.vida);
        }
    }
}


