using System;
using System.Collections.Generic;
using System.Text;

namespace Modelos
{
    [Serializable]
    public class Persona
    {
        String nombre { get; set; }
        String apellido { get; set; }
        DateTime fechaDeNacimiento { get; set; }
        String biografia { get; set; }
        String ocupacion { get; set; }

        public Persona(String nombre, String apellido, DateTime fechadeNacimiento, String biografia, String ocupacion)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.biografia = biografia;
            this.ocupacion = ocupacion;
        }
    }
}
