using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaGeometrica
{
    public class Rombo: Poligono
    {
        double diagonalMayor;
        double diagonalMenor;

        public double DiagonalMayor { get => diagonalMayor; set => diagonalMayor = value; }
        public double DiagonalMenor { get => diagonalMenor; set => diagonalMenor = value; }

        public Rombo(double diagonalMayor, double diagonalMenor) : base("Rombo", 4)
        {
            this.DiagonalMayor = diagonalMayor;
            this.DiagonalMenor = diagonalMenor;
        }

        public override double GetArea()
        {
            return (DiagonalMayor * DiagonalMenor) / 2;
        }

        public override double GetPerimetro()
        {
            return 2 * Math.Sqrt( Math.Pow(DiagonalMayor, 2) + Math.Pow(DiagonalMenor, 2));
        }
    }
}
