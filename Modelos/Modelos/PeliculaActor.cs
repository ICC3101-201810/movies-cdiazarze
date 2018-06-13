using System;
using System.Collections.Generic;
using System.Text;

namespace Modelos
{
    [Serializable]
    public class PeliculaActor
    {
        public Pelicula pelicula { get; set; }
        public Persona actor { get; set; }

        public PeliculaActor(Pelicula pelicula, Persona actor)
        {
            this.pelicula = pelicula;
            this.actor = actor;
        }
    }
}
