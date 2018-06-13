using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Modelos
{
    [Serializable]
    public class Critica
    {
        public String emisor { get; set; }
        public String mensaje { get; set; }
        public Pelicula pelicula { get; set; }
        public static int count = 0;
        public int id { get; }

        public Critica(String emisor, String mensaje, Pelicula pelicula)
        {
            this.emisor = emisor;
            this.mensaje = mensaje;
            this.pelicula = pelicula;
            this.id = Interlocked.Increment(ref count);
        }

        public override string ToString()
        {
            return emisor + ": " + mensaje;
        }

    }
}
