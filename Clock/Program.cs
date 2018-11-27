using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.5.1
            Clock miTiempo = new Clock();
            //1.5.2
            Console.WriteLine($"mi tiempo:{miTiempo.Show()}");
            //1.5.3
            miTiempo.Milliseconds += 2;
            //1.5.4
            Console.WriteLine($"mi tiempo:{miTiempo.Show()}");
            //1.5.5
            miTiempo.SetMidDay();
            //1.5.6
            miTiempo.Milliseconds += 3;
            //1.5.7
            Console.WriteLine($"mi tiempo:{miTiempo.Show()}");
            //1.5.8
            Clock suTiempo = new Clock();
            //1.5.9
            suTiempo.SetMidNight();
            //1.5.10
            Console.WriteLine($"su tiempo:{suTiempo.Show()}");

        }
    }
}
