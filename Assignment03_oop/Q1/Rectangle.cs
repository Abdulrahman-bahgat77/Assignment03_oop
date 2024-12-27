using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03_oop.Q1
{
    internal class Rectangle : Irectangle
    {
        public double Length { get ; set ; }
        public double width { get ; set  ; }
        public double Area {

             get {return width * Length; }
            }

        double IShape.Area { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Length={Length}\nWidth={width}\nArea={Area}");
        }
    }
}
