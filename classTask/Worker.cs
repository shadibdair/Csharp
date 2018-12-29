using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Worker:Person
    {
        private decimal salary;

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public Worker(string fullName, int age, string id, bool gender, decimal salary) :base(fullName,age,id,gender)
        {
            Salary = salary;
        }

        public new string print()
        {
            return base.print()+ $"Salary:{Salary}";
        }
    }
}
