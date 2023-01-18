using System;



namespace ShapeConsoleApp.Shapes
{
    class Rectangle : Tetragon
    {
        public Rectangle() : base(21,37,21,37)
        {
        }
        public Rectangle(double sideA, double sideB): base(sideA,sideB,sideA,sideB)
        {
        }
        public new double Area()
        {
            return sideA * sideB;
        }
    }  
}


