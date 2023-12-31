﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaGeometrica
{
    abstract public class Forma
    {
        private String nombre;

        public string Nombre { get => nombre; set => nombre = value; }

        public Forma(String nombre)
        { 
            this.Nombre = nombre;
        }

        public Forma()
        {
            this.Nombre = null;
        }
     
        public abstract Double GetArea();

        public abstract Double GetPerimetro();
    }

}
