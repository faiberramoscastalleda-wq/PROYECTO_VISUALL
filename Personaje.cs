using System;
namespace proyecto_1
{
    internal class Personaje
    {
        public string nombre;
        protected bool tieneLaLlave;
        protected string Llave;

        protected string Nombre { get => nombre; set => nombre = value; }

        public Personaje(string nombre)
        {
            this.nombre = nombre;
            this.tieneLaLlave = false;
           

        }
        public virtual void abrirCofre(Personaje personaje)
        {
          
        }
        public void abrir()
        {
        }
}
}