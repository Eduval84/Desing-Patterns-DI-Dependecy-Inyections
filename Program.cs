using System;

namespace BasicConcepts
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Jugador jugador = new Jugador("Edu", new PC("Razer 9 5800, GTX 3070"));
            jugador.jugar();
        }
    }
}
