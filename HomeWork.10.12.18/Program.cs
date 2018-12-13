using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime thisDay = DateTime.Today;
            Console.WriteLine("Current Day:");
            Console.WriteLine(thisDay.ToString("d"));
            Console.WriteLine("");

            Store[] arr = new Store[6];
            arr[1] = new Store("Pastrami", 20,true,2019); 
            arr[2] = new Store("Hotdog", 55, true, 2020);  
            arr[3] = new Store("Popcorn", 35, false, 2018); 
            arr[4] = new Store("Velveeta", 90, true, 2019);
            arr[5] = new Store("Sandwich bread", 40, true, 2022);

            int Number =+1;
            for (int i = 1; i < arr.Length; i++)
            {
                Console.WriteLine(Number++ +"-" + arr[i ].GetDescription());
                Console.WriteLine("Pass the date ->>   "  + arr[i].PassDate());
            }

        }
    }
}
