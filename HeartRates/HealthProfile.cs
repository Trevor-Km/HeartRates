using System;

namespace HeartRates
{

    public class HealthProfile
    {
        private string firstName;
        private string lastName;
        private int birthYear;
        private int currentYear;
        private int height;
        private int weight;


        public HealthProfile(string firstName, string lastName, int birthYear, int currentYear, int height, int weight)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthYear = birthYear;
            this.CurrentYear = currentYear;
            this.Height = height;
            this.Weight = weight;

        }

        public HealthProfile()
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

        public int Height
        {
            get { return height; }

            set
            {
                height = value;
            }
        }


        public int Weight
        {

            get
            {
                return weight;
            }

            set
            {
                weight = value;
            }
        }
        public int CalculateAge
        {
            get
            {
                return currentYear - birthYear;
            }
        }

        public int CalculateMaxHR
        {
            get
            {
                return 220 - CalculateAge;
            }
        }

        public double MinTargetHR
        {
            get
            {
                return CalculateMaxHR * 0.5;
            }
        }

        public double MaxTargetHR
        {
            get
            {
                return CalculateMaxHR * 0.85;
            }
        }

        public double calculateBMI(int height, int weight)
        {
            return (703 * weight) / (height * height);

        }

        public void displayHealthRecord()
        {
            drawLine();
            Console.WriteLine($"|  {"PATIENT HEALTH RECORD",53} {"|",25}");
            drawLine();
            Console.WriteLine($"| {"Patient Name ",-25} | {lastName + ", " + firstName,-50} |");
            drawLine();
            Console.WriteLine($"| {"Patient Birth Year ",-25} | {birthYear,50} |");
            drawLine();
            Console.WriteLine($"| {"Patient Age ",-25} | {CalculateAge,50} |");
            drawLine();
            Console.WriteLine($"| {"Patient Height ",-25} | {height+" in",50} |");
            drawLine();
            Console.WriteLine($"| {"Patient Weight ",-25} | {weight +" lbs",50} |");
            drawLine();
            Console.WriteLine($"| {"Maximum Heart Rate ",-25} | {CalculateMaxHR,50} |");
            drawLine();
            Console.WriteLine($"| {"Target Heart Rate Range ",-25} | {MinTargetHR + " - " + MaxTargetHR,50} |");
            drawLine();
            Console.WriteLine($"| {"BMI Numeric Value",-25} | {calculateBMI(Height, Weight),50} |");
            drawLine();
            Console.WriteLine($"| {"BMI Text Value",-25} | {bmiText(Height, Weight),-50} |");
            drawLine();
        }




       
        public string bmiText(int height, int weight) { 
            double BMI = calculateBMI(height, weight); 
             if (18>BMI) {
                return "Underweight";

            } else if (18 <= BMI&&BMI <= 24.9)
            {
                return "Normal";
            }
             else if (BMI > 24.9 && BMI <= 29.9)
            {
                return "Overweight";
            }
            else
            {
                return "Obese";
            }


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