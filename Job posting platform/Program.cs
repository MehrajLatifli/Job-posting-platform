
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Xml.Linq;



using System.Xml;
using System.Net.Mail;
using System.Net.Mime;
using System.Net;
using System.Reflection.Metadata;
using System.Xml.Xsl;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Diagnostics;
using Job_posting_platform.Exception_and_Notification;
using Job_posting_platform.Database;

namespace Job_posting_platform
{
    class Program
    {
        List<ExceptionLogIn> exceptionLogIn = new List<ExceptionLogIn>();


        public void ExceptionLogIn()
        {
            string message = "\n Log In is Incorrect";
            exceptionLogIn.Add(new ExceptionLogIn()
            {
                _message = message,
                TimeExeption = DateTime.Now,

            });


            using (var writer = new XmlTextWriter("ExceptionLogIn.xml", Encoding.UTF8))
            {
                writer.Formatting = System.Xml.Formatting.Indented;
                writer.WriteStartDocument();

                writer.WriteStartElement("ExceptionLogIn");

                foreach (var exeption in exceptionLogIn)
                {
                    writer.WriteStartElement("ExceptionLogIn");

                    writer.WriteAttributeString(nameof(exeption._message), exeption._message.ToString());
                    writer.WriteAttributeString(nameof(exeption.TimeExeption), exeption.TimeExeption.ToString());


                    writer.WriteEndElement();
                }


                writer.WriteEndElement();

                writer.WriteEndDocument();
            }



            XmlDocument exept = new XmlDocument();
            exept.Load("ExceptionLogIn.xml");
            var root = exept.DocumentElement;

            if (root.HasChildNodes)
            {
                foreach (XmlNode exept_node in root.ChildNodes)
                {
                    var exeption = new ExceptionLogIn
                    {

                        _message = exept_node.Attributes[0].Value,
                        TimeExeption = DateTime.Parse(exept_node.Attributes[1].Value),


                    };

                    exeption.ShowException();
                }
            }

        }
        static void Main(string[] args)
        {
         
            string name = "", surname = "", city = "", email = "", companyname="",password="";
            string lname = "", lpassword = "", lid = "";
            int age = 0;
            long phonenumber = 0;


            Database.Database database = new Database.Database();
            Program p = new Program();
            Vacation v = new Vacation();
            CV cv = new CV();
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Title = @"Author: Mehrac Lətifli  || Project : Job posting platform || Date: 5 March 2021 || Location: Azerbaijan. Baku";
            string vacationTitle = "", vacationText = "", vacatinoMail = "", vacationMobile = "";
            for (int i = 0; i < 1000; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
              
                Console.Clear();
                Console.WriteLine($"\n 1 <- Employer ");
                Console.WriteLine($" 2 <- Worker ");
                Console.WriteLine($" 3 <- Exit ");
                Console.Write($"\n Enter: ");
                string choose = Console.ReadLine();

                if (choose == "1")
                {
                    Console.WriteLine($"\n 1 <- Log In Employer ");
                    Console.WriteLine($"\n 2 <- Join Employer ");
                    Console.Write($"\n Enter: ");
                    string echoose = Console.ReadLine();
                    if (echoose == "2")
                    {
                        Thread.Sleep(2000);
                        Console.Clear();
                        database.AddEmployerstoDatabase(name, surname, age, city, phonenumber, email, companyname, password);
                    }
                    if (echoose == "1")
                    {
                     

                        if (database.LogInEmployersFromDatabase() == true)
                        {
                            Console.WriteLine($"\n 1 <- Show vacations ");
                            Console.WriteLine($"\n 2 <- Add Vacations ");
                            Console.WriteLine($"\n 3 <- Remove Vacations ");
                            Console.WriteLine($"\n 4 <- Update Vacations ");
                            Console.WriteLine($"\n 5 <- Find CV ");


                            Console.Write($"\n Enter: ");
                            string al = Console.ReadLine();
                            if (al == "1")
                            {
                               
                                database.ExampleAddVacations();
                                database.ExampleAddVacationsShow();
                                database.ShowVacation();

                            }

                            if (al == "2")
                            {
                                database.ShowVacation();

                                Console.Write($" Add Title of vacation : ");
                                vacationTitle = Console.ReadLine();

                                Console.Write($" Add Text of vacation: ");
                                vacationText = Console.ReadLine();

                                Console.Write($" Add Email address of vacation: ");
                                vacatinoMail = Console.ReadLine();

                                Console.Write($" Add phonenumber of vacation: ");
                                vacationMobile = Console.ReadLine();

                                database.AddVacation(vacationTitle, vacationText, vacatinoMail, vacationMobile);

                            }

                            if (al == "3")
                            {

                                database.ShowVacation();
                                database.RemoveVacations();

                            }

                            if (al == "4")
                            {
                                database.ShowVacation();
                                database.Update();

                            }
                            if (al == "5")
                            {

                       
                                database.ShowCV();
                                database.FindCV();

                            }
                        }
                        else
                        {
                            try
                            {

                                Console.ForegroundColor = ConsoleColor.Red;
                                DateTime time = DateTime.Now;
                                throw new ExceptionLogIn();
                                Console.ForegroundColor = ConsoleColor.White;


                            }
                            catch (ExceptionLogIn)
                            {
                                p.ExceptionLogIn();

                            }

                        }
                    }
                }

                if (choose == "2")
                {
                    Console.WriteLine($"\n 1 <- Log In Worker ");
                    Console.WriteLine($"\n 2 <- Join Worker ");
                    Console.Write($"\n Enter: ");
                    string wchoose = Console.ReadLine();

                    if (wchoose == "1")
                    {
                        if (database.LogInWorkersFromDatabase() == true)
                        {
                            Console.WriteLine($"\n 1 <- Show in cv ");
                            Console.WriteLine($"\n 2 <- Add CV ");
                            Console.WriteLine($"\n 3 <- Remove CV ");
                            Console.WriteLine($"\n 4 <- Update CV ");
                            Console.WriteLine($"\n 5 <- Find Job ");



                            Console.Write($"\n Enter: ");
                            string lcchoose = Console.ReadLine();
                            if (lcchoose == "1")
                            {
                                database.ExampleAddCV();
                                database.ExampleAddCVShow();
                                database.ShowCV();


                            }
                            if (lcchoose == "2")
                            {
                                database.ShowCV();
                                database.AddCV();
                            }

                            if (lcchoose == "3")
                            {
                                database.ShowCV();
                                database.RemoveCV();
                            }
                            if (lcchoose == "4")
                            {
                                database.ShowCV();
                                database.UpdateCV();
                            }
                            if (lcchoose == "5")
                            {

                                database.ShowVacation();
                                database.Find();
                            }
                        }
                        else
                        {
                            try
                            {

                                Console.ForegroundColor = ConsoleColor.Red;
                                DateTime time = DateTime.Now;
                                throw new ExceptionLogIn();
                                Console.ForegroundColor = ConsoleColor.White;


                            }
                            catch (ExceptionLogIn)
                            {
                                p.ExceptionLogIn();

                            }

                        }
                    }

                    if (wchoose == "2")
                    {
                        database.ShowWorker();
                        database.AddWorker();
                       
                    }


                }

                if (choose == "3")
                {
                    break;
                }




                    Console.ReadKey();
            }
        }
    }
}
