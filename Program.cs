using System;

namespace step01
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Shadi = new Person();

            Shadi.Name = "Shadi";
            Shadi.Informatin = new Address("valladolid", "Spain", "colombos", 10);

            Shadi.PrintInfo();
           
                
        //    פניה לבנאי הריק
            Address address2 = new Address();
            address2.PrintInfo();
        }
    }
}
