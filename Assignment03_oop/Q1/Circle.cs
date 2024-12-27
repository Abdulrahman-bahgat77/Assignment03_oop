using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03_oop.Q1
{
    internal class Circle : Icircle
    {
        public int Radius { get  ; set ; }
        public double Area {
            get { return Math.PI * Radius * Radius; }
        }

        double IShape.Area { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        // double Ishape.Area { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Radius={Radius}\nArea={Area}");
        }
    }
}
