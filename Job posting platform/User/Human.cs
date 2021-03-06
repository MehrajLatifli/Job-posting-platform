using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_posting_platform.User
{
   public abstract class Human
    {
        public Human(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public Human()
        {
           
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Fullname => $" {Name}  {Surname} ";

        public override string ToString()
        {
            return $" \n Fullname: {Fullname} \n Name: {Age} ";
        }

        public abstract void HumanShow();
    }
}
