using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IF
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string firstName;
            string lastName;
            int yearOfBirth;
            Console.WriteLine("Whats your name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Whats your last name");
            lastName = Console.ReadLine();
            
            Console.WriteLine("Enter your year of birth:");
            yearOfBirth = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Hello, {firstName} {lastName}!");
            Console.WriteLine($"You are {2019 - yearOfBirth} years old.");
            Console.ReadLine();*/


            /*Start:
            int userNumber;
            Console.WriteLine("Enter a number from 1 to 10");
            userNumber = Int32.Parse(Console.ReadLine());

            


            if (userNumber < 5)
            {
                Console.WriteLine($"{userNumber} is less than 5.");
            }

            else if (userNumber > 5)
            {
                Console.WriteLine($"{userNumber} is greater than 5.");
            }

            else if (userNumber == 5)
            {
                Console.WriteLine($"{userNumber} equals to 5.");
            }


            
            goto Start;
            Console.ReadLine();*/


            int userNumber;
            Console.WriteLine("Enter a number from 1 to 10");
            userNumber = Int32.Parse(Console.ReadLine());

            if (userNumber >= 1 && userNumber <= 10)
            {
                if (userNumber < 5)
                {
                    Console.WriteLine($"{userNumber} is less than 5.");
                }

                else if (userNumber > 5)
                {
                    Console.WriteLine($"{userNumber} is greater than 5.");
                }

                else
                {
                    Console.WriteLine($"{userNumber} equals to 5.");
                }
            }           
            else
            {
                Console.WriteLine($"{userNumber} does not belong to the interval from 1 to 10");
            }

            Console.ReadLine();





        }
    }
}
