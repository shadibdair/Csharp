using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle myCircle = new Circle(4,3,"Green",2);
            Console.WriteLine(myCircle.Print());
            Console.WriteLine("Calculat Inside:");
            Console.WriteLine(myCircle.PrintCalculat1());
            Console.WriteLine("Calculat Around:");
            Console.WriteLine(myCircle.PrintCalculat2());

            Square mySquare = new Square(2,3,"Red",5);
            Console.WriteLine(mySquare.Print());
            Console.WriteLine("Calculat Inside:");
            Console.WriteLine(mySquare.PrintCalculat1());
            Console.WriteLine("Calculat Around:");
            Console.WriteLine(mySquare.PrintCalculat2());


        }
    }
}
