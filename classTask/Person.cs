using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Person
    {
        private string fullName;

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set
            { if (age >= 0 && age <= 120)
                {
                    age = value;
                }
            }
        }

        private string id;

        public string Id
        {
            get { return id; }
            set
            {
                int num;
                if(value.Length == 9 && int.TryParse(value,out num))
                {
                    id = value;
                }
            }
        }

        public bool Gender { get; set; }

        public  Person(string fullName, int age, string id, bool gender)
        {
            FullName=fullName;
            Age=age;
            Id=id;
            Gender=gender;
        }

        

        public string print()
        {
            return $"Person:FullName:{FullName}, Age:{Age}, Id:{Id} , Gender:{Gender}";
        }
    }
}
