using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /* declare variables */
            string name;
            DateTime dateOfBirth = new DateTime(2000, 1, 1);
            DateTime today = DateTime.Today;
            int age;
            bool exceptionRaised;

            /* read name*/
            do
            {
                Console.WriteLine("Insert your name:");
                name = Console.ReadLine();
            }
            while (name == "");

            /* read date of birth */
            exceptionRaised = true;
            while(exceptionRaised)
            {
                try
                {
                    Console.WriteLine("Insert your date of birth:");
                    dateOfBirth = Convert.ToDateTime(Console.ReadLine());
                    exceptionRaised = false;
                }
                catch
                {
                    Console.WriteLine("Invalid input, please try again.\n");
                }
            }

            /* compute age */
            if (today.Year > dateOfBirth.Year)
            {
                age = today.Year - dateOfBirth.Year;
                if (today.Month < dateOfBirth.Month)
                    age -= 1;
                else if (today.Month == dateOfBirth.Month)
                    age -= today.Day < dateOfBirth.Day ? 1 : 0;
            }
            else
            {
                age = 0;
            }

            /* print hello world */
            Console.WriteLine();
            Console.WriteLine("Your letter to the World could be:");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Hello, dear World.");
            Console.WriteLine("My name is " + name + " and I'am "+ age + " years old.");
            Console.WriteLine("Nice to meet you.");
            Console.ReadKey();
        }
    }
}
