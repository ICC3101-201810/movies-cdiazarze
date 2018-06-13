using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Modelos
{
    [Serializable]
    public class Pelicula
    {
        public String nombre { get; set; }
        public Persona director { get; set; }
        public DateTime fechaDeEstreno { get; set; }
        public String descripcion { get; set; }
        public Double presupuesto { get; set; }
        public Estudio estudio { get; set; }
        public static int count = 0;
        public int id { get; }

        public Pelicula(String nombre, Persona director, DateTime fechaDeEstreno, String descripcion, Double presupuesto, Estudio estudio)
        {
            this.nombre = nombre;
            this.director = director;
            this.fechaDeEstreno = fechaDeEstreno;
            this.descripcion = descripcion;
            this.presupuesto = presupuesto;
            this.estudio = estudio;
            this.id = Interlocked.Increment(ref count);
        }

        int maxLength()
        {
            if (descripcion.Length > 30)
                return 30;
            else
                return descripcion.Length;
        }

        public override string ToString()
        {
            return nombre + ", DATOS | Director: " + director.nombre+" "+ director.apellido + " | Fecha de Estreno: " + fechaDeEstreno.ToShortDateString()+ " | Descripcion: " + descripcion.Substring(0, maxLength()) + "... | Presupuesto: " + presupuesto+ " | Estudio: " + estudio.nombre;
        }
    }
}
