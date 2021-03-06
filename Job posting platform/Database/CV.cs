using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_posting_platform.Database
{
    public class CV
    {
  

        public CV() {

            ID = CVID++;
        }

        public CV(int cVChooseAge, string cVChooseEducationDegree, string cVChooseLanguageRequirement, string cVChooseJobExperience, float cVChooseVacationsalary, string cVProfilName, string cVProfilSurname, string cVEmail, string aboutWorkExperience, string wantedJob, long mobile)
        {
            CVChooseAge = cVChooseAge;
            CVChooseEducationDegree = cVChooseEducationDegree;
            CVChooseLanguageRequirement = cVChooseLanguageRequirement;
            CVChooseJobExperience = cVChooseJobExperience;
            CVChooseVacationsalary = cVChooseVacationsalary;
            CVProfilName = cVProfilName;
            CVProfilSurname = cVProfilSurname;
            CVEmail = cVEmail;
            AboutWorkExperience = aboutWorkExperience;
            WantedJob = wantedJob;
            Mobile = mobile;

            ID = CVID++;
        }

        public int ID { get; set; }
        public static int CVID { get; set; } = 1;
        public int CVChooseAge { get; set; }
        public string CVChooseEducationDegree { get; set; }
        public string CVChooseLanguageRequirement { get; set; }
        public string CVChooseJobExperience { get; set; }
        public float CVChooseVacationsalary { get; set; }
        public string CVProfilName { get; set; }
        public string CVProfilSurname { get; set; }
        public string CVEmail { get; set; }

        public string AboutWorkExperience { get; set; }

        public string WantedJob { get; set; }

        public long Mobile { get; set; }

        public void ShowCV()
        {
            Console.WriteLine(" \n ==== CV ===================================================================================== \n ");
            Console.WriteLine($" CV ID: \t\t\t {ID} ");
            Console.WriteLine($" Name: \t\t\t\t {CVProfilName}");
            Console.WriteLine($" Surname: \t\t\t {CVProfilSurname}");
            Console.WriteLine($" Age: \t\t\t\t {CVChooseAge}");
            Console.WriteLine($" Education Degree: \t\t {CVChooseEducationDegree}");
            Console.WriteLine($" Job Experience: \t\t {CVChooseJobExperience}");
            Console.WriteLine($" About Work Experience: \t\t {AboutWorkExperience}");
            Console.WriteLine($" Wanted Salary: \t\t {CVChooseVacationsalary}");
            Console.WriteLine($" Know language: \t\t {CVChooseLanguageRequirement}");
            Console.WriteLine($" Contacts: \t\t\t {Mobile}  || {CVEmail}");
            Console.WriteLine($" CV Time: \t\t\t {CVStartTime}  <====> {CVEndTime}");
            Console.WriteLine(" \n =================================================================================================== \n ");


        }
        public string CVStartTime { get => CVStartTimeShow(); set => value.ToString(); }
        public string CVEndTime { get => CVEndTimeShow(); set => value.ToString(); }

        public string CVEndTimeShow()
        {
            DateTime controlDate = DateTime.Now;

            var m = controlDate.Month + 1;

            string year_ = controlDate.Year.ToString();
            string month_ = m.ToString();
            string day_ = controlDate.Day.ToString();
            string hour_ = controlDate.Hour.ToString();
            string minute_ = controlDate.Minute.ToString();
            string second_ = controlDate.Minute.ToString();
            string millisecond_ = controlDate.Millisecond.ToString();


            string time = $" {day_} / {month_} / {year_} ||  {hour_}: {minute_}: {second_}";

            return time;

        }

        public string CVStartTimeShow()
        {
            DateTime controlDate = DateTime.Now;


            string year_ = controlDate.Year.ToString();
            string month_ = controlDate.Month.ToString();
            string day_ = controlDate.Day.ToString();
            string hour_ = controlDate.Hour.ToString();
            string minute_ = controlDate.Minute.ToString();
            string second_ = controlDate.Minute.ToString();
            string millisecond_ = controlDate.Millisecond.ToString();


            string time = $" {day_} / {month_} / {year_}  ||  {hour_}: {minute_}: {second_}";

            return time;

        }

  
    }


}
