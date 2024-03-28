/*
NAME:   CRISOSTOMO, JOSHUA B.
COURSE/SECTION: BSCPE 1-1
*/
using System;
public class SimpleTimeConversions
{
    internal class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("\t**SIMPLE TIME CONVERSIONS**");
            char choice;
            do
            {
                Console.WriteLine("\nSelect preferred time conversion");
                Console.WriteLine("(1) Seconds to Minutes");
                Console.WriteLine("(2) Minutes to Hours");
                Console.WriteLine("(3) Hours to Days");
                Console.WriteLine("(4) Days to Months");

                Console.Write("Enter your choice (1-4): ");
                int choiceSelection = Convert.ToInt32(Console.ReadLine());

                switch (choiceSelection)
                {
                    case 1:
                        Console.WriteLine("\n\t++Seconds to Minutes++");
                        Console.Write("Enter Seconds: ");
                        double seconds = Convert.ToInt64(Console.ReadLine());
                        double toMinutes = seconds / 60;
                        Console.WriteLine(seconds + " second is converted into " + toMinutes + " minute/s.");
                        break;
                    case 2:
                        Console.WriteLine("\n\t++Minutes to Hours++");
                        Console.Write("Enter Minutes: ");
                        double minutes = Convert.ToInt64(Console.ReadLine());
                        double toHours = minutes / 60;
                        Console.WriteLine(minutes + " minutes is converted into " + toHours + " hour/s.");
                        break;
                    case 3:
                        Console.WriteLine("\n\t++Hours to Days++");
                        Console.Write("Enter Hours: ");
                        double hours = Convert.ToInt64(Console.ReadLine());
                        double toDays = hours / 24;
                        Console.WriteLine(hours + " hours is converted into " + toDays + " day/s.");
                        break;
                    case 4:
                        Console.WriteLine("\n\t++Days to Months++");
                        Console.Write("Enter Days: ");
                        double days = Convert.ToInt64(Console.ReadLine());
                        double toMonths = days / 30.42;
                        Console.WriteLine(days + " days is converted into " + toMonths + " month/s.");
                        break;
                    default:
                        Console.WriteLine("Invalid Inputs.");
                        break;
                }

                Console.WriteLine("Do you want to convert time again? (Y/N)");
                choice = Convert.ToChar(Console.ReadLine());
            }
            while (choice == 'Y' || choice == 'y');
            Console.WriteLine("\nThank you for using the Time Conversion Calculator!");
        }
    }
}