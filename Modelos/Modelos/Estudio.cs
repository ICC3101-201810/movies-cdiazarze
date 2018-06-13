using System;
using System.Collections.Generic;
using System.Text;

namespace Modelos
{
    [Serializable]
    public class Estudio
    {
        public String nombre { get; set; }
        public String direccion { get; set; }
        public DateTime fechaDeApertura { get; set; }

        public Estudio(String nombre, String direccion, DateTime fechaDeApertura)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.fechaDeApertura = fechaDeApertura;
        }

        int maxLength()
        {
            if (direccion.Length > 20)
                return 20;
            else
                return direccion.Length;
        }

        public override string ToString()
        {
            return nombre + ", DATOS | Fecha de Apertura: " + fechaDeApertura.ToShortDateString()+ " | Direccion: " + direccion.Substring(0, maxLength()) + "... |";
        }

    }
}
