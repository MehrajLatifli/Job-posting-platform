using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_posting_platform.User
{
    class Employer : Human, User
    {
        public string City { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }
        public int ID { get; set; }
        public static int Employer_id { get; set; } = 1;
        public string EmployerRegTime { get; set; }

        public string CompanyName { get; set; }
        public string Password { get; set; }



        public Employer(string name, string surname, int age, string city, long phone, string mail, string companyname, string password):base(name,surname,age)
        {
            Name = name;
            Surname = surname;
            Age = age;
            City = city;
            PhoneNumber = phone;
            Email = mail;
            CompanyName = companyname;
            Password = password;
            ID = Employer_id++;
            EmployerRegTime = DateTime.Now.ToLocalTime().ToString();
        }

        public Employer()
        {
            ID = Employer_id++;
        }


        public override void HumanShow()
        {
            Console.WriteLine(" \n ==== Employer ===================================================== \n ");
            Console.WriteLine($" Employer's ID: \t\t {ID}");
            Console.WriteLine($" Employer's Paswords: \t\t {Password}");
            Console.WriteLine($" Employer's Name: \t\t {Name}");
            Console.WriteLine($" Employer's Surname: \t\t {Surname}");
            Console.WriteLine($" Employer's Age: \t\t {Age}");
       


        }

        public void UserShow()
        {
            Console.WriteLine($" Employer's City: \t\t {City}");
            Console.WriteLine($" Employer's Phone number: \t {PhoneNumber}");
            Console.WriteLine($" Employer's Email: \t\t {Email}");

        }

        public void CompanyNameShow()
        {
            Console.WriteLine($" Employer's Name of Company: \t {CompanyName}");
  


        }
        public void EmployerRegisterTimeShow()
        {
            Console.WriteLine($" Employer's posting time: \t {EmployerRegTime}");
            Console.WriteLine(" \n =================================================================== \n ");

        }


        public void showEployerforOtherPeople()
        {
            Console.WriteLine(" \n ==== Employer ===================================================== \n ");
            Console.WriteLine($" Employer's ID: \t\t {ID}");
     
            Console.WriteLine($" Employer's Name: \t\t {Name}");
            Console.WriteLine($" Employer's Surname: \t\t {Surname}");
            Console.WriteLine($" Employer's Age: \t\t {Age}");
            UserShow();
            CompanyNameShow();
            EmployerRegisterTimeShow();
        }





        }
}
