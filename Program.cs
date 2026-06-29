using System;

namespace proyecto_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mago m1 = new Mago("magazo");
            Aventurero a1 = new Aventurero("aventurerazo");
            Ladron l1 = new Ladron("abelardo");

            CofreComun c1 = new CofreComun();
            Cofre_Dorado d1 = new Cofre_Dorado();
            Cofre_Legendario lg1 = new Cofre_Legendario();

            c1.abrirCofre(m1);
            d1.abrirCofre(m1);
            d1.abrirCofre(a1);
            lg1.abrirCofre(l1);
            lg1.abrirCofre(a1);
            c1.abrirCofre(m1);
            lg1.abrirCofre(l1);

            Console.ReadLine();
        }
    }
}