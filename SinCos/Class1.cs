using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinCos
{
    public class Class1
    {
        private double x;

        public double X
        {
            get { return x;}
            set { x = value; }
        }
        public Class1()
        {
            x = 0;
        }
        public double Fool(double x) => Math.Sin(x) + Math.Cos(2*x);
        public override string ToString() 
        {
            return $"sin({x}) + cos(2 * {x})";
        }
        public string Summation(Class1 complex2) 
        {
            Class1 c3 = new Class1();
            c3.x = Math.Sin(x) + Math.Cos(2 * x);
            return c3.ToString();
        }
    }
}
