using System;

namespace DailyReport
{
    internal class Program
    {
        private static void Main(string[] args) //entry point of a console application
        {
            Console.WriteLine("The Tech Academy\nStudent Daily Report"); //Commands to write the different pieces of text

            Console.WriteLine("What is your name?"); //Question 1 
            string studentName = Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine(); //Question 2

            Console.WriteLine("What page number?");
            string pageNum_string = Console.ReadLine();
            int pageNum = Convert.ToInt32(pageNum_string); //Question 3 with a conversion to integer

            Console.WriteLine("Do you need help with anything?\n(answer 'true', or 'false' only)");
            string help_string = Console.ReadLine();
            bool help = Convert.ToBoolean(help_string); //Question with conversion to Boolean string

            Console.WriteLine("Where there any positive experiences you'd like to share? Please give specifics.");
            string studentExp = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string studentFeedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string studentHours_string = Console.ReadLine();
            int studentHours = Convert.ToInt32(studentHours_string);

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine(); \\Final Command once questions are completed

        
        }
    }
}