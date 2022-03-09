using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BasicConcepts
{
    public class DispositivoFactory
    {
        public enum TipoDispositivo { PC, Consola }

        public static IDispoistivo CreateDispositivo(string tipo)
        {
            IDispoistivo dispositivo;

            switch (tipo)
            {
                case "PC":
                    dispositivo = new PC("Razer 9 5800, GTX 3070");
                    break;
                default:
                    dispositivo = new Consola("PS5");
                    break;
            }

            return dispositivo;
        }

    }
}
