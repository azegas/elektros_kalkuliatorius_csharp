using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elektros_kalkuliatorius_csharp
{
    class Laiskanesys
    {
        public void WriteGatheredInfo(double watts, double kilowatts, double hoursPerDay)
        {
            Console.WriteLine("\n---------------------------------------");
            Console.WriteLine($"Your device ryja {watts:F2} watts, its power consumption is {kilowatts:F2} kWh and it runs {hoursPerDay} hours per day.");
        }
        public void WriteSpecificCostInfo(double cost, double hours)
        {

            Console.WriteLine($"\nScenario if the device is ran for {hours} hours:");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Daily run cost: {cost:C2}");
            Console.WriteLine($"Weekly cost: {(cost * 7):C2}");
            Console.WriteLine($"Monthly cost: {(cost * 30):C2}");
            Console.WriteLine($"Yearly cost: {(cost * 365):C2}");
            Console.WriteLine("---------------------------------------");
        }

        public void WriteOverallCostInfo(double cost)
        {
            Console.WriteLine($"\nScenario if the device is ran for 24 hours:");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Daily run cost: {cost:C2}");
            Console.WriteLine($"Weekly cost: {(cost * 7):C2}");
            Console.WriteLine($"Monthly cost: {(cost * 30):C2}");
            Console.WriteLine($"Yearly cost: {(cost * 365):C2}");
            Console.WriteLine("---------------------------------------");
        }
    }
}
