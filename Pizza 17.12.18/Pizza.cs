using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Pizza:Food
    {
        private int numOfSlices;

        public int NumOfSlices
        {
            get { return numOfSlices; }
            set { numOfSlices = value; }
        }

        private int numOfTopping;

        public int NumOfTopping
        {
            get { return numOfTopping; }
            set { numOfTopping = value; }
        }
        

        public Pizza(decimal price, bool isVeg , int numOfSlices , int numOfTopping) :base(price,isVeg)
        {
            NumOfSlices = numOfSlices;
            NumOfTopping = numOfTopping;


        }
    }
}
