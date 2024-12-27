using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03_oop.Q1
{
    internal interface Irectangle:IShape
    {
        public double Length { get; set; }
        public double width { get; set; }
    }
}
