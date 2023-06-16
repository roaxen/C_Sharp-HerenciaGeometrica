using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaGeometrica
{
    public class Rombo: Poligono
    {
        Double diagonalMayor;
        Double diagonalMenor;
        public Rombo(double diagonalMayor, double diagonalMenor) : base("Rombo", 4)
        {
            this.diagonalMayor = diagonalMayor;
            this.diagonalMenor = diagonalMenor;
        }

        public override double GetArea()
        {
            return (diagonalMayor * diagonalMenor) / 2;
        }

        public override double GetPerimetro()
        {
            return 2 * Math.Sqrt( Math.Pow(diagonalMayor, 2) + Math.Pow(diagonalMenor, 2));
        }
    }
}
