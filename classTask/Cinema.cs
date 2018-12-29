using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Cinema
    {
        public string NameCinema { get; set; }

        private decimal priceMovie;

        public decimal PriceMovie
        {
            get { return priceMovie; }
            set
            {
                if(value >= 30 && value <=200)
                {
                    priceMovie = value;
                }
                
            }
        }


        public readonly int StudentDiscount;
        public readonly int TeacherDiscount;

        public Cinema()
        {
            Random rnd = new Random();
            StudentDiscount = rnd.Next(10, 21);
            TeacherDiscount = rnd.Next(5, 11);
        }
    }
}
