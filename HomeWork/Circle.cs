using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Circle
    {
        // X
        public double X { get; set; }
        // Y
        public double Y { get; set; }
        // Color
        public string Color { get; set; }
        // Rdios
        private double rdios;

        public double Rdios
        {
            get { return rdios; }
            set
            {
                if(value >=0)
                {
                    rdios = value;
                } 
            }
        }

        //ctor
        public Circle(double x, double y,string color, double rdios)
        {
            X = x;
            Y = y;
            Color = color;
            Rdios = rdios;
        }
        
        //show us the Deteals of the Circle
        public  string Print()
        {
            return $"this is the Circle =>  X: {X} , Y: {Y}, Color: {Color} , Rdios: {rdios}";
        }

        //function that calculat the Circle
        public double Calculat1(double X, double Y)
        {
            double result = (double)(2 * 3.14159265358979 * (X * Y));
            return (int)result;
        }
        public Double PrintCalculat1()
        {

            return Calculat1(X, Y);
        }

        //function that calculat the Circle
        public double Calculat2(double X, double Y, double Rdios)
        {
            double result = (double)(2 * 3.14159265358979 * X );
            return (int)result;
        }
        public Double PrintCalculat2()
        {

            return Calculat2(X, Y, Rdios);
        }
    }
}
