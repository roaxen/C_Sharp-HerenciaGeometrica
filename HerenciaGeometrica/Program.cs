using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaGeometrica
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int opcion;
            Console.WriteLine("Opcion\n1) Metodo Automatico\n2) Metodo Consola ");
            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
                CreacionFormasAuto();
            else if (opcion == 2)
                CreacionFormasConsola();
            else
                Console.WriteLine("Opcion no permitida, CERRANDO PROGRAMA");

            Console.WriteLine("\nPulse una tecla para cerrar .... ");
            Console.ReadLine();

        }
        public static void CreacionFormasAuto()
        {
            List<Forma> diagrama = new List<Forma>();
            int opcion;
            bool seguirCreandoFormas = true;
            Random rand = new Random();

            Console.WriteLine("\t INICIANDO PROGRAMA: Creacion de Diagrama de formas Automatico");
            while (seguirCreandoFormas)
            {
                opcion = rand.Next(0, 4);

                switch (opcion)
                {
                    case 0:
                        seguirCreandoFormas = false;
                        break;

                    case 1:
                        diagrama.Add(new Circulo(rand.Next()));
                        Console.WriteLine("Se ha creado un Circulo ");
                        break;

                    case 2:
                        diagrama.Add(new Rectangulo(rand.Next(), rand.Next()));
                        Console.WriteLine("Se ha creado un Rectangulo ");
                        break;

                    case 3:
                        diagrama.Add(new Rombo(rand.Next(), rand.Next()));
                        Console.WriteLine("Se ha creado un Rombo ");
                        break;

                    default:
                        Console.WriteLine("ERROR EN EL SWICTH ---> OPCION NO ENCONTRADA");
                        break;
                }
            }
            CalculoTotal(diagrama);
        }

        public static void CreacionFormasConsola()
        {

            List<Forma> diagrama = new List<Forma>();
            int opcion;

            Console.WriteLine("\t INICIANDO PROGRAMA: Creacion de Diagrama de formas");

            while (true)
            {
                opcion = MenuFormasCreacion();

                if (opcion != 0)
                {
                    Forma objetoCreado = CreacionForma(opcion);
                    diagrama.Add(objetoCreado);
                }
                else
                    break;
            }

            CalculoTotal(diagrama);
        }


        public static void CalculoTotal(List<Forma> diagrama)
        {
            Double areaTotal = 0;
            Double perimetroTotal = 0;

            for (int i = 0; i < diagrama.Count(); i++)
            {
                areaTotal += diagrama[i].GetArea();
                perimetroTotal += diagrama[i].GetPerimetro();
            }

            Console.WriteLine("\nHas creado un totdal de " + diagrama.Count() + " figuras");
            Console.WriteLine("\tEl area total es de : " + areaTotal);
            Console.WriteLine("\tEl perimetro total es de : " + perimetroTotal);
        }


        public static int MenuFormasCreacion()
        {
            List<string> nombreFormas = new List<string> { "Circulo", "Rectangulo", "Rombo" };
            int opcion = 0;

            Console.WriteLine("Que quieres Crear ? ");

            for (int i = 0; i < nombreFormas.Count; i++)
            {
                Console.WriteLine(i + 1 + ")    " + nombreFormas[i]);
            }

            Console.WriteLine(0 + ")    Calcular el Area y Perimetro Total");
            opcion = int.Parse(Console.ReadLine());
            
            return opcion;
        }


        public static Forma CreacionForma(int opcion)
        {
            Forma formaCreda = null;
            switch (opcion)
            {
                case 1:
                    formaCreda = CreacionCirculo();
                    break;

                case 2:
                    formaCreda = CreacionRectangulo();
                    break;

                case 3:
                    formaCreda = CreacionRombo();
                    break;

                default:
                    Console.WriteLine("ERROR EN EL SWICTH ---> OPCION NO ENCONTRADA");
                    break;
            }

            return formaCreda;
        }

        public static Circulo CreacionCirculo()
        {
            double radio;

            Console.WriteLine("Necesito el Radio");
            Console.WriteLine("Radio :");
            radio = double.Parse(Console.ReadLine());

            return new Circulo(radio);
        }

        public static Rectangulo CreacionRectangulo()
        {
            double LadoLargo;
            double LadoCorto;

            Console.WriteLine("Necesito el Lado grande y el Lado Corto ");
            Console.WriteLine("Lado grande :");
            LadoLargo = double.Parse(Console.ReadLine());
            Console.WriteLine("Lado Corto :");
            LadoCorto = double.Parse(Console.ReadLine());

            return new Rectangulo(LadoLargo, LadoCorto);
        }

        public static Rombo CreacionRombo()
        {
            double diagonalMayor;
            double diagonalMenor;

            Console.WriteLine("Necesito el Diagonal Mayor y el Diagonal Menor ");
            Console.WriteLine("Diagonal Mayor :");
            diagonalMayor = double.Parse(Console.ReadLine());
            Console.WriteLine("Diagonal Menor :");
            diagonalMenor = double.Parse(Console.ReadLine());

            return new Rombo(diagonalMayor, diagonalMenor);
        }
    }
}
