using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Teacher:Person
    {
       
        public string ProfessionLearn { get; set; }
        public int YearsOfTeaching { get; set; }
        

        public Teacher(string fullName, int age, string id, bool gender, string professionLearn, int yearsOfTeaching) : base(fullName, age, id, gender)
        {
            ProfessionLearn = professionLearn;
            YearsOfTeaching = yearsOfTeaching;
        }

        public new string print()
        {
            return base.print() + $"ProfessionLearn:{ProfessionLearn} , YearsOfTeaching:{YearsOfTeaching}";
        }
    }
}
