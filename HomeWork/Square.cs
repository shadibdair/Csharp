using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Square
    {
        // X
        public double X2 { get; set; }
        // Y
        public double Y2 { get; set; }
        // Color
        public string Color { get; set; }
        // Length
        private double length;

        public double Length
        {
            get { return length; }
            set
            {
                if (value >= 0)
                {
                    length = value;
                }
            }
        }

        //ctor
        public Square(double x2, double y2, string color, double length)
        {
            X2 = x2;
            Y2= y2;
            Color = color;
            Length = length;
        }

        //show us the Deteals of the Circle
        public string Print()
        {
            return $"this is the Square =>  X: {X2} , Y: {Y2}, Color: {Color} , Length: {Length}";
        }

        //function that calculat the Square
        public double Calculat1(double X2, double Y2)
        {
            double result =Length*Length;
            return (int)result;
        }
        public Double PrintCalculat1()
        {

            return Calculat1(X2, Y2);
        }

        //function that calculat the Square
        public double Calculat2(double X2, double Y2, double Length)
        {
            double result = Length * 4;
            return (int)result;
        }
        public Double PrintCalculat2()
        {

            return Calculat2(X2, Y2, Length);
        }
    }
}
