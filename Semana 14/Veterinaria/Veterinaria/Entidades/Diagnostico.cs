﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Entidades
{
    public class Diagnostico
    {
        public int id;
        public string descripcion;
        public DateTime fecha;
        public float precio;

        public Diagnostico(int id, string descripcion, DateTime fecha, float precio)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.fecha = fecha;
            this.precio = precio;

        }
    }
}
