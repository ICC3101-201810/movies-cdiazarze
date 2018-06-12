using System;
using System.Collections.Generic;
using System.Text;

namespace Modelos
{
    [Serializable]
    public class PeliculaProductor
    {
        Pelicula pelicula { get; set; }
        Persona productor { get; set; }

        public PeliculaProductor(Pelicula pelicula, Persona productor)
        {
            this.pelicula = pelicula;
            this.productor = productor;
        }
    }
}

