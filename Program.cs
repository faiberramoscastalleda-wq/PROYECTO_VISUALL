using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_1
{
    internal class Program
    {
        public string Nombre;

        static void Main(string[] args)
        {
            List<Personaje> personajes = new List<Personaje>()
            {
                 new Princesa("Princesa"),
                 new Minero("Minero"),
                 new Caballero("Caballero")
            };



            Bola_De_Fuego f1 = new Bola_De_Fuego();
            Bola_De_Hielo b1 = new Bola_De_Hielo();

            foreach (var item in personajes)
            {
                if (item is ICongelable congelable)
                {
                    b1.congelar(congelable);
                }
                if (item is IQuemable quemable)
                {
                    f1.quemar(quemable);
                }
            }
        }
    }
}

