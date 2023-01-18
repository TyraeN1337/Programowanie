using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeConsoleApp.Shapes
{
    class Tetragon
    {
        protected double sideA;
        protected double sideB;
        protected double sideC;
        protected double sideD;
        public Tetragon(double sideA, double sideB, double sideC, double sideD)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
            this.sideD = sideD;
        }
        public double Area()
        {
            return -1;
        }

        public double Perimeter()
        {
            return 2 * sideA + 2 * sideB;
        }

        public void ShowInfo()
        {

            Console.WriteLine("Informacja o prostokącie");
            Console.WriteLine("Bok a = " + sideA);
            Console.WriteLine("Bok b = " + sideB);
            Console.WriteLine("Bok c = " + sideC);
            Console.WriteLine("Bok d = " + sideD);
            Console.WriteLine("Pole " + Area());
            Console.WriteLine("Obwód " + Perimeter());
        }
    }
}
