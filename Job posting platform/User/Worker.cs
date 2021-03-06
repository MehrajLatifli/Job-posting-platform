using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_posting_platform.User
{
 
    public  class Worker : Human, User
    {
        public Worker(string name, string surname,int age,string city, long phoneNumber, string email, string password) : base(name, surname, age)
        {
            City = city;
            PhoneNumber = phoneNumber;
            Email = email;
            ID = Worker_id++;
            Password = password;
        
            Age = age;
            Name = name;
            Surname = surname;
            WorkerRegTime = DateTime.Now.ToLocalTime().ToString();
        }

        public Worker()
        {
            ID = Worker_id++;
        }


        public string City { get; set; }

        public long PhoneNumber { get; set; }

        public string Email { get; set; }

        public int ID { get; set; }


        public string Password { get; set; }


        public string WorkerRegTime { get; set; }

        public static int Worker_id { get; set; } = 1;
      
        public override void HumanShow()
        {
            Console.WriteLine(" \n ==== Worker ===================================================== \n ");
            Console.WriteLine($" Worker's ID: \t\t\t {ID}");
            Console.WriteLine($" Worker's Fullname: \t\t {Name}  {Surname}");
            Console.WriteLine($" Worker's Age: \t\t\t {Age}");
            Console.WriteLine($" Worker's Password: \t\t {Password}");
        }

        public void UserShow()
        {
            Console.WriteLine($" Worker's City: \t\t {City}");
            Console.WriteLine($" Worker's Phone number: \t {PhoneNumber}");
            Console.WriteLine($" Worker's Email: \t\t {Email}");
            Console.WriteLine($" Worker's Registration time: \t {WorkerRegTime}");
            Console.WriteLine(" \n =================================================================== \n ");
        }
    }
}
