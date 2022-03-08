using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConcepts
{
    public class Jugador
    {
        private string Nombre;
        private Consola consola;

        public Jugador(string nombre)
        {
            Nombre = nombre;
            consola = new Consola("PS5");
        }

        public void jugar()
        {
            consola.jugar();
        }
    }
}
