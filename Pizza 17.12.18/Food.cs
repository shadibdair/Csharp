using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Food
    {
        private decimal price;

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public bool IsVeg { get; set; }

        public Food(decimal price,bool isVeg)
        {
            Price = price;
            IsVeg = isVeg;
        }
    }
}
