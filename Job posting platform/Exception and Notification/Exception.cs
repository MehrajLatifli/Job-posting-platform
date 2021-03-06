using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Job_posting_platform.Exception_and_Notification
{

    abstract class ExceptionBase : ApplicationException
    {
        public string _message { get; set; }
        public DateTime TimeExeption { get; set; }

        public ExceptionBase()
        {
            _message = " Incorrect";
            TimeExeption = DateTime.Now;



        }

        public ExceptionBase(string message)
        {
            _message = message;


        }

        public string Message
        {

            get { return _message; }


        }

        public abstract void ShowException();
        

    }



    class ExceptionChooseSalary : ExceptionBase
    {
        public ExceptionChooseSalary()
        {

        }

        public override void ShowException()
        {
            Console.WriteLine(" \n ==== Exception ChooseSalary ======================================================================= \n ");
            Console.WriteLine($" Message: \t\n {_message} ");
            Console.WriteLine($" \n Exeption time: \t\t\t {TimeExeption} ");
            Console.WriteLine(" \n =================================================================================================== \n ");
            Console.ForegroundColor = ConsoleColor.Red;
        }
    }

    class ExceptionChooseExperience : ExceptionBase
    {
        public ExceptionChooseExperience()
        {

        }

        public override void ShowException()
        {
            Console.WriteLine(" \n ==== Exception ChooseExperience =================================================================== \n ");
            Console.WriteLine($" Message: \t\n {_message} ");
            Console.WriteLine($" \n Exeption time: \t\t\t {TimeExeption} ");
            Console.WriteLine(" \n =================================================================================================== \n ");
            Console.ForegroundColor = ConsoleColor.Red;
        }
    }

    class ExceptionChooseLanguage : ExceptionBase
    {
        public ExceptionChooseLanguage()
        {

        }

        public override void ShowException()
        {
            Console.WriteLine(" \n ==== Exception ChooseLanguage ===================================================================== \n ");
            Console.WriteLine($" Message: \t\n {_message} ");
            Console.WriteLine($" \n Exeption time: \t\t\t {TimeExeption} ");
            Console.WriteLine(" \n =================================================================================================== \n ");
            Console.ForegroundColor = ConsoleColor.Red;
        }
    }


    class ExceptionChooseVacationWorktTime : ExceptionBase
    {
        public ExceptionChooseVacationWorktTime()
        {

        }

        public override void ShowException()
        {
            Console.WriteLine(" \n ==== Exception ChooseVacationWorktTime ===================================================================== \n ");
            Console.WriteLine($" Message: \t\n {_message} ");
            Console.WriteLine($" \n Exeption time: \t\t\t {TimeExeption} ");
            Console.WriteLine(" \n ============================================================================================================ \n ");
            Console.ForegroundColor = ConsoleColor.Red;
        }
    }

    class ExceptionChooseVacationEducationDegree : ExceptionBase
    {
        public ExceptionChooseVacationEducationDegree()
        {

        }

        public override void ShowException()
        {
            Console.WriteLine(" \n ==== Exception ChooseVacationEducationDegree =============================================================== \n ");
            Console.WriteLine($" Message: \t\n {_message} ");
            Console.WriteLine($" \n Exeption time: \t\t\t {TimeExeption} ");
            Console.WriteLine(" \n ============================================================================================================ \n ");
            Console.ForegroundColor = ConsoleColor.Red;
        }
    }

    class ExceptionChooseAge : ExceptionBase
    {
        public ExceptionChooseAge()
        {

        }

        public override void ShowException()
        {
            Console.WriteLine(" \n ==== Exception ChooseAge ================================================================================== \n ");
            Console.WriteLine($" Message: \t\n {_message} ");
            Console.WriteLine($" \n Exeption time: \t\t\t {TimeExeption} ");
            Console.WriteLine(" \n ============================================================================================================ \n ");
            Console.ForegroundColor = ConsoleColor.Red;
        }
    }

    class ExceptionUpdate : ExceptionBase
    {
        public ExceptionUpdate()
        {

        }

        public override void ShowException()
        {
            Console.WriteLine(" \n ==== Exception Update ====================================================================================== \n ");
            Console.WriteLine($" Message: \t\n {_message} ");
            Console.WriteLine($" \n Exeption time: \t\t\t {TimeExeption} ");
            Console.WriteLine(" \n ============================================================================================================ \n ");
            Console.ForegroundColor = ConsoleColor.Red;
        }
    }

    class ExceptionFind : ExceptionBase
    {
        public ExceptionFind()
        {

        }

        public override void ShowException()
        {
            Console.WriteLine(" \n ==== Exception Find ======================================================================================== \n ");
            Console.WriteLine($" Message: \t\n {_message} ");
            Console.WriteLine($" \n Exeption time: \t\t\t {TimeExeption} ");
            Console.WriteLine(" \n ============================================================================================================ \n ");
            Console.ForegroundColor = ConsoleColor.Red;
        }
    }

    class ExceptionJoin : ExceptionBase
    {
        public ExceptionJoin()
        {

        }

        public override void ShowException()
        {
            Console.WriteLine(" \n ==== Exception Join ======================================================================================== \n ");
            Console.WriteLine($" Message: \t\n {_message} ");
            Console.WriteLine($" \n Exeption time: \t\t\t {TimeExeption} ");
            Console.WriteLine(" \n ============================================================================================================ \n ");
            Console.ForegroundColor = ConsoleColor.Red;
        }
    }

    class ExceptionMail : ExceptionBase
    {
        public ExceptionMail()
        {

        }

        public override void ShowException()
        {
            Console.WriteLine(" \n ==== Exception Mail ======================================================================================== \n ");
            Console.WriteLine($" Message: \t\n {_message} ");
            Console.WriteLine($" \n Exeption time: \t\t\t {TimeExeption} ");
            Console.WriteLine(" \n ============================================================================================================ \n ");
            Console.ForegroundColor = ConsoleColor.Red;
        }
    }

    class ExceptionLogIn : ExceptionBase
    {
        public ExceptionLogIn()
        {

        }

        public override void ShowException()
        {
            Console.WriteLine(" \n ==== Exception LogIn ======================================================================================== \n ");
            Console.WriteLine($" Message: \t\n {_message} ");
            Console.WriteLine($" \n Exeption time: \t\t\t {TimeExeption} ");
            Console.WriteLine(" \n ============================================================================================================ \n ");
            Console.ForegroundColor = ConsoleColor.Red;
        }
    }

    class ExeptionRemove : ExceptionBase
    {
        public ExeptionRemove()
        {

        }

        public override void ShowException()
        {
            Console.WriteLine(" \n ==== Exception Remove ======================================================================================== \n ");
            Console.WriteLine($" Message: \t\n {_message} ");
            Console.WriteLine($" \n Exeption time: \t\t\t {TimeExeption} ");
            Console.WriteLine(" \n ============================================================================================================ \n ");
            Console.ForegroundColor = ConsoleColor.Red;
        }
    }

    class ExeptionFilling : ExceptionBase
    {
        public ExeptionFilling()
        {

        }

        public override void ShowException()
        {
            Console.WriteLine(" \n ==== Exception Filling =====================================================================================\n ");
            Console.WriteLine($" Message: \t\n {_message} ");
            Console.WriteLine($" \n Exeption time: \t\t\t {TimeExeption} ");
            Console.WriteLine(" \n ============================================================================================================ \n ");
            Console.ForegroundColor = ConsoleColor.Red;
        }
    }
}
