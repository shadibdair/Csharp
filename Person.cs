﻿using System;
using System.Collections.Generic;
using System.Text;

namespace step01
{
    class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private Address informatin;

        public Address Informatin
        {
            get { return informatin; }
            set { informatin = value; }
        }

        public void PrintInfo()
        {
            string dateFormat = $"{ informatin.City }, { informatin.Country}, { informatin.NumberHome}, { informatin.Street}";
            System.Console.WriteLine($"Name: {Name}\t Information: {dateFormat}");
        }
    }
}
