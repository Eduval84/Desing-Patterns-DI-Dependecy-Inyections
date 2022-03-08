using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConcepts
{
    public class Jugador
    {
        private string Nombre;
        private PC pc;

        public Jugador(string nombre)
        {
            Nombre = nombre;
            pc = new PC("Razer 9 5800, GTX 3070");
        }

        public void jugar()
        {
            pc.jugar();
        }
    }
}
