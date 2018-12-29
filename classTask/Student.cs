using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Student:Person
    {
        public string LocalStudy { get; set; }
        public string ProfessionStudy { get; set; }

        public Student(string fullName, int age, string id, bool gender, string localStudy, string professionStudy) : base(fullName, age, id, gender)
        {
            LocalStudy = localStudy;
            ProfessionStudy = professionStudy;
        }

        public new string print()
        {
            return base.print()+ $"LocalStudy:{LocalStudy} , ProfessionStudy:{ProfessionStudy}";
        }
    }
}
