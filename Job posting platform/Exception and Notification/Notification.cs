using Job_posting_platform.Exception_and_Notification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_posting_platform.Exception_and_Notification
{
    abstract class Notification
    {
        public Notification(string message, DateTime timeExeption)
        {
            _message = message;
            TimeExeption = timeExeption;
        }

        public Notification()
        {
            _message = " Incorrect";
            TimeExeption = DateTime.Now;


        }

        public Notification(string message)
        {
            _message = message;


        }

        public string Message
        {

            get { return _message; }


        }

        public string _message { get; set; }
        public DateTime TimeExeption { get; set; }

        public abstract void ShowNotification();
    }
}

class AddNotification : Notification
{
    public AddNotification()
    {

    }

    public override void ShowNotification()
    {
        Console.WriteLine(" \n ==== AddNotification ============================================================================== \n ");
        Console.WriteLine($" Message: \t\n {_message} ");
        Console.WriteLine($" \n Notification time: \t\t\t {TimeExeption} ");
        Console.WriteLine(" \n =================================================================================================== \n ");
        Console.ForegroundColor = ConsoleColor.White;
    }

    
}

class JoinNotificationAddListForAdmin : Notification
{
    public JoinNotificationAddListForAdmin()
    {

    }

    public override void ShowNotification()
    {
        Console.WriteLine(" \n ==== JoinNotificationAddList ============================================================================== \n ");
        Console.WriteLine($" Message: \t\n {_message} ");
        Console.WriteLine($" \n Notification time: \t\t\t {TimeExeption} ");
        Console.WriteLine(" \n =================================================================================================== \n ");
        Console.ForegroundColor = ConsoleColor.White;
    }


}

class RemoveNotification : Notification
{
    public RemoveNotification()
    {

    }

    public override void ShowNotification()
    {
        Console.WriteLine(" \n ==== RemoveNotification =========================================================================== \n ");
        Console.WriteLine($" Message: \t\n {_message} ");
        Console.WriteLine($" \n Notification time: \t\t\t {TimeExeption} ");
        Console.WriteLine(" \n =================================================================================================== \n ");
        Console.ForegroundColor = ConsoleColor.White;
    }


}

class UpdateNotification : Notification
{
    public UpdateNotification()
    {

    }

    public override void ShowNotification()
    {
        Console.WriteLine(" \n ==== UpdateNotification =========================================================================== \n ");
        Console.WriteLine($" Message: \t\n {_message} ");
        Console.WriteLine($" \n Notification time: \t\t\t {TimeExeption} ");
        Console.WriteLine(" \n =================================================================================================== \n ");
        Console.ForegroundColor = ConsoleColor.White;
    }


}


class FindNotification : Notification
{
    public FindNotification()
    {

    }

    public override void ShowNotification()
    {
        Console.WriteLine(" \n ==== FindNotification ============================================================================= \n ");
        Console.WriteLine($" Message: \t\n {_message} ");
        Console.WriteLine($" \n Notification time: \t\t\t {TimeExeption} ");
        Console.WriteLine(" \n =================================================================================================== \n ");
        Console.ForegroundColor = ConsoleColor.White;
    }


}