using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Store
    {
        //----Name of The Product----
        private string product;

        public string Product
        {
            get { return product; }
            set { product = value; }
        }

        //----Price----
        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        //----Kasher(True/False)----
        private bool kasher;

        public bool Kasher
        {
            get { return kasher; }
            set { kasher = value; }
        }

        //----Last Using----
        private int lastDate;

        public int LastDate
        {
            get { return lastDate; }
            set { lastDate = value; }
        }
        //**********************************************************************************

        //----Constructor getting Values for the properties of the class----
        public Store(string product, double price, bool kasher, int lastDate)
        {
            Product = product;
            Price = price;
            Kasher = kasher;
            LastDate = lastDate;
        }
        //Method
        public string GetDescription()
        {
            return $"Product: {Product} ,Price {Price} , Kasher {Kasher} , Last Using {LastDate}";

        }

        //Check if Pass the date
        public bool PassDate()
        {
            if (LastDate <= 2018)
                return false;
            else
                return true;
        }


        
    }
}
