using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Diagnostics;

namespace Job_posting_platform.Database
{
    [Serializable]
    public class Vacation
    {
        public Vacation( string vacationTitle, string vacationText, string vacatinoMail, string vacationMobile)
        {
  
            VacationTitle = vacationTitle;
            VacationText = vacationText;
            VacationEmail = vacatinoMail;
            VacationMobile = vacationMobile;
            ID = Vacation_id++;

        }


        public Vacation() { ID = Vacation_id++; }

        [XmlAttribute]
        public int ID { get; set; }
        [XmlAttribute]
        public static int Vacation_id { get; set; } = 1;
        [XmlAttribute]
        public string ChooseCountry { get; set; }
        [XmlAttribute]
        public string ChooseAge { get; set; }
        [XmlAttribute]
        public string ChooseCity { get; set; }
        [XmlAttribute]
        public string ChooseEducationDegree { get; set; }
        [XmlAttribute]
        public string ChooseSalary { get; set; }
        [XmlAttribute]
        public string ChooseTime { get; set; }
        [XmlAttribute]

        public string VacationEmail { get; set; }
        [XmlAttribute]
        public string VacationMobile { get; set; }
        [XmlAttribute]

        public string VacationTitle { get; set; }
        [XmlAttribute]

        public string VacationText { get; set; }
        [XmlAttribute]

        public string RequrementLanguage { get; set; }
        [XmlAttribute]

        public string RequrementJobExperience { get; set; }
        [XmlAttribute]

        public string VacancyStartTime { get => VacancyStartTimeShow(); set => value.ToString(); }
        [XmlAttribute]
        public string VacancyEndTime { get => VacancyEndTimeShow(); set => value.ToString(); }

        public string VacancyEndTimeShow()
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

        public string VacancyStartTimeShow()
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


        public void ShowVacation()
        {
            Console.WriteLine(" \n ==== Vacation ===================================================================================== \n ");
            Console.WriteLine($" ID of Vacation: \t\t {ID}");
            Console.WriteLine($" Name of Vacation: \t\t {VacationTitle}");
 
            Console.WriteLine($" Salary: \t\t\t {ChooseSalary}");
            Console.WriteLine($" Country: \t\t\t {ChooseCountry}");
            Console.WriteLine($" City: \t\t\t\t {ChooseCity}");
            Console.WriteLine($" Education degree: \t\t {ChooseEducationDegree}");
            Console.WriteLine($" Experience: \t\t\t {RequrementJobExperience}");
            Console.WriteLine($" Age: \t\t\t\t {ChooseAge}");
            Console.WriteLine($" Vacation Time: \t\t{VacancyStartTime}    -    {VacancyEndTime}");
            Console.WriteLine($" Vacation Contacts: \t\t {VacationEmail}    ||    {VacationMobile}");


        }
        public void ShowSecondPartofVacation()
        {
            Console.WriteLine($"\n\n About vacation: \n\n {VacationText} \n");
            Console.WriteLine($" Work time: \t\t\t {ChooseTime}");
            Console.WriteLine($" Language: \t\t\t {RequrementLanguage}, ");

        

            Console.WriteLine(" \n =================================================================================================== \n ");

        }

        public void ShowforFind()
        {
            Console.WriteLine(" \n ==== Vacation ===================================================================================== \n ");
            Console.WriteLine($" ID of Vacation: \t\t {ID}");
            Console.WriteLine($" Name of Vacation: \t\t {VacationTitle}");
 
            Console.WriteLine($" Salary: \t\t\t {ChooseSalary}");
            Console.WriteLine($" Country: \t\t\t {ChooseCountry}");
            Console.WriteLine($" City: \t\t\t\t {ChooseCity}");
            Console.WriteLine($" Education degree: \t\t {ChooseEducationDegree}");
            Console.WriteLine($" Experience: \t\t\t {RequrementJobExperience}");
            Console.WriteLine($" Age: \t\t\t\t {ChooseAge}");
            Console.WriteLine($" Vacation Time: \t\t{VacancyStartTime}    -    {VacancyEndTime}");
            Console.WriteLine($" Vacation Contacts: \t\t {VacationEmail}    ||    {VacationMobile}");

            Console.WriteLine($"\n\n About vacation: \n\n {VacationText} \n");
            Console.WriteLine($" Work time: \t\t\t {ChooseTime}");
            Console.WriteLine($" Language: \t\t\t {RequrementLanguage}, ");
            Console.WriteLine(" \n =================================================================================================== \n ");


        }

        }



}
