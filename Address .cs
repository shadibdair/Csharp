using System;
using System.Collections.Generic;
using System.Text;

namespace step01
{
    class Address
    {
        private string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }


        private string country;

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        private string street;

        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        private int numberHome;

        public int NumberHome
        {
            get { return numberHome; }
            set { numberHome = value; }
        }

        public Address(string city, string country, string street, int numberHome)
        {
            City = city;
            Country = country;
            Street = street;
            NumberHome = numberHome;
        }

        public Address() {}

        

        public void PrintInfo()
        {
          Console.WriteLine($"City: {City}, Country: {Country}, Street: {Street} ,NumberHome: {NumberHome} "); 
        }

    }
}
