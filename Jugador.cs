using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConcepts
{
    public class Jugador  
    {
        private string Nombre;
        private IDispoistivo dispoistivoJugable;

        public Jugador(string nombre, IDispoistivo dispositivo)
        {
            Nombre = nombre;
            dispoistivoJugable = dispositivo;
        }

        public void jugar()
        {
            dispoistivoJugable.jugar();
        }
    }
}
