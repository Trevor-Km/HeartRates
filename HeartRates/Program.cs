
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartRates
{
    internal class Program
    {
               static void Main(string[] args)
        {

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
    }
}
