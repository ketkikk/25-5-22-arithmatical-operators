using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.Write("Enter age of a user");
            age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("User is a valid voter:" + age);
            }
            else
            {
                Console.WriteLine("User is not a valid voter:" + age);
            }
            if (age >= 60)
            {
                Console.WriteLine("User is a senior citizen:" + age);
            }
            else
            {
                Console.WriteLine("User is not a senior citizen:" + age);
            }
            int Day;
            Random rnd = new Random();
            int wday = rnd.Next(1, 6);
            Console.WriteLine("Enter Weekday    ");
            switch(wday)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thrusday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Something wents wrong!");
                    break;




            }
        }
    }
}
