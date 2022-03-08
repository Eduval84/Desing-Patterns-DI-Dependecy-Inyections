using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConcepts
{
    public class Consola
    {
        private string modelo;

        public Consola(string modelo)
        {
            this.modelo = modelo;
        }

        public String GetModelo()
        {
            return this.modelo;
        }

        public void jugar() => Console.WriteLine($"Estas jugando a la consola: {modelo}");
    }
}
