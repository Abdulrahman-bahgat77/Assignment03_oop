using System.ComponentModel.DataAnnotations;
using Assignment03_oop.Q1;

namespace Assignment03_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part1
            //Q1==>b) To define a blueprint for a class
            //Q2==>a) private
            //Q3==>b) No
            //Q4==>b) Yes, interfaces can inherit from multiple interfaces
            //Q5==>d) implements
            //Q6==>a) Yes (after c#.8)
            //Q7==>b) No, all members are implicitly public
            //Q8==>b) To provide a clear separation between interface and class members
            //Q9==>b) No, interfaces cannot have constructors
            //Q10==>c) By separating interface names with commas


            #endregion


            #region Part2
            Circle circle = new Circle { Radius = 10 };
            circle.DisplayShapeInfo();
            Console.WriteLine("===========================================");
            Rectangle rectangle = new Rectangle{Length = 10,width=20};
            rectangle.DisplayShapeInfo();

            #endregion
        }
    }
}
