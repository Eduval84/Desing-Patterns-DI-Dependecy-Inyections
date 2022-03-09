using System;

namespace BasicConcepts
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Jugador jugador = new Jugador("Edu", DispositivoFactory.CreateDispositivo("PC"));
            jugador.jugar();

            Jugador jugador2 = new Jugador("Edu consolero", DispositivoFactory.CreateDispositivo("PS5"));
            jugador2.jugar();
        }
    }
}
