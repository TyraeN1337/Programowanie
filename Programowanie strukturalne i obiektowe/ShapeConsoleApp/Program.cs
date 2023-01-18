using System;


namespace ShapeConsoleApp.Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle firstrectangle = new Rectangle();
            firstrectangle.ShowInfo();
          //  Rectangle secondrectangle = new Rectangle(2,4);
          //  secondrectangle.ShowInfo();

            Square firstsquare = new Square();
            firstsquare.ShowInfo();
        }
    }
}
