using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaGeometrica
{
    public class Circulo: Forma
    {
        double radio;
 
        public Circulo (double radio ) :base("Circulo")
        {
            this.radio = radio;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(this.radio, 2);
        }

        public override double GetPerimetro()
        {
            return 2* Math.PI * radio;
        }
    }
}
