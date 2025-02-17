using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elektros_kalkuliatorius_csharp
{
    class Gatherer
    {


        public double GetWatts()
        {
            while (true) // Loop until valid input is received
            {
                Console.WriteLine("Enter the power consumption of your device in watts:");
                string? input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input)) //Check for empty or whitespace-only input
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue; // Restart the loop
                }

                if (double.TryParse(input, out double watts))
                {
                    if (watts < 0)
                    {
                        Console.WriteLine("Power consumption cannot be negative. Please enter a positive number.");
                        continue;
                    }

                    return watts;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }

        public double GetHoursPerDay()
        {
            Console.WriteLine("Enter the number of hours the device runs per day:");
            string? hoursInput = Console.ReadLine();
            double hoursPerDay;

            if (!double.TryParse(hoursInput, out hoursPerDay))
            {
                Console.WriteLine("Invalid input for hours. Assuming 24 hours.");
                hoursPerDay = 24;
            }
            else if (hoursPerDay < 0)
            {
                Console.WriteLine("Invalid input for hours. Assuming 24 hours.");
                hoursPerDay = 24;
            }

            return hoursPerDay;
        }
    }
}
