using System;

namespace Geometry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GeometricFigure triangle1 = new Triangle(5,12);
            GeometricFigure triangle2 = new Triangle(5,13);
            GeometricFigure square1= new Square(7);
            GeometricFigure square2 = new Square(10);
            GeometricFigure rectangle1 = new Rectangle(10,20);
            GeometricFigure rectangle2 = new Rectangle(5, 10);
            GeometricFigure pentagon1 = new Pentagon(5, 10);
            GeometricFigure pentagon2 = new Pentagon(8, 13);
            GeometricFigure hexagon1 = new Hexagon(5, 12);
            GeometricFigure hexagon2 = new Hexagon(7, 19);

            GeometricFigure[] arrayfigures = new GeometricFigure[10];
            arrayfigures[0] = triangle1;
            arrayfigures[1] = triangle2;
            arrayfigures[2] = square1;
            arrayfigures[3] = square2;
            arrayfigures[4] = rectangle1;
            arrayfigures[5] = rectangle2;
            arrayfigures[6] = pentagon1;
            arrayfigures[7]= pentagon2;
            arrayfigures[8]= hexagon1;
            arrayfigures[9]= hexagon2;

            for(int i=0; i<arrayfigures.Length; ++i)
            {
                arrayfigures[i].Print();
            }
        }
    }
}
