using System;
using System.Collections.Generic;
using System.Text;

namespace Modelos
{
    [Serializable]
    public class Estudio
    {
        String nombre { get; set; }
        String direccion { get; set; }
        DateTime fechaDeApertura { get; set; }

        public Estudio(String nombre, String direccion, DateTime fechaDeApertura)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.fechaDeApertura = fechaDeApertura;
        }
    }
}
