using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaGeometrica
{
    abstract public class Poligono : Forma
    {
       private int numeroLados;

        protected Poligono(String nombre ,int numeroLados): base(nombre)
        {
            this.numeroLados = numeroLados;
        }

        public int NumeroLados { get => numeroLados; set => numeroLados = value; }
    }
}
