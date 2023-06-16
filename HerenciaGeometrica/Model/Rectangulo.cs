using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaGeometrica
{
    public class Rectangulo : Poligono
    {
        double lado1;
        double lado2;

        public double Lado1 { get => lado1; set => lado1 = value; }
        public double Lado2 { get => lado2; set => lado2 = value; }

        public Rectangulo(double lado1, double lado2): base ("Rectangulo", 4)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
        }

        public override double GetArea()
        {
         return Lado1 * Lado2;
        }

        public override double GetPerimetro()
        {
            return 2 * Lado1 + 2 * Lado2;
        }


    }
}
