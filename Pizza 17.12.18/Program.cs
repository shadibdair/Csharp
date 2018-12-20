using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            Food[] FoodArray = new Food[6];
            FoodArray[0]= new Pizza(85, false, 8, 3);
            FoodArray[1] = new Pizza(100, true, 8, 2);
            FoodArray[2] = new Pizza(120, true, 12, 5);
            FoodArray[3] = new Chips(20,false,true, true);
            FoodArray[4] = new Chips(10, true, false, true);
            FoodArray[5] = new Chips(35,false,true, false);

            for (int i = 0; i < FoodArray.Length; i++)
            {
                if (FoodArray[i] is Pizza)
                {
                    Console.WriteLine("------------Pizza------------");
                    Console.WriteLine($"Price Of Pizza:{FoodArray[i].Price}  Slices:{((Pizza)FoodArray[i]).NumOfSlices}  Topping:{((Pizza)FoodArray[i]).NumOfTopping}");
                    Console.WriteLine("Your Pizza :" + (FoodArray[i].IsVeg ? "veg" : "not veg"));
                }
                else
                {
                    Console.WriteLine("------------Chips------------");
                    Console.WriteLine($"Price Of Chips:{FoodArray[i].Price}");
                    Console.WriteLine("Your Chips :" + (FoodArray[i].IsVeg ? "veg" : "not veg"));
                    Console.WriteLine("Extra :" + (((Chips)FoodArray[i]).IsExtraBig ? "Yes" : "No"));
                    Console.WriteLine("with dipps :" + (((Chips)FoodArray[i]).IsWithDipps ? "No" : "No"));

                }

                Console.WriteLine("Mr.Shadi ;)");
            }
        }
    }
}
