using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConcepts
{
    public class Jugador  
    {
        private string Nombre;
        private IDispoistivo dispoistivo;

        public Jugador(string nombre)
        {
            Nombre = nombre;
            dispoistivo = new PC("Razer 9 5800, GTX 3070");
        }

        public void jugar()
        {
            dispoistivo.jugar();
        }
    }
}
