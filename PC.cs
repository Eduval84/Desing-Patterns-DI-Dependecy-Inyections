using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConcepts
{
    public class PC
    {
        private string modelo;

        public PC(string modelo)
        {
            this.modelo = modelo;
        }

        public String GetModelo()
        {
            return this.modelo;
        }

        public void jugar() => Console.WriteLine($"Estas jugando al PC: {modelo}");
    }
}
