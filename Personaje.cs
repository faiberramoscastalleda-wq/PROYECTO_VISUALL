using System;
namespace proyecto_1
{
    internal class Personaje
    {
        protected string nombre;
        protected bool tieneLaLlave;
        protected string Llave;
        public Personaje(string nombre)
        {
            this.nombre = nombre;
            this.tieneLaLlave = false;
           

        }
        public virtual void abrirCofre(Personaje personaje)
        {
            if (tieneLaLlave)
            {
                cofre.abrir();            }
            else
            {
                Console.WriteLine("No tienes la llave para abrir el cofre.");
            }
        }
        public void abrir()
        {
        }
}
}