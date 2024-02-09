using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace HeartRates
{
    internal class HeartRates
    {
        private string firstName;
        private string lastName;
        private int birthYear;
        private int currentYear;


        public HeartRates(string firstName, string lastName, int birthYear, int currentYear)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthYear = birthYear;
            this.CurrentYear = currentYear;
        }

        public HeartRates()
        {
        }
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public int BirthYear
        {
            get
            {
                return birthYear;
            }
            set
            {
                birthYear = value;
            }
        }
        public int CurrentYear
        {
            get
            {
                return currentYear;
            }
            set
            {
                currentYear = value;
            }
        }

        public int CalcAge
        {
            get
            {
                return currentYear - birthYear;
            }
        }

        public int CalcMaxHR
        {
            get
            {
                return 220 - CalcAge;
            }
        }

        public double MinTargetHR
        {
            get
            {
                return CalcMaxHR * 0.5;
            }
        }

        public double MaxTargetHR
        {
            get
            {
                return CalcMaxHR * 0.85;
            }
        }

        private int CalculateAge(int birthYear, int currentYear)
        {
            return currentYear - birthYear;

        }
        private int CalculateHR(int birthYear, int currentYear)
        {
            int age = CalculateAge(birthYear, currentYear);
            return 220 - age;

        }


        private string CalculateTargetRange(int birthYear, int currentYear)
        {

            int heartRate = CalculateHR(birthYear, currentYear);
            double target1 = heartRate * 0.5;
            double target2 = heartRate * 0.85;
            return $"{target1} - {target2} ";

        }

        public void displayPatientRecord()
        {
            drawLine();
            Console.WriteLine($"|  {"PATIENT HEART RATE RECORDS",53} {"|",25}");
            drawLine();
            Console.WriteLine($"| {"Patient Name ",-25} | {lastName + ", " + firstName,-50} |");
            drawLine();
            Console.WriteLine($"| {"Patient Birth Year ",-25} | {birthYear,50} |");
            drawLine();
            Console.WriteLine($"| {"Patient Age ",-25} | {CalcAge,50} |");
            drawLine();
            Console.WriteLine($"| {"Maximum Heart Rate ",-25} | {CalcMaxHR,50} |");
            drawLine();
            Console.WriteLine($"| {"Target Heart Rate Range ",-25} | {MinTargetHR + " - " + MaxTargetHR,50} |");
            drawLine();

        }

        public static void drawLine()
        {
            Console.Write("|");
            for (int i = 0; i < 80; i++)

                Console.Write("-");
            Console.WriteLine("|");


        }

    }
}
