using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Modelos
{
    [Serializable]
    public class Estudio
    {
        public String nombre { get; set; }
        public String direccion { get; set; }
        public DateTime fechaDeApertura { get; set; }
        public static int count = 0;
        public int id { get; }

        public Estudio(String nombre, String direccion, DateTime fechaDeApertura)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.fechaDeApertura = fechaDeApertura;
            this.id = Interlocked.Increment(ref count);
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
