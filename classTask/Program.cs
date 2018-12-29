using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        //3
        //function that Accepts array from Person ,return non
        static void Initarr(Person[] PersonArray)
        {

            for (int i = 0; i < PersonArray.Length; i++)
            {
                Random rnd = new Random();
                int choice = rnd.Next(0, 3);

                switch (choice)
                {
                   case 0:
                        PersonArray[i]= new Student("shadi bdair", 20, "315638965", true, "Ariel", "Computers");
                        break;
                   case 1:
                        PersonArray[i]=new Teacher("anna karp", 24, "362782734", false, "Tel-aviv", 4);
                        break;
                   case 2:
                        PersonArray[i] = new Worker("Lionel messi", 32, "234282734", true,50);
                        break;

                }
                
            }
        }

        static void printInfo(Person[] PersonArray, Cinema bestCinema)
        {
            decimal total = 0;
            int studentCount = 0;
            int teacherCount = 0;
            int workerCount = 0;

            foreach (Person p in PersonArray)
            {
                if(p is Student)
                {
                    studentCount++;
                    total += (int)((bestCinema.PriceMovie) * (decimal)(1 -( bestCinema.StudentDiscount / 100.0)));
                }
                else if (p is Teacher)
                {
                    teacherCount++;
                    total += (int)((bestCinema.PriceMovie) * (decimal)(1 - (bestCinema.TeacherDiscount / 100.0)));
                }
                else
                {
                    workerCount++;
                    total += bestCinema.PriceMovie;
                }
            }
            Console.WriteLine($"Total for this day: {total}");
            Console.WriteLine($"Price per movie: {bestCinema.PriceMovie}");
            Console.WriteLine($"Total clients: {PersonArray.Length}");
            Console.WriteLine($"Total studentCount: {studentCount}");
            Console.WriteLine($"Total teacherCount: {teacherCount}");
            Console.WriteLine($"Total workerCount: {workerCount}");
            Console.WriteLine($"StudentDiscount: {bestCinema.StudentDiscount}");
            Console.WriteLine($"TeacherDiscount: {bestCinema.TeacherDiscount}");
        }

        static void Main(string[] args)
        {
            Cinema myCinema = new Cinema();
            myCinema.PriceMovie = 35;
            myCinema.NameCinema = "Avatar";

            Person[] PersonArray = new Person[15];

            Initarr(PersonArray);
            printInfo(PersonArray, myCinema);
        }
    }
}
