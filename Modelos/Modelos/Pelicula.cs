using System;
using System.Collections.Generic;
using System.Text;

namespace Modelos
{
    [Serializable]
    public class Pelicula
    {
        String nombre { get; set; }
        Persona director { get; set; }
        DateTime fechaDeEstreno { get; set; }
        String descripcion { get; set; }
        Double presupuesto { get; set; }
        Estudio estudio { get; set; }

        public Pelicula(String nombre, Persona director, DateTime fechaDeEstreno, String descripcion, Double presupuesto, Estudio estudio)
        {
            this.nombre = nombre;
            this.director = director;
            this.fechaDeEstreno = fechaDeEstreno;
            this.descripcion = descripcion;
            this.presupuesto = presupuesto;
            this.estudio = estudio;
        }
    }
}
