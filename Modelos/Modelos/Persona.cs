﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Modelos
{
    [Serializable]
    public class Persona
    {
        public String nombre { get; set; }
        public String apellido { get; set; }
        public DateTime fechaDeNacimiento { get; set; }
        public String biografia { get; set; }
        public String ocupacion { get; set; }

        public Persona(String nombre, String apellido, DateTime fechaDeNacimiento, String biografia, String ocupacion)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.biografia = biografia;
            this.ocupacion = ocupacion;
        }

        int maxLength()
        {
            if (biografia.Length > 20)
                return 20;
            else
                return biografia.Length;
        }

        public override string ToString()
        {
            return nombre + " " + apellido + ", DATOS | Fecha de Nacimiento: " + fechaDeNacimiento.ToShortDateString() + " | Ocupacion: " + ocupacion + " | Biografia: " + biografia.Substring(0,maxLength()) + "... |";
        }

    }
}
