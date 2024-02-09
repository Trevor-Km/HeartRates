
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartRates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 to view HeartRates OR 2 to view HealthProfile");

            int ans = int.Parse(Console.ReadLine());
            if (ans == 1) {
                HeartRates hr1 = new HeartRates();
                Console.WriteLine("Please enter your last name");
                hr1.LastName = Console.ReadLine();
                Console.WriteLine("Please enter your first name");
                hr1.FirstName = Console.ReadLine();
                Console.WriteLine("Please enter your birth year");
                hr1.BirthYear = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the current year");
                hr1.CurrentYear = int.Parse(Console.ReadLine());
                hr1.displayPatientRecord();
            }
            if (ans == 2)
            {
                HealthProfile hp1 = new HealthProfile();
                Console.WriteLine("Please enter your last name");
                hp1.LastName = Console.ReadLine();
                Console.WriteLine("Please enter your first name");
                hp1.FirstName = Console.ReadLine();
                Console.WriteLine("Please enter your birth year");
                hp1.BirthYear = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter your height in inches");
                hp1.Height= int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter your weight in pounds");
                hp1.Weight= int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the current year");
                hp1.CurrentYear = int.Parse(Console.ReadLine());
                hp1.displayHealthRecord();
            }





        }

    }




 }
    

