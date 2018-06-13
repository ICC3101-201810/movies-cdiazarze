using System;
using System.Collections.Generic;
using System.Text;

namespace Modelos
{
    [Serializable]
    public class PeliculaProductor
    {
        public Pelicula pelicula { get; set; }
        public Persona productor { get; set; }

        public PeliculaProductor(Pelicula pelicula, Persona productor)
        {
            this.pelicula = pelicula;
            this.productor = productor;
        }
    }
}

